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
            this.operatinosCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(14, 16);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(141, 16);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Название продукта:";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(17, 35);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.ProductNameTextBox.TabIndex = 1;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // ProductCostLabel
            // 
            this.ProductCostLabel.AutoSize = true;
            this.ProductCostLabel.Location = new System.Drawing.Point(14, 69);
            this.ProductCostLabel.Name = "ProductCostLabel";
            this.ProductCostLabel.Size = new System.Drawing.Size(108, 16);
            this.ProductCostLabel.TabIndex = 2;
            this.ProductCostLabel.Text = "Цена продукта:";
            // 
            // ProductCostTextBox
            // 
            this.ProductCostTextBox.Location = new System.Drawing.Point(17, 89);
            this.ProductCostTextBox.Name = "ProductCostTextBox";
            this.ProductCostTextBox.Size = new System.Drawing.Size(293, 22);
            this.ProductCostTextBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            //this.ConfirmButton.Location = new System.Drawing.Point(17, 128);
            this.ConfirmButton.Location = new System.Drawing.Point(17, 326);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(294, 25);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Добавить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // operatinosCheckedListBox
            // 
            this.operatinosCheckedListBox.FormattingEnabled = true;
            this.operatinosCheckedListBox.Location = new System.Drawing.Point(17, 117);
            this.operatinosCheckedListBox.Name = "operatinosCheckedListBox";
            this.operatinosCheckedListBox.Size = new System.Drawing.Size(293, 191);
            this.operatinosCheckedListBox.TabIndex = 5;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 172);
            this.ClientSize = new System.Drawing.Size(325, 363);
            this.Controls.Add(this.operatinosCheckedListBox);
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

        private System.Windows.Forms.CheckedListBox operatinosCheckedListBox;
    }
}
