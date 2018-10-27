using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot;
using OxyPlot.Series;

namespace RGZ_3
{
    public partial class MainForm : Form
    {
        private Form results = new Form
        {
            Width = 600,
            Height = 600,
            StartPosition = FormStartPosition.CenterScreen
        };

        Dictionary<double, double> originalObject;
        List<Dictionary<double, double>> models;
        List<ModelBuilding.CoreType> types;

        delegate double Func(double x);
        Func function;

        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            showButton.Enabled = true;

            double m, d, x1, x2, delta;
            int n;
            function = null;
            models = null;
            types = null;

            try
            {
                m = Convert.ToDouble(mTextBox.Text);
                d = Convert.ToDouble(dTextBox.Text);
                n = Convert.ToInt32(nTextBox.Text);
                x1 = Convert.ToDouble(x1TextBox.Text);
                x2 = Convert.ToDouble(x2TextBox.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Введены некорректные данные.", "Ошибка ввода");
                return;
            }

            delta = Math.Abs(x1 - x2) / n;

            if (x1 > x2)
            {
                double t = x1;
                x1 = x2;
                x2 = t;
            }

            if (linearRadioButton.Checked)
                function = Function.LinearFunction;
            else if (squareRadioButton.Checked)
                function = Function.SquareFunction;
            else if (nonLinearRadioButton.Checked)
                function = Function.NonLinearFunction;

            originalObject = new Dictionary<double, double>();

            for (double i = x1; i < x2; i += delta)            
                originalObject.Add(i, function(i) + Statistics.MpcGenerator(m, 0, d, 1)[0]);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (originalObject == null)
            {
                MessageBox.Show("Объект не был сгенерирован", "Ошибка");
                return;
            }

            double x1, x2, delta;
            int n;

            try
            {
                n = Convert.ToInt32(nTextBox.Text);
                x1 = Convert.ToDouble(x1TextBox.Text);
                x2 = Convert.ToDouble(x2TextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные.", "Ошибка ввода");
                return;
            }

            delta = Math.Abs(x1 - x2) / n;

            FunctionSeries reg = null;

            ScatterSeries orObj = new ScatterSeries()
            {
                Title = "Объект с помехой",
                MarkerType = MarkerType.Circle
            };

            foreach (var v in originalObject)
                orObj.Points.Add(new ScatterPoint(v.Key, v.Value, 1.8));

            FunctionSeries f = new FunctionSeries(T => { return function(T); }, x1, x2, delta)
            {
                Title = "Объект"
            };

            PlotModel plot = new PlotModel()
            {
                Title = "График"
            };
            
            PlotView view = new PlotView()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Model = plot
            };

            plot.Series.Add(orObj);
            plot.Series.Add(f);

            results.Controls.Add(view);

            if (models != null)
            {
                string typeName = "";

                for (int i = 0; i < types.Count; i++)
                {
                    switch (types.ElementAt(i))
                    {
                        case ModelBuilding.CoreType.Recatangle:
                            typeName = rectCheckBox.Text;
                            break;

                        case ModelBuilding.CoreType.Triangle:
                            typeName = triCheckBox.Text;
                            break;

                        case ModelBuilding.CoreType.Parabola:
                            typeName = parCheckBox.Text;
                            break;

                        case ModelBuilding.CoreType.Cube:
                            typeName = cubeCheckBox.Text;
                            break;
                    }
                    reg = new FunctionSeries()
                    {
                        Title = "Регрессия (" + typeName + ")"
                    };
                    for (int j = 0; j < models[i].Count; j++)
                        reg.Points.Add(new DataPoint(models[i].ElementAt(j).Key, models[i].ElementAt(j).Value));

                    plot.Series.Add(reg);
                }                
            }

            results.Refresh();
            results.ShowDialog();
            results.Controls.Clear();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            if (originalObject == null)
            {
                MessageBox.Show("Объект не был сгенерирован", "Ошибка");
                return;
            }

            double x1, x2, delta;
            int n;

            try
            {
                n = Convert.ToInt32(nTextBox.Text);
                x1 = Convert.ToDouble(x1TextBox.Text);
                x2 = Convert.ToDouble(x2TextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные.", "Ошибка ввода");
                return;
            }

            delta = Math.Abs(x1 - x2) / n;

            types = new List<ModelBuilding.CoreType>();
            models = new List<Dictionary<double, double>>();

            if (rectCheckBox.Checked)
                types.Add(ModelBuilding.CoreType.Recatangle);
            if (triCheckBox.Checked)
                types.Add(ModelBuilding.CoreType.Triangle);
            if (parCheckBox.Checked)
                types.Add(ModelBuilding.CoreType.Parabola);
            if (cubeCheckBox.Checked)
                types.Add(ModelBuilding.CoreType.Cube);

            foreach(var type in types)
            {
                ModelBuilding modelBuilding = new ModelBuilding(delta, type);
                GoldenRatio goldenRatio = new GoldenRatio(originalObject, modelBuilding);
                var model = new Dictionary<double, double>();

                modelBuilding.B = goldenRatio.FindMin(0.00001, 0, 0.9);

                double coreXN, reg, temp = 0;
                int tempIndL = 0, tempIndJ = 0;
                bool flag = false;
                for (int i = 0; i < originalObject.Count; i++)
                {
                    coreXN = 0; reg = 0;
                    flag = false;

                    for (int l = tempIndL; l < originalObject.Count; l++)
                    {
                        temp = modelBuilding.CoreFunction(originalObject.ElementAt(i).Key, originalObject.ElementAt(l).Key);
                        if (temp != 0 && !flag)
                        {
                            flag = true;
                            tempIndL = l;
                            coreXN += temp;
                        }
                        else if (temp != 0)
                        {
                            coreXN += temp;
                        }
                        else if (temp == 0 && flag)
                            break;
                    }

                    flag = false;

                    for (int j = tempIndJ; j < originalObject.Count; j++)
                    {
                        temp = modelBuilding.CoreFunction(originalObject.ElementAt(i).Key, originalObject.ElementAt(j).Key);

                        if (temp != 0 && !flag)
                        {
                            flag = true;
                            tempIndJ = j;
                            reg += (temp / coreXN) * originalObject.ElementAt(j).Value;
                        }
                        else if (temp != 0)
                        {
                            reg += (temp / coreXN) * originalObject.ElementAt(j).Value;
                        }
                        else if (temp == 0 && flag)
                            break;
                    }

                    model.Add(originalObject.ElementAt(i).Key, reg);
                }

                models.Add(model);
            }
        }

        private void rectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!rectCheckBox.Checked && !triCheckBox.Checked && !parCheckBox.Checked && !cubeCheckBox.Checked)
                buildButton.Enabled = false;
            else
                buildButton.Enabled = true;
        }

        private void triCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!rectCheckBox.Checked && !triCheckBox.Checked && !parCheckBox.Checked && !cubeCheckBox.Checked)
                buildButton.Enabled = false;
            else
                buildButton.Enabled = true;
        }

        private void parCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!rectCheckBox.Checked && !triCheckBox.Checked && !parCheckBox.Checked && !cubeCheckBox.Checked)
                buildButton.Enabled = false;
            else
                buildButton.Enabled = true;
        }

        private void cubeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!rectCheckBox.Checked && !triCheckBox.Checked && !parCheckBox.Checked && !cubeCheckBox.Checked)
                buildButton.Enabled = false;
            else
                buildButton.Enabled = true;
        }
    }
    
}
