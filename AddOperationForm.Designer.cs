namespace Production
{
    partial class AddOperationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label OperationNameLabel;
        private System.Windows.Forms.TextBox OperationNameTextBox;
        private System.Windows.Forms.Button ConfirmButtonOperation;

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
            this.OperationNameLabel = new System.Windows.Forms.Label();
            this.OperationNameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButtonOperation = new System.Windows.Forms.Button();
            this.DrawingsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Operationlabel2 = new System.Windows.Forms.Label();
            this.OperationtextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OperationtextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OperationNameLabel
            // 
            this.OperationNameLabel.AutoSize = true;
            this.OperationNameLabel.Location = new System.Drawing.Point(14, 16);
            this.OperationNameLabel.Name = "OperationNameLabel";
            this.OperationNameLabel.Size = new System.Drawing.Size(143, 16);
            this.OperationNameLabel.TabIndex = 0;
            this.OperationNameLabel.Text = "Название операции:";
            this.OperationNameLabel.Click += new System.EventHandler(this.OperationNameLabel_Click);
            // 
            // OperationNameTextBox
            // 
            this.OperationNameTextBox.Location = new System.Drawing.Point(17, 35);
            this.OperationNameTextBox.Name = "OperationNameTextBox";
            this.OperationNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.OperationNameTextBox.TabIndex = 1;
            // 
            // ConfirmButtonOperation
            // 
            this.ConfirmButtonOperation.Location = new System.Drawing.Point(17, 260);
            this.ConfirmButtonOperation.Name = "ConfirmButtonOperation";
            this.ConfirmButtonOperation.Size = new System.Drawing.Size(294, 25);
            this.ConfirmButtonOperation.TabIndex = 2;
            this.ConfirmButtonOperation.Text = "Добавить";
            this.ConfirmButtonOperation.UseVisualStyleBackColor = true;
            // 
            // DrawingsCheckedListBox
            // 
            this.DrawingsCheckedListBox.Location = new System.Drawing.Point(12, 304);
            this.DrawingsCheckedListBox.Name = "DrawingsCheckedListBox";
            this.DrawingsCheckedListBox.Size = new System.Drawing.Size(273, 225);
            this.DrawingsCheckedListBox.TabIndex = 0;
            this.DrawingsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DrawingsCheckedListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // Operationlabel2
            // 
            this.Operationlabel2.AutoSize = true;
            this.Operationlabel2.Location = new System.Drawing.Point(14, 76);
            this.Operationlabel2.Name = "Operationlabel2";
            this.Operationlabel2.Size = new System.Drawing.Size(139, 16);
            this.Operationlabel2.TabIndex = 4;
            this.Operationlabel2.Text = "Описание операции";
            // 
            // OperationtextBox2
            // 
            this.OperationtextBox2.Location = new System.Drawing.Point(17, 116);
            this.OperationtextBox2.Name = "OperationtextBox2";
            this.OperationtextBox2.Size = new System.Drawing.Size(293, 22);
            this.OperationtextBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Продолжительность операции";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OperationtextBox3
            // 
            this.OperationtextBox3.Location = new System.Drawing.Point(17, 207);
            this.OperationtextBox3.Name = "OperationtextBox3";
            this.OperationtextBox3.Size = new System.Drawing.Size(293, 22);
            this.OperationtextBox3.TabIndex = 7;
            this.OperationtextBox3.TextChanged += new System.EventHandler(this.OperatopntextBox3_TextChanged);
            // 
            // AddOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 553);
            this.Controls.Add(this.OperationtextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OperationtextBox2);
            this.Controls.Add(this.Operationlabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawingsCheckedListBox);
            this.Controls.Add(this.ConfirmButtonOperation);
            this.Controls.Add(this.OperationNameTextBox);
            this.Controls.Add(this.OperationNameLabel);
            this.Name = "AddOperationForm";
            this.Text = "Добавление операции";
            this.Load += new System.EventHandler(this.AddOperationForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckedListBox DrawingsCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Operationlabel2;
        private System.Windows.Forms.TextBox OperationtextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OperationtextBox3;
    }
}
