namespace Production
{
    partial class AddMaterialForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Button buttonMaterial;

        /// <summary>
        /// Очистка используемых ресурсов.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализация компонентов формы.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMaterial = new System.Windows.Forms.Label();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.buttonMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(12, 15);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(113, 15);
            this.labelMaterial.TabIndex = 0;
            this.labelMaterial.Text = "Название материала:";
            this.labelMaterial.Click += new System.EventHandler(this.labelMaterial_Click);
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(15, 33);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(257, 23);
            this.textBoxMaterial.TabIndex = 1;
            // 
            // buttonMaterial
            // 
            this.buttonMaterial.Location = new System.Drawing.Point(15, 62);
            this.buttonMaterial.Name = "buttonMaterial";
            this.buttonMaterial.Size = new System.Drawing.Size(257, 23);
            this.buttonMaterial.TabIndex = 2;
            this.buttonMaterial.Text = "Добавить материал";
            this.buttonMaterial.UseVisualStyleBackColor = true;
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.buttonMaterial);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Name = "AddMaterialForm";
            this.Text = "Добавить материал";
            this.Load += new System.EventHandler(this.AddMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
