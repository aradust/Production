namespace Production
{
    partial class AddToolsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label ToolsNameLabel;
        private System.Windows.Forms.TextBox ToolsNameTextBox;
        private System.Windows.Forms.Button ConfirmButton2;

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
            this.ConfirmButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToolsNameLabel
            // 
            this.ToolsNameLabel.AutoSize = true;
            this.ToolsNameLabel.Location = new System.Drawing.Point(12, 15);
            this.ToolsNameLabel.Name = "ToolsNameLabel";
            this.ToolsNameLabel.Size = new System.Drawing.Size(89, 15);
            this.ToolsNameLabel.TabIndex = 0;
            this.ToolsNameLabel.Text = "Тип инструмента:";
            // 
            // ToolsNameTextBox
            // 
            this.ToolsNameTextBox.Location = new System.Drawing.Point(15, 33);
            this.ToolsNameTextBox.Name = "ToolsNameTextBox";
            this.ToolsNameTextBox.Size = new System.Drawing.Size(257, 23);
            this.ToolsNameTextBox.TabIndex = 1;
            // 
            // ConfirmButton2
            // 
            this.ConfirmButton2.Location = new System.Drawing.Point(15, 62);
            this.ConfirmButton2.Name = "ConfirmButton2";
            this.ConfirmButton2.Size = new System.Drawing.Size(257, 23);
            this.ConfirmButton2.TabIndex = 2;
            this.ConfirmButton2.Text = "Добавить";
            this.ConfirmButton2.UseVisualStyleBackColor = true;
            // 
            // AddToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.ConfirmButton2);
            this.Controls.Add(this.ToolsNameTextBox);
            this.Controls.Add(this.ToolsNameLabel);
            this.Name = "AddToolsForm";
            this.Text = "Добавление инструмента";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
