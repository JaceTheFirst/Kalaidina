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
            this.Success_textBox = new System.Windows.Forms.TextBox();
            this.Success_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Generate_button
            // 
            this.Generate_button.Location = new System.Drawing.Point(35, 12);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(234, 43);
            this.Generate_button.TabIndex = 0;
            this.Generate_button.Text = "Сгенерировать";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // Success_textBox
            // 
            this.Success_textBox.Location = new System.Drawing.Point(35, 94);
            this.Success_textBox.Name = "Success_textBox";
            this.Success_textBox.Size = new System.Drawing.Size(234, 20);
            this.Success_textBox.TabIndex = 3;
            // 
            // Success_label
            // 
            this.Success_label.AutoSize = true;
            this.Success_label.Location = new System.Drawing.Point(94, 78);
            this.Success_label.Name = "Success_label";
            this.Success_label.Size = new System.Drawing.Size(115, 13);
            this.Success_label.TabIndex = 4;
            this.Success_label.Text = "Результат генерации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 134);
            this.Controls.Add(this.Success_label);
            this.Controls.Add(this.Success_textBox);
            this.Controls.Add(this.Generate_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.TextBox Success_textBox;
        private System.Windows.Forms.Label Success_label;
    }
}

