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
            OperationNameLabel = new Label();
            OperationNameTextBox = new TextBox();
            ConfirmButtonOperation = new Button();
            ToolsCheckedListBox = new CheckedListBox();
            label1 = new Label();
            Operationlabel2 = new Label();
            OperationtextBox2 = new TextBox();
            label2 = new Label();
            durationMaskedTextBox = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // OperationNameLabel
            // 
            OperationNameLabel.AutoSize = true;
            OperationNameLabel.Location = new Point(14, 20);
            OperationNameLabel.Name = "OperationNameLabel";
            OperationNameLabel.Size = new Size(154, 20);
            OperationNameLabel.TabIndex = 0;
            OperationNameLabel.Text = "Название операции:";
            // 
            // OperationNameTextBox
            // 
            OperationNameTextBox.Location = new Point(17, 58);
            OperationNameTextBox.Margin = new Padding(3, 4, 3, 4);
            OperationNameTextBox.Name = "OperationNameTextBox";
            OperationNameTextBox.Size = new Size(293, 27);
            OperationNameTextBox.TabIndex = 1;
            // 
            // ConfirmButtonOperation
            // 
            ConfirmButtonOperation.Location = new Point(17, 593);
            ConfirmButtonOperation.Margin = new Padding(3, 4, 3, 4);
            ConfirmButtonOperation.Name = "ConfirmButtonOperation";
            ConfirmButtonOperation.Size = new Size(294, 31);
            ConfirmButtonOperation.TabIndex = 2;
            ConfirmButtonOperation.Text = "Добавить";
            ConfirmButtonOperation.UseVisualStyleBackColor = true;
            // 
            // ToolsCheckedListBox
            // 
            ToolsCheckedListBox.Location = new Point(17, 307);
            ToolsCheckedListBox.Margin = new Padding(3, 4, 3, 4);
            ToolsCheckedListBox.Name = "ToolsCheckedListBox";
            ToolsCheckedListBox.Size = new Size(273, 268);
            ToolsCheckedListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // Operationlabel2
            // 
            Operationlabel2.AutoSize = true;
            Operationlabel2.Location = new Point(14, 103);
            Operationlabel2.Name = "Operationlabel2";
            Operationlabel2.Size = new Size(153, 20);
            Operationlabel2.TabIndex = 4;
            Operationlabel2.Text = "Описание операции";
            // 
            // OperationtextBox2
            // 
            OperationtextBox2.Location = new Point(17, 141);
            OperationtextBox2.Margin = new Padding(3, 4, 3, 4);
            OperationtextBox2.Name = "OperationtextBox2";
            OperationtextBox2.Size = new Size(293, 27);
            OperationtextBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 186);
            label2.Name = "label2";
            label2.Size = new Size(284, 20);
            label2.TabIndex = 6;
            label2.Text = "Продолжительность операции (чч:мм):";
            // 
            // durationMaskedTextBox
            // 
            durationMaskedTextBox.Location = new Point(17, 224);
            durationMaskedTextBox.Mask = "00:00";
            durationMaskedTextBox.Name = "durationMaskedTextBox";
            durationMaskedTextBox.Size = new Size(293, 27);
            durationMaskedTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 269);
            label3.Name = "label3";
            label3.Size = new Size(212, 20);
            label3.TabIndex = 9;
            label3.Text = "Используемые инструменты:";
            // 
            // AddOperationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 634);
            Controls.Add(label3);
            Controls.Add(durationMaskedTextBox);
            Controls.Add(label2);
            Controls.Add(OperationtextBox2);
            Controls.Add(Operationlabel2);
            Controls.Add(label1);
            Controls.Add(ToolsCheckedListBox);
            Controls.Add(ConfirmButtonOperation);
            Controls.Add(OperationNameTextBox);
            Controls.Add(OperationNameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddOperationForm";
            Text = "Добавление операции";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox ToolsCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Operationlabel2;
        private System.Windows.Forms.TextBox OperationtextBox2;
        private System.Windows.Forms.Label label2;
        private MaskedTextBox durationMaskedTextBox;
        private Label label3;
    }
}
