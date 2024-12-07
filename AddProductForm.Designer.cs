﻿namespace Production
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
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
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(15, 62);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(257, 23);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Добавить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "AddProductForm";
            this.Text = "Добавление продукта";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
