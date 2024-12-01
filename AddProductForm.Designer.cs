namespace Production
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmAddProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(139, 12);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.ProductNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // AddProductErrorProvider
            // 
            this.AddProductErrorProvider.ContainerControl = this;
            // 
            // ConfirmAddProductButton
            // 
            this.ConfirmAddProductButton.Location = new System.Drawing.Point(15, 56);
            this.ConfirmAddProductButton.Name = "ConfirmAddProductButton";
            this.ConfirmAddProductButton.Size = new System.Drawing.Size(259, 61);
            this.ConfirmAddProductButton.TabIndex = 2;
            this.ConfirmAddProductButton.Text = "Добавить продукт";
            this.ConfirmAddProductButton.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 129);
            this.Controls.Add(this.ConfirmAddProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductNameTextBox);
            this.Name = "AddProductForm";
            this.Text = "Добавление продукта";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddProductErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider AddProductErrorProvider;
        private System.Windows.Forms.Button ConfirmAddProductButton;
    }
}