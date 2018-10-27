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
        Dictionary<double, double> model;

        delegate double Func(double x);
        Func function;

        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            double m, d, x1, x2, delta;
            int n;
            function = null;

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

            ScatterSeries orObj = new ScatterSeries();
            foreach (var v in originalObject)
                orObj.Points.Add(new ScatterPoint(v.Key, v.Value, 4));

            FunctionSeries f = new FunctionSeries(T => { return function(T); }, x1, x2, delta);

            PlotModel plot = new PlotModel()
            {
                Title = "Объект"
            };
            
            PlotView view = new PlotView()
            {
                Dock = DockStyle.Left,
                BackColor = Color.White,
                Height = 550,
                Width = 550,
                Model = plot
            };

            plot.Series.Add(orObj);
            plot.Series.Add(f);

            results.Controls.Add(view);

            results.Refresh();
            results.ShowDialog();
            results.Controls.Remove(view);
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
            ModelBuilding.CoreType coreType = 0;

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

            if (rectRadioButton.Checked)
                coreType = ModelBuilding.CoreType.Recatangle;
            else if (triRadioButton.Checked)
                coreType = ModelBuilding.CoreType.Triangle;
            else if (parRadioButton.Checked)
                coreType = ModelBuilding.CoreType.Parabola;
            else if (cubicRadioButton.Checked)
                coreType = ModelBuilding.CoreType.Cube;

            ModelBuilding modelBuilding = new ModelBuilding(delta, coreType);
            GoldenRatio goldenRatio = new GoldenRatio(originalObject, modelBuilding);


        }
    }
}
