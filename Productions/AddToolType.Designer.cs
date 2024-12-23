namespace Production
{
    partial class AddToolType
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
            addToolTypeNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addToolTypeDescriptionTextBox = new TextBox();
            confirmAddToolTypeButton = new Button();
            SuspendLayout();
            // 
            // addToolTypeNameTextBox
            // 
            addToolTypeNameTextBox.Location = new Point(32, 48);
            addToolTypeNameTextBox.Margin = new Padding(3, 4, 3, 4);
            addToolTypeNameTextBox.Name = "addToolTypeNameTextBox";
            addToolTypeNameTextBox.Size = new Size(266, 27);
            addToolTypeNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 11);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 1;
            label1.Text = "Название типа инструмента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 91);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 3;
            label2.Text = "Описание типа инструмента:";
            // 
            // addToolTypeDescriptionTextBox
            // 
            addToolTypeDescriptionTextBox.Location = new Point(32, 128);
            addToolTypeDescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            addToolTypeDescriptionTextBox.Name = "addToolTypeDescriptionTextBox";
            addToolTypeDescriptionTextBox.Size = new Size(266, 27);
            addToolTypeDescriptionTextBox.TabIndex = 2;
            // 
            // confirmAddToolTypeButton
            // 
            confirmAddToolTypeButton.Location = new Point(32, 190);
            confirmAddToolTypeButton.Margin = new Padding(3, 4, 3, 4);
            confirmAddToolTypeButton.Name = "confirmAddToolTypeButton";
            confirmAddToolTypeButton.Size = new Size(266, 51);
            confirmAddToolTypeButton.TabIndex = 4;
            confirmAddToolTypeButton.Text = "Добавить тип инструмента";
            confirmAddToolTypeButton.UseVisualStyleBackColor = true;
            // 
            // AddToolType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 284);
            Controls.Add(confirmAddToolTypeButton);
            Controls.Add(label2);
            Controls.Add(addToolTypeDescriptionTextBox);
            Controls.Add(label1);
            Controls.Add(addToolTypeNameTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddToolType";
            Text = "Добавление типа инструмента";
            Load += AddToolType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox addToolTypeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addToolTypeDescriptionTextBox;
        private System.Windows.Forms.Button confirmAddToolTypeButton;
    }
}