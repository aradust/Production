namespace Production
{
    partial class AddWorkShopForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            WSbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите Название Цеха";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 101);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 1;
            // 
            // WSbutton
            // 
            WSbutton.Location = new Point(19, 168);
            WSbutton.Margin = new Padding(3, 4, 3, 4);
            WSbutton.Name = "WSbutton";
            WSbutton.Size = new Size(163, 29);
            WSbutton.TabIndex = 2;
            WSbutton.Text = "Добавить";
            WSbutton.UseVisualStyleBackColor = true;
            // 
            // AddWorkShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 216);
            Controls.Add(WSbutton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddWorkShopForm";
            Text = "AddWorkShopForm";
            Load += AddWorkShopForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button WSbutton;
    }
}
