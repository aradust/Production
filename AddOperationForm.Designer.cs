namespace Production
{
    partial class AddOperationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label OperationNameLabel;
        private System.Windows.Forms.TextBox OperationNameTextBox;
        private System.Windows.Forms.Button ConfirmButtonOperation;

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
            this.ConfirmButtonOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OperationNameLabel
            // 
            this.OperationNameLabel.AutoSize = true;
            this.OperationNameLabel.Location = new System.Drawing.Point(14, 16);
            this.OperationNameLabel.Name = "OperationNameLabel";
            this.OperationNameLabel.Size = new System.Drawing.Size(143, 16);
            this.OperationNameLabel.TabIndex = 0;
            this.OperationNameLabel.Text = "Название операции:";
            this.OperationNameLabel.Click += new System.EventHandler(this.OperationNameLabel_Click);
            // 
            // OperationNameTextBox
            // 
            this.OperationNameTextBox.Location = new System.Drawing.Point(17, 35);
            this.OperationNameTextBox.Name = "OperationNameTextBox";
            this.OperationNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.OperationNameTextBox.TabIndex = 1;
            // 
            // ConfirmButtonOperation
            // 
            this.ConfirmButtonOperation.Location = new System.Drawing.Point(17, 66);
            this.ConfirmButtonOperation.Name = "ConfirmButtonOperation";
            this.ConfirmButtonOperation.Size = new System.Drawing.Size(294, 25);
            this.ConfirmButtonOperation.TabIndex = 2;
            this.ConfirmButtonOperation.Text = "Добавить";
            this.ConfirmButtonOperation.UseVisualStyleBackColor = true;
            // 
            // AddOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 108);
            this.Controls.Add(this.ConfirmButtonOperation);
            this.Controls.Add(this.OperationNameTextBox);
            this.Controls.Add(this.OperationNameLabel);
            this.Name = "AddOperationForm";
            this.Text = "Добавление операции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
