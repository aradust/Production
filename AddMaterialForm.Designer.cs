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
            this.Materiallabel2 = new System.Windows.Forms.Label();
            this.MaterialtextBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(14, 16);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(151, 16);
            this.labelMaterial.TabIndex = 0;
            this.labelMaterial.Text = "Название материала:";
            this.labelMaterial.Click += new System.EventHandler(this.labelMaterial_Click);
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(17, 35);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(293, 22);
            this.textBoxMaterial.TabIndex = 1;
            // 
            // buttonMaterial
            // 
            this.buttonMaterial.Location = new System.Drawing.Point(12, 218);
            this.buttonMaterial.Name = "buttonMaterial";
            this.buttonMaterial.Size = new System.Drawing.Size(294, 25);
            this.buttonMaterial.TabIndex = 2;
            this.buttonMaterial.Text = "Добавить материал";
            this.buttonMaterial.UseVisualStyleBackColor = true;
            // 
            // Materiallabel2
            // 
            this.Materiallabel2.AutoSize = true;
            this.Materiallabel2.Location = new System.Drawing.Point(15, 66);
            this.Materiallabel2.Name = "Materiallabel2";
            this.Materiallabel2.Size = new System.Drawing.Size(150, 16);
            this.Materiallabel2.TabIndex = 3;
            this.Materiallabel2.Text = "Описание материала:";
            this.Materiallabel2.Click += new System.EventHandler(this.Materiallabel2_Click);
            // 
            // MaterialtextBox2
            // 
            this.MaterialtextBox2.Location = new System.Drawing.Point(18, 99);
            this.MaterialtextBox2.Name = "MaterialtextBox2";
            this.MaterialtextBox2.Size = new System.Drawing.Size(292, 22);
            this.MaterialtextBox2.TabIndex = 4;
            this.MaterialtextBox2.TextChanged += new System.EventHandler(this.MaterialtextBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Расходуемый";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 275);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.MaterialtextBox2);
            this.Controls.Add(this.Materiallabel2);
            this.Controls.Add(this.buttonMaterial);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Name = "AddMaterialForm";
            this.Text = "Добавить материал";
            this.Load += new System.EventHandler(this.AddMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Materiallabel2;
        private System.Windows.Forms.TextBox MaterialtextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
