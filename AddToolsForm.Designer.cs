namespace Production
{
    partial class AddToolsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label ToolsNameLabel;
        private System.Windows.Forms.TextBox ToolsNameTextBox;
        private System.Windows.Forms.Button ToolsButton;

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
            this.ToolsButton = new System.Windows.Forms.Button();
            this.Toolslabel2 = new System.Windows.Forms.Label();
            this.ToolstextBox1 = new System.Windows.Forms.TextBox();
            this.Toolslabel3 = new System.Windows.Forms.Label();
            this.ToolstextBox3 = new System.Windows.Forms.TextBox();
            this.Toolslabel4 = new System.Windows.Forms.Label();
            this.ToolstextBox4 = new System.Windows.Forms.TextBox();
            this.Toolslabel5 = new System.Windows.Forms.Label();
            this.ToolstextBox5 = new System.Windows.Forms.TextBox();
            this.Toolslabel6 = new System.Windows.Forms.Label();
            this.ToolstextBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToolsNameLabel
            // 
            this.ToolsNameLabel.AutoSize = true;
            this.ToolsNameLabel.Location = new System.Drawing.Point(14, 9);
            this.ToolsNameLabel.Name = "ToolsNameLabel";
            this.ToolsNameLabel.Size = new System.Drawing.Size(124, 16);
            this.ToolsNameLabel.TabIndex = 0;
            this.ToolsNameLabel.Text = "Тип инструмента:";
            this.ToolsNameLabel.Click += new System.EventHandler(this.ToolsNameLabel_Click_1);
            // 
            // ToolsNameTextBox
            // 
            this.ToolsNameTextBox.Location = new System.Drawing.Point(17, 35);
            this.ToolsNameTextBox.Name = "ToolsNameTextBox";
            this.ToolsNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.ToolsNameTextBox.TabIndex = 1;
            
            // 
            // ToolsButton
            // 
            this.ToolsButton.Location = new System.Drawing.Point(10, 520);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(294, 25);
            this.ToolsButton.TabIndex = 2;
            this.ToolsButton.Text = "Добавить";
            this.ToolsButton.UseVisualStyleBackColor = true;
            
            // 
            // Toolslabel2
            // 
            this.Toolslabel2.AutoSize = true;
            this.Toolslabel2.Location = new System.Drawing.Point(17, 151);
            this.Toolslabel2.Name = "Toolslabel2";
            this.Toolslabel2.Size = new System.Drawing.Size(97, 16);
            this.Toolslabel2.TabIndex = 3;
            this.Toolslabel2.Text = "Введите дату";
            this.Toolslabel2.Click += new System.EventHandler(this.Toolslabel2_Click);
            // 
            // ToolstextBox1
            // 
            this.ToolstextBox1.Location = new System.Drawing.Point(11, 198);
            this.ToolstextBox1.Name = "ToolstextBox1";
            this.ToolstextBox1.Size = new System.Drawing.Size(293, 22);
            this.ToolstextBox1.TabIndex = 4;
            this.ToolstextBox1.TextChanged += new System.EventHandler(this.ToolstextBox1_TextChanged);
            // 
            // Toolslabel3
            // 
            this.Toolslabel3.AutoSize = true;
            this.Toolslabel3.Location = new System.Drawing.Point(17, 234);
            this.Toolslabel3.Name = "Toolslabel3";
            this.Toolslabel3.Size = new System.Drawing.Size(164, 16);
            this.Toolslabel3.TabIndex = 5;
            this.Toolslabel3.Text = "Описание инструмента:";
            this.Toolslabel3.Click += new System.EventHandler(this.Toolslabel3_Click);
            // 
            // ToolstextBox3
            // 
            this.ToolstextBox3.Location = new System.Drawing.Point(15, 285);
            this.ToolstextBox3.Name = "ToolstextBox3";
            this.ToolstextBox3.Size = new System.Drawing.Size(293, 22);
            this.ToolstextBox3.TabIndex = 6;
            this.ToolstextBox3.TextChanged += new System.EventHandler(this.ToolstextBox3_TextChanged);
            // 
            // Toolslabel4
            // 
            this.Toolslabel4.AutoSize = true;
            this.Toolslabel4.Location = new System.Drawing.Point(14, 341);
            this.Toolslabel4.Name = "Toolslabel4";
            this.Toolslabel4.Size = new System.Drawing.Size(172, 16);
            this.Toolslabel4.TabIndex = 7;
            this.Toolslabel4.Text = "Выделенное количество:";
            this.Toolslabel4.Click += new System.EventHandler(this.Toolslabel4_Click);
            // 
            // ToolstextBox4
            // 
            this.ToolstextBox4.Location = new System.Drawing.Point(11, 380);
            this.ToolstextBox4.Name = "ToolstextBox4";
            this.ToolstextBox4.Size = new System.Drawing.Size(293, 22);
            this.ToolstextBox4.TabIndex = 8;
            this.ToolstextBox4.TextChanged += new System.EventHandler(this.ToolstextBox4_TextChanged);
            // 
            // Toolslabel5
            // 
            this.Toolslabel5.AutoSize = true;
            this.Toolslabel5.Location = new System.Drawing.Point(17, 76);
            this.Toolslabel5.Name = "Toolslabel5";
            this.Toolslabel5.Size = new System.Drawing.Size(169, 16);
            this.Toolslabel5.TabIndex = 9;
            this.Toolslabel5.Text = "Оставшееся количество:";
            this.Toolslabel5.Click += new System.EventHandler(this.Toolslabel5_Click);
            // 
            // ToolstextBox5
            // 
            this.ToolstextBox5.Location = new System.Drawing.Point(12, 110);
            this.ToolstextBox5.Name = "ToolstextBox5";
            this.ToolstextBox5.Size = new System.Drawing.Size(293, 22);
            this.ToolstextBox5.TabIndex = 10;
            this.ToolstextBox5.TextChanged += new System.EventHandler(this.ToolstextBox5_TextChanged);
            // 
            // Toolslabel6
            // 
            this.Toolslabel6.AutoSize = true;
            this.Toolslabel6.Location = new System.Drawing.Point(17, 435);
            this.Toolslabel6.Name = "Toolslabel6";
            this.Toolslabel6.Size = new System.Drawing.Size(153, 16);
            this.Toolslabel6.TabIndex = 11;
            this.Toolslabel6.Text = "Номера Экземпляров:";
            this.Toolslabel6.Click += new System.EventHandler(this.Toolslabel6_Click);
            // 
            // ToolstextBox6
            // 
            this.ToolstextBox6.Location = new System.Drawing.Point(12, 480);
            this.ToolstextBox6.Name = "ToolstextBox6";
            this.ToolstextBox6.Size = new System.Drawing.Size(293, 22);
            this.ToolstextBox6.TabIndex = 12;
            this.ToolstextBox6.TextChanged += new System.EventHandler(this.ToolstextBox6_TextChanged);
            // 
            // AddToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 566);
            this.Controls.Add(this.ToolstextBox6);
            this.Controls.Add(this.Toolslabel6);
            this.Controls.Add(this.ToolstextBox5);
            this.Controls.Add(this.Toolslabel5);
            this.Controls.Add(this.ToolstextBox4);
            this.Controls.Add(this.Toolslabel4);
            this.Controls.Add(this.ToolstextBox3);
            this.Controls.Add(this.Toolslabel3);
            this.Controls.Add(this.ToolstextBox1);
            this.Controls.Add(this.Toolslabel2);
            this.Controls.Add(this.ToolsButton);
            this.Controls.Add(this.ToolsNameTextBox);
            this.Controls.Add(this.ToolsNameLabel);
            this.Name = "AddToolsForm";
            this.Text = "Добавление инструмента";
            this.Load += new System.EventHandler(this.AddToolsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Toolslabel2;
        private System.Windows.Forms.TextBox ToolstextBox1;
        private System.Windows.Forms.Label Toolslabel3;
        private System.Windows.Forms.TextBox ToolstextBox3;
        private System.Windows.Forms.Label Toolslabel4;
        private System.Windows.Forms.TextBox ToolstextBox4;
        private System.Windows.Forms.Label Toolslabel5;
        private System.Windows.Forms.TextBox ToolstextBox5;
        private System.Windows.Forms.Label Toolslabel6;
        private System.Windows.Forms.TextBox ToolstextBox6;
    }
}
