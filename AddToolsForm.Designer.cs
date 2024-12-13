namespace Production
{
    partial class AddToolsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label ToolsNameLabel;
        private System.Windows.Forms.TextBox ToolsNameTextBox;
        private System.Windows.Forms.Button ToolsButton;

        /// <summary>
        /// Освобождает все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">Указывает, нужно ли освобождать управляемые ресурсы.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Метод инициализации компонентов формы.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolsNameLabel = new System.Windows.Forms.Label();
            this.ToolsNameTextBox = new System.Windows.Forms.TextBox();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.Toolslabel3 = new System.Windows.Forms.Label();
            this.ToolstextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToolsNameLabel
            // 
            this.ToolsNameLabel.AutoSize = true;
            this.ToolsNameLabel.Location = new System.Drawing.Point(14, 9);
            this.ToolsNameLabel.Name = "ToolsNameLabel";
            this.ToolsNameLabel.Size = new System.Drawing.Size(124, 16);
            this.ToolsNameLabel.TabIndex = 0;
            this.ToolsNameLabel.Text = "Тип инструмента:";
            // 
            // ToolsNameTextBox
            // 
            this.ToolsNameTextBox.Location = new System.Drawing.Point(12, 28);
            this.ToolsNameTextBox.Name = "ToolsNameTextBox";
            this.ToolsNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.ToolsNameTextBox.TabIndex = 1;
            // 
            // ToolsButton
            // 
            this.ToolsButton.Location = new System.Drawing.Point(11, 177);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(294, 25);
            this.ToolsButton.TabIndex = 2;
            this.ToolsButton.Text = "Добавить";
            this.ToolsButton.UseVisualStyleBackColor = true;
            // 
            // Toolslabel3
            // 
            this.Toolslabel3.AutoSize = true;
            this.Toolslabel3.Location = new System.Drawing.Point(14, 117);
            this.Toolslabel3.Name = "Toolslabel3";
            this.Toolslabel3.Size = new System.Drawing.Size(164, 16);
            this.Toolslabel3.TabIndex = 5;
            this.Toolslabel3.Text = "Описание инструмента:";
            // 
            // ToolstextBox3
            // 
            this.ToolstextBox3.Location = new System.Drawing.Point(12, 136);
            this.ToolstextBox3.Name = "ToolstextBox3";
            this.ToolstextBox3.Size = new System.Drawing.Size(293, 22);
            this.ToolstextBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название инструмента:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 14;
            // 
            // AddToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 212);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolstextBox3);
            this.Controls.Add(this.Toolslabel3);
            this.Controls.Add(this.ToolsButton);
            this.Controls.Add(this.ToolsNameTextBox);
            this.Controls.Add(this.ToolsNameLabel);
            this.Name = "AddToolsForm";
            this.Text = "Добавление инструмента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label Toolslabel3;
        private System.Windows.Forms.TextBox ToolstextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
