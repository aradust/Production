namespace Production
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProductCostLabel;
        private System.Windows.Forms.TextBox ProductCostTextBox;
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductCostLabel = new System.Windows.Forms.Label();
            this.ProductCostTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 15);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(118, 15);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Название продукта:";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(15, 33);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(257, 23);
            this.ProductNameTextBox.TabIndex = 1;
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.AutoSize = true;
            this.ProductCostLabel.Location = new System.Drawing.Point(12, 65);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(99, 15);
            this.ProductCostLabel.TabIndex = 2;
            this.ProductCostLabel.Text = "Цена продукта:";
            // 
            // ProductCostTextBox
            // 
            this.ProductCostTextBox.Location = new System.Drawing.Point(15, 83);
            this.ProductCostTextBox.Name = "ProductCostTextBox";
            this.ProductCostTextBox.Size = new System.Drawing.Size(257, 23);
            this.ProductCostTextBox.TabIndex = 3;
            
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(15, 120);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(257, 23);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Добавить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ProductCostTextBox);
            this.Controls.Add(this.ProductCostLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "AddProductForm";
            this.Text = "Добавление продукта";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
