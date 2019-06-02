namespace Kalaidina
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
            this.Generate_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ex1_radioButton = new System.Windows.Forms.RadioButton();
            this.Ex2_radioButton = new System.Windows.Forms.RadioButton();
            this.Ex3_radioButton = new System.Windows.Forms.RadioButton();
            this.Ex4_radioButton = new System.Windows.Forms.RadioButton();
            this.Ex5_radioButton = new System.Windows.Forms.RadioButton();
            this.Ex6_radioButton = new System.Windows.Forms.RadioButton();
            this.Success_textBox = new System.Windows.Forms.TextBox();
            this.Success_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate_button
            // 
            this.Generate_button.Location = new System.Drawing.Point(386, 31);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(234, 140);
            this.Generate_button.TabIndex = 0;
            this.Generate_button.Text = "Сгенерировать";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ex6_radioButton);
            this.groupBox1.Controls.Add(this.Ex5_radioButton);
            this.groupBox1.Controls.Add(this.Ex4_radioButton);
            this.groupBox1.Controls.Add(this.Ex3_radioButton);
            this.groupBox1.Controls.Add(this.Ex2_radioButton);
            this.groupBox1.Controls.Add(this.Ex1_radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите номер генерируемой задачи";
            // 
            // Ex1_radioButton
            // 
            this.Ex1_radioButton.AutoSize = true;
            this.Ex1_radioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ex1_radioButton.Location = new System.Drawing.Point(7, 20);
            this.Ex1_radioButton.Name = "Ex1_radioButton";
            this.Ex1_radioButton.Size = new System.Drawing.Size(75, 20);
            this.Ex1_radioButton.TabIndex = 0;
            this.Ex1_radioButton.TabStop = true;
            this.Ex1_radioButton.Text = "Задача 1";
            this.Ex1_radioButton.UseVisualStyleBackColor = true;
            // 
            // Ex2_radioButton
            // 
            this.Ex2_radioButton.AutoSize = true;
            this.Ex2_radioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ex2_radioButton.Location = new System.Drawing.Point(6, 43);
            this.Ex2_radioButton.Name = "Ex2_radioButton";
            this.Ex2_radioButton.Size = new System.Drawing.Size(75, 20);
            this.Ex2_radioButton.TabIndex = 0;
            this.Ex2_radioButton.TabStop = true;
            this.Ex2_radioButton.Text = "Задача 2";
            this.Ex2_radioButton.UseVisualStyleBackColor = true;
            // 
            // Ex3_radioButton
            // 
            this.Ex3_radioButton.AutoSize = true;
            this.Ex3_radioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ex3_radioButton.Location = new System.Drawing.Point(6, 66);
            this.Ex3_radioButton.Name = "Ex3_radioButton";
            this.Ex3_radioButton.Size = new System.Drawing.Size(75, 20);
            this.Ex3_radioButton.TabIndex = 0;
            this.Ex3_radioButton.TabStop = true;
            this.Ex3_radioButton.Text = "Задача 3";
            this.Ex3_radioButton.UseVisualStyleBackColor = true;
            this.Ex3_radioButton.CheckedChanged += new System.EventHandler(this.SetEx);
            // 
            // Ex4_radioButton
            // 
            this.Ex4_radioButton.AutoSize = true;
            this.Ex4_radioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ex4_radioButton.Location = new System.Drawing.Point(6, 89);
            this.Ex4_radioButton.Name = "Ex4_radioButton";
            this.Ex4_radioButton.Size = new System.Drawing.Size(75, 20);
            this.Ex4_radioButton.TabIndex = 0;
            this.Ex4_radioButton.TabStop = true;
            this.Ex4_radioButton.Text = "Задача 4";
            this.Ex4_radioButton.UseVisualStyleBackColor = true;
            // 
            // Ex5_radioButton
            // 
            this.Ex5_radioButton.AutoSize = true;
            this.Ex5_radioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ex5_radioButton.Location = new System.Drawing.Point(6, 112);
            this.Ex5_radioButton.Name = "Ex5_radioButton";
            this.Ex5_radioButton.Size = new System.Drawing.Size(75, 20);
            this.Ex5_radioButton.TabIndex = 0;
            this.Ex5_radioButton.TabStop = true;
            this.Ex5_radioButton.Text = "Задача 5";
            this.Ex5_radioButton.UseVisualStyleBackColor = true;
            // 
            // Ex6_radioButton
            // 
            this.Ex6_radioButton.AutoSize = true;
            this.Ex6_radioButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ex6_radioButton.Location = new System.Drawing.Point(6, 135);
            this.Ex6_radioButton.Name = "Ex6_radioButton";
            this.Ex6_radioButton.Size = new System.Drawing.Size(75, 20);
            this.Ex6_radioButton.TabIndex = 0;
            this.Ex6_radioButton.TabStop = true;
            this.Ex6_radioButton.Text = "Задача 6";
            this.Ex6_radioButton.UseVisualStyleBackColor = true;
            this.Ex6_radioButton.CheckedChanged += new System.EventHandler(this.SetEx);
            // 
            // Success_textBox
            // 
            this.Success_textBox.Location = new System.Drawing.Point(386, 221);
            this.Success_textBox.Name = "Success_textBox";
            this.Success_textBox.Size = new System.Drawing.Size(234, 20);
            this.Success_textBox.TabIndex = 3;
            // 
            // Success_label
            // 
            this.Success_label.AutoSize = true;
            this.Success_label.Location = new System.Drawing.Point(445, 205);
            this.Success_label.Name = "Success_label";
            this.Success_label.Size = new System.Drawing.Size(115, 13);
            this.Success_label.TabIndex = 4;
            this.Success_label.Text = "Результат генерации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Success_label);
            this.Controls.Add(this.Success_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Generate_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ex6_radioButton;
        private System.Windows.Forms.RadioButton Ex5_radioButton;
        private System.Windows.Forms.RadioButton Ex4_radioButton;
        private System.Windows.Forms.RadioButton Ex3_radioButton;
        private System.Windows.Forms.RadioButton Ex2_radioButton;
        private System.Windows.Forms.RadioButton Ex1_radioButton;
        private System.Windows.Forms.TextBox Success_textBox;
        private System.Windows.Forms.Label Success_label;
    }
}

