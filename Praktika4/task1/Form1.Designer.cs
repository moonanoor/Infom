namespace task1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Сумма = new System.Windows.Forms.RadioButton();
            this.Произведение = new System.Windows.Forms.RadioButton();
            this.Выбор = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 43);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(396, 247);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввод числа";
            // 
            // Сумма
            // 
            this.Сумма.AutoSize = true;
            this.Сумма.Location = new System.Drawing.Point(462, 39);
            this.Сумма.Name = "Сумма";
            this.Сумма.Size = new System.Drawing.Size(85, 17);
            this.Сумма.TabIndex = 4;
            this.Сумма.TabStop = true;
            this.Сумма.Text = "radioButton1";
            this.Сумма.UseVisualStyleBackColor = true;
            this.Сумма.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Произведение
            // 
            this.Произведение.AutoSize = true;
            this.Произведение.Location = new System.Drawing.Point(462, 73);
            this.Произведение.Name = "Произведение";
            this.Произведение.Size = new System.Drawing.Size(85, 17);
            this.Произведение.TabIndex = 5;
            this.Произведение.TabStop = true;
            this.Произведение.Text = "radioButton2";
            this.Произведение.UseVisualStyleBackColor = true;
            // 
            // Выбор
            // 
            this.Выбор.Location = new System.Drawing.Point(428, 12);
            this.Выбор.Name = "Выбор";
            this.Выбор.Size = new System.Drawing.Size(160, 100);
            this.Выбор.TabIndex = 7;
            this.Выбор.TabStop = false;
            this.Выбор.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Произведение);
            this.Controls.Add(this.Сумма);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Выбор);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Алгоритм с  циспользованием циклов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Сумма;
        private System.Windows.Forms.RadioButton Произведение;
        private System.Windows.Forms.GroupBox Выбор;
    }
}

