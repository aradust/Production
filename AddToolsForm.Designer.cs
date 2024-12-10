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
            this.SuspendLayout();
            // 
            // ToolsNameLabel
            // 
            this.ToolsNameLabel.AutoSize = true;
            this.ToolsNameLabel.Location = new System.Drawing.Point(14, 16);
            this.ToolsNameLabel.Name = "ToolsNameLabel";
            this.ToolsNameLabel.Size = new System.Drawing.Size(124, 16);
            this.ToolsNameLabel.TabIndex = 0;
            this.ToolsNameLabel.Text = "Тип инструмента:";
            // 
            // ToolsNameTextBox
            // 
            this.ToolsNameTextBox.Location = new System.Drawing.Point(17, 35);
            this.ToolsNameTextBox.Name = "ToolsNameTextBox";
            this.ToolsNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.ToolsNameTextBox.TabIndex = 1;
            // 
            // ToolsButton
            // 
            this.ToolsButton.Location = new System.Drawing.Point(17, 66);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(294, 25);
            this.ToolsButton.TabIndex = 2;
            this.ToolsButton.Text = "Добавить";
            this.ToolsButton.UseVisualStyleBackColor = true;
            // 
            // AddToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 108);
            this.Controls.Add(this.ToolsButton);
            this.Controls.Add(this.ToolsNameTextBox);
            this.Controls.Add(this.ToolsNameLabel);
            this.Name = "AddToolsForm";
            this.Text = "Добавление инструмента";
            this.Load += new System.EventHandler(this.AddToolsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
