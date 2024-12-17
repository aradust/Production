namespace Production
{
    partial class AddToolsForm
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
            ToolsNameTextBox = new TextBox();
            ToolsNameLabel = new Label();
            ToolstextBox3 = new TextBox();
            Toolslabel3 = new Label();
            ToolstextBox1 = new TextBox();
            Toolslabel2 = new Label();
            ToolsButton = new Button();
            SuspendLayout();
            // 
            // ToolsNameTextBox
            // 
            ToolsNameTextBox.Location = new Point(29, 70);
            ToolsNameTextBox.Margin = new Padding(4, 5, 4, 5);
            ToolsNameTextBox.Name = "ToolsNameTextBox";
            ToolsNameTextBox.Size = new Size(265, 27);
            ToolsNameTextBox.TabIndex = 0;
            // 
            // ToolsNameLabel
            // 
            ToolsNameLabel.AutoSize = true;
            ToolsNameLabel.Location = new Point(27, 35);
            ToolsNameLabel.Margin = new Padding(4, 0, 4, 0);
            ToolsNameLabel.Name = "ToolsNameLabel";
            ToolsNameLabel.Size = new Size(173, 20);
            ToolsNameLabel.TabIndex = 1;
            ToolsNameLabel.Text = "Название инструмента:";
            // 
            // ToolstextBox3
            // 
            ToolstextBox3.Location = new Point(29, 147);
            ToolstextBox3.Margin = new Padding(4, 5, 4, 5);
            ToolstextBox3.Name = "ToolstextBox3";
            ToolstextBox3.Size = new Size(265, 27);
            ToolstextBox3.TabIndex = 2;
            // 
            // Toolslabel3
            // 
            Toolslabel3.AutoSize = true;
            Toolslabel3.Location = new Point(27, 112);
            Toolslabel3.Margin = new Padding(4, 0, 4, 0);
            Toolslabel3.Name = "Toolslabel3";
            Toolslabel3.Size = new Size(82, 20);
            Toolslabel3.TabIndex = 3;
            Toolslabel3.Text = "Описание:";
            // 
            // ToolstextBox1
            // 
            ToolstextBox1.Location = new Point(29, 224);
            ToolstextBox1.Margin = new Padding(4, 5, 4, 5);
            ToolstextBox1.Name = "ToolstextBox1";
            ToolstextBox1.Size = new Size(265, 27);
            ToolstextBox1.TabIndex = 4;
            // 
            // Toolslabel2
            // 
            Toolslabel2.AutoSize = true;
            Toolslabel2.Location = new Point(27, 189);
            Toolslabel2.Margin = new Padding(4, 0, 4, 0);
            Toolslabel2.Name = "Toolslabel2";
            Toolslabel2.Size = new Size(44, 20);
            Toolslabel2.TabIndex = 5;
            Toolslabel2.Text = "Дата:";
            // 
            // ToolsButton
            // 
            ToolsButton.Location = new Point(27, 266);
            ToolsButton.Margin = new Padding(4, 5, 4, 5);
            ToolsButton.Name = "ToolsButton";
            ToolsButton.Size = new Size(267, 46);
            ToolsButton.TabIndex = 12;
            ToolsButton.Text = "Добавить инструмент";
            ToolsButton.UseVisualStyleBackColor = true;
            ToolsButton.Click += ToolsButton_Click;
            // 
            // AddToolsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 334);
            Controls.Add(ToolsButton);
            Controls.Add(Toolslabel2);
            Controls.Add(ToolstextBox1);
            Controls.Add(Toolslabel3);
            Controls.Add(ToolstextBox3);
            Controls.Add(ToolsNameLabel);
            Controls.Add(ToolsNameTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddToolsForm";
            Text = "Добавление инструмента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox ToolsNameTextBox;
        private System.Windows.Forms.Label ToolsNameLabel;
        private System.Windows.Forms.TextBox ToolstextBox3;
        private System.Windows.Forms.Label Toolslabel3;
        private System.Windows.Forms.TextBox ToolstextBox1;
        private System.Windows.Forms.Label Toolslabel2;
        private System.Windows.Forms.Button ToolsButton;
    }
}
