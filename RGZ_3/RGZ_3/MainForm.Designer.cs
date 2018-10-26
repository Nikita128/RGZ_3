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
            this.linearRadioButton = new System.Windows.Forms.RadioButton();
            this.squaredRadioButton = new System.Windows.Forms.RadioButton();
            this.nonLinearRadioButton = new System.Windows.Forms.RadioButton();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.showButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rectRadioButton = new System.Windows.Forms.RadioButton();
            this.triRadioButton = new System.Windows.Forms.RadioButton();
            this.parRadioButton = new System.Windows.Forms.RadioButton();
            this.cubicRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.showButton1);
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mTextBox);
            this.groupBox1.Controls.Add(this.nonLinearRadioButton);
            this.groupBox1.Controls.Add(this.squaredRadioButton);
            this.groupBox1.Controls.Add(this.linearRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация объекта";
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
            // squaredRadioButton
            // 
            this.squaredRadioButton.AutoSize = true;
            this.squaredRadioButton.Location = new System.Drawing.Point(11, 42);
            this.squaredRadioButton.Name = "squaredRadioButton";
            this.squaredRadioButton.Size = new System.Drawing.Size(137, 17);
            this.squaredRadioButton.TabIndex = 0;
            this.squaredRadioButton.TabStop = true;
            this.squaredRadioButton.Text = "Квадратичный объект";
            this.squaredRadioButton.UseVisualStyleBackColor = true;
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
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(36, 158);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(65, 20);
            this.mTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "d";
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(141, 158);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(65, 20);
            this.dTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Параметры аддитивной помехи:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(11, 188);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Генерация";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // showButton1
            // 
            this.showButton1.Enabled = false;
            this.showButton1.Location = new System.Drawing.Point(92, 188);
            this.showButton1.Name = "showButton1";
            this.showButton1.Size = new System.Drawing.Size(75, 23);
            this.showButton1.TabIndex = 7;
            this.showButton1.Text = "Показать";
            this.showButton1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cubicRadioButton);
            this.groupBox2.Controls.Add(this.parRadioButton);
            this.groupBox2.Controls.Add(this.triRadioButton);
            this.groupBox2.Controls.Add(this.rectRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Построение модели";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button showButton1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.RadioButton nonLinearRadioButton;
        private System.Windows.Forms.RadioButton squaredRadioButton;
        private System.Windows.Forms.RadioButton linearRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cubicRadioButton;
        private System.Windows.Forms.RadioButton parRadioButton;
        private System.Windows.Forms.RadioButton triRadioButton;
        private System.Windows.Forms.RadioButton rectRadioButton;
    }
}

