namespace Production
{
    partial class AddOperationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label OperationNameLabel;
        private System.Windows.Forms.TextBox OperationNameTextBox;
        private System.Windows.Forms.Button ConfirmButton;

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
            this.OperationNameLabel = new System.Windows.Forms.Label();
            this.OperationNameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OperationNameLabel
            // 
            this.OperationNameLabel.AutoSize = true;
            this.OperationNameLabel.Location = new System.Drawing.Point(12, 15);
            this.OperationNameLabel.Name = "OperationNameLabel";
            this.OperationNameLabel.Size = new System.Drawing.Size(118, 15);
            this.OperationNameLabel.TabIndex = 0;
            this.OperationNameLabel.Text = "Название операции:";
            // 
            // OperationNameTextBox
            // 
            this.OperationNameTextBox.Location = new System.Drawing.Point(15, 33);
            this.OperationNameTextBox.Name = "OperationNameTextBox";
            this.OperationNameTextBox.Size = new System.Drawing.Size(257, 23);
            this.OperationNameTextBox.TabIndex = 1;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(15, 62);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(257, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Добавить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // AddOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.OperationNameTextBox);
            this.Controls.Add(this.OperationNameLabel);
            this.Name = "AddOperationForm";
            this.Text = "Добавление операции";
            this.Load += new System.EventHandler(this.AddOperationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
