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
            ProductNameLabel = new Label();
            ProductNameTextBox = new TextBox();
            ProductCostLabel = new Label();
            ProductCostTextBox = new TextBox();
            ConfirmButton = new Button();
            DrawingsCheckedListBox = new CheckedListBox();
            SuspendLayout();
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(14, 20);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(147, 20);
            ProductNameLabel.TabIndex = 0;
            ProductNameLabel.Text = "Название продукта:";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(17, 44);
            ProductNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(293, 27);
            ProductNameTextBox.TabIndex = 1;
            // 
            // ProductCostLabel
            // 
            ProductCostLabel.AutoSize = true;
            ProductCostLabel.Location = new Point(14, 86);
            ProductCostLabel.Name = "ProductCostLabel";
            ProductCostLabel.Size = new Size(115, 20);
            ProductCostLabel.TabIndex = 2;
            ProductCostLabel.Text = "Цена продукта:";
            // 
            // ProductCostTextBox
            // 
            ProductCostTextBox.Location = new Point(17, 111);
            ProductCostTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductCostTextBox.Name = "ProductCostTextBox";
            ProductCostTextBox.Size = new Size(293, 27);
            ProductCostTextBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(17, 408);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(294, 31);
            ConfirmButton.TabIndex = 4;
            ConfirmButton.Text = "Добавить";
            ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // DrawingsCheckedListBox
            // 
            DrawingsCheckedListBox.FormattingEnabled = true;
            DrawingsCheckedListBox.Location = new Point(17, 146);
            DrawingsCheckedListBox.Margin = new Padding(3, 4, 3, 4);
            DrawingsCheckedListBox.Name = "DrawingsCheckedListBox";
            DrawingsCheckedListBox.Size = new Size(293, 224);
            DrawingsCheckedListBox.TabIndex = 5;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 454);
            Controls.Add(DrawingsCheckedListBox);
            Controls.Add(ConfirmButton);
            Controls.Add(ProductCostTextBox);
            Controls.Add(ProductCostLabel);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddProductForm";
            Text = "Добавление продукта";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox DrawingsCheckedListBox;
    }
}
