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
            this.addToolTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addToolTypeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.confirmAddToolTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addToolTypeNameTextBox
            // 
            this.addToolTypeNameTextBox.Location = new System.Drawing.Point(32, 38);
            this.addToolTypeNameTextBox.Name = "addToolTypeNameTextBox";
            this.addToolTypeNameTextBox.Size = new System.Drawing.Size(266, 22);
            this.addToolTypeNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название типа инструмента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание типа инструмента:";
            // 
            // addToolTypeDescriptionTextBox
            // 
            this.addToolTypeDescriptionTextBox.Location = new System.Drawing.Point(32, 102);
            this.addToolTypeDescriptionTextBox.Name = "addToolTypeDescriptionTextBox";
            this.addToolTypeDescriptionTextBox.Size = new System.Drawing.Size(266, 22);
            this.addToolTypeDescriptionTextBox.TabIndex = 2;
            // 
            // confirmAddToolTypeButton
            // 
            this.confirmAddToolTypeButton.Location = new System.Drawing.Point(32, 152);
            this.confirmAddToolTypeButton.Name = "confirmAddToolTypeButton";
            this.confirmAddToolTypeButton.Size = new System.Drawing.Size(266, 41);
            this.confirmAddToolTypeButton.TabIndex = 4;
            this.confirmAddToolTypeButton.Text = "Добавить тип инструмента";
            this.confirmAddToolTypeButton.UseVisualStyleBackColor = true;
            // 
            // AddToolType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 227);
            this.Controls.Add(this.confirmAddToolTypeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addToolTypeDescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToolTypeNameTextBox);
            this.Name = "AddToolType";
            this.Text = "Добавление типа инструмента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addToolTypeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addToolTypeDescriptionTextBox;
        private System.Windows.Forms.Button confirmAddToolTypeButton;
    }
}