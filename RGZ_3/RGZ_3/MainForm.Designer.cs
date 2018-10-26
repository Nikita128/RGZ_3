namespace RGZ_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.nonLinearRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.linearRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cubicRadioButton = new System.Windows.Forms.RadioButton();
            this.parRadioButton = new System.Windows.Forms.RadioButton();
            this.triRadioButton = new System.Windows.Forms.RadioButton();
            this.rectRadioButton = new System.Windows.Forms.RadioButton();
            this.buildButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.x2TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.x1TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nTextBox);
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mTextBox);
            this.groupBox1.Controls.Add(this.nonLinearRadioButton);
            this.groupBox1.Controls.Add(this.squareRadioButton);
            this.groupBox1.Controls.Add(this.linearRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация объекта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Размер выборки n";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(125, 96);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(81, 20);
            this.nTextBox.TabIndex = 10;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(11, 239);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(99, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Параметры аддитивной помехи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "d";
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(141, 209);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(65, 20);
            this.dTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "m";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(36, 209);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(65, 20);
            this.mTextBox.TabIndex = 1;
            // 
            // nonLinearRadioButton
            // 
            this.nonLinearRadioButton.AutoSize = true;
            this.nonLinearRadioButton.Location = new System.Drawing.Point(11, 65);
            this.nonLinearRadioButton.Name = "nonLinearRadioButton";
            this.nonLinearRadioButton.Size = new System.Drawing.Size(128, 17);
            this.nonLinearRadioButton.TabIndex = 0;
            this.nonLinearRadioButton.TabStop = true;
            this.nonLinearRadioButton.Text = "Нелинейный объект";
            this.nonLinearRadioButton.UseVisualStyleBackColor = true;
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(11, 42);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(137, 17);
            this.squareRadioButton.TabIndex = 0;
            this.squareRadioButton.TabStop = true;
            this.squareRadioButton.Text = "Квадратичный объект";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            // 
            // linearRadioButton
            // 
            this.linearRadioButton.AutoSize = true;
            this.linearRadioButton.Location = new System.Drawing.Point(11, 19);
            this.linearRadioButton.Name = "linearRadioButton";
            this.linearRadioButton.Size = new System.Drawing.Size(116, 17);
            this.linearRadioButton.TabIndex = 0;
            this.linearRadioButton.TabStop = true;
            this.linearRadioButton.Text = "Линейный объект";
            this.linearRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buildButton);
            this.groupBox2.Controls.Add(this.cubicRadioButton);
            this.groupBox2.Controls.Add(this.parRadioButton);
            this.groupBox2.Controls.Add(this.triRadioButton);
            this.groupBox2.Controls.Add(this.rectRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Построение модели";
            // 
            // cubicRadioButton
            // 
            this.cubicRadioButton.AutoSize = true;
            this.cubicRadioButton.Location = new System.Drawing.Point(11, 88);
            this.cubicRadioButton.Name = "cubicRadioButton";
            this.cubicRadioButton.Size = new System.Drawing.Size(111, 17);
            this.cubicRadioButton.TabIndex = 0;
            this.cubicRadioButton.TabStop = true;
            this.cubicRadioButton.Text = "Кубическое ядро";
            this.cubicRadioButton.UseVisualStyleBackColor = true;
            // 
            // parRadioButton
            // 
            this.parRadioButton.AutoSize = true;
            this.parRadioButton.Location = new System.Drawing.Point(11, 65);
            this.parRadioButton.Name = "parRadioButton";
            this.parRadioButton.Size = new System.Drawing.Size(137, 17);
            this.parRadioButton.TabIndex = 0;
            this.parRadioButton.TabStop = true;
            this.parRadioButton.Text = "Параболическое ядро";
            this.parRadioButton.UseVisualStyleBackColor = true;
            // 
            // triRadioButton
            // 
            this.triRadioButton.AutoSize = true;
            this.triRadioButton.Location = new System.Drawing.Point(11, 42);
            this.triRadioButton.Name = "triRadioButton";
            this.triRadioButton.Size = new System.Drawing.Size(117, 17);
            this.triRadioButton.TabIndex = 0;
            this.triRadioButton.TabStop = true;
            this.triRadioButton.Text = "Треугольное ядро";
            this.triRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectRadioButton
            // 
            this.rectRadioButton.AutoSize = true;
            this.rectRadioButton.Location = new System.Drawing.Point(11, 19);
            this.rectRadioButton.Name = "rectRadioButton";
            this.rectRadioButton.Size = new System.Drawing.Size(132, 17);
            this.rectRadioButton.TabIndex = 0;
            this.rectRadioButton.TabStop = true;
            this.rectRadioButton.Text = "Прямоугольное ядро";
            this.rectRadioButton.UseVisualStyleBackColor = true;
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(11, 123);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 7;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Enabled = false;
            this.showButton.Location = new System.Drawing.Point(297, 200);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(90, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Показать";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Область определения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "x кон.";
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(154, 153);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(52, 20);
            this.x2TextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "x нач.";
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(51, 153);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(50, 20);
            this.x1TextBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 298);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РГЗ 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.RadioButton nonLinearRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.RadioButton linearRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cubicRadioButton;
        private System.Windows.Forms.RadioButton parRadioButton;
        private System.Windows.Forms.RadioButton triRadioButton;
        private System.Windows.Forms.RadioButton rectRadioButton;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Label label4;
    }
}

