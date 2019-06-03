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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generate_button = new System.Windows.Forms.Button();
            this.Success_textBox = new System.Windows.Forms.TextBox();
            this.Success_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Generate_button
            // 
            this.Generate_button.Location = new System.Drawing.Point(47, 15);
            this.Generate_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(312, 53);
            this.Generate_button.TabIndex = 0;
            this.Generate_button.Text = "Сгенерировать";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // Success_textBox
            // 
            this.Success_textBox.Location = new System.Drawing.Point(47, 116);
            this.Success_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Success_textBox.Name = "Success_textBox";
            this.Success_textBox.Size = new System.Drawing.Size(311, 22);
            this.Success_textBox.TabIndex = 3;
            // 
            // Success_label
            // 
            this.Success_label.AutoSize = true;
            this.Success_label.Location = new System.Drawing.Point(125, 96);
            this.Success_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Success_label.Name = "Success_label";
            this.Success_label.Size = new System.Drawing.Size(149, 17);
            this.Success_label.TabIndex = 4;
            this.Success_label.Text = "Результат генерации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 165);
            this.Controls.Add(this.Success_label);
            this.Controls.Add(this.Success_textBox);
            this.Controls.Add(this.Generate_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.TextBox Success_textBox;
        private System.Windows.Forms.Label Success_label;
    }
}

