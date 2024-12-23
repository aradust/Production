namespace Production
{
    partial class AddWorkOrderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора - не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1WorkShop = new Label();
            textBox1WorkShop = new TextBox();
            label2WorkShop = new Label();
            textBox2WorkShop = new TextBox();
            label3WorkShop = new Label();
            textBox3WorkShop = new TextBox();
            CheckedListBoxWorkOrder = new CheckedListBox();
            button1WorkOrder = new Button();
            SuspendLayout();
            // 
            // label1WorkShop
            // 
            label1WorkShop.AutoSize = true;
            label1WorkShop.Location = new Point(16, 23);
            label1WorkShop.Margin = new Padding(4, 0, 4, 0);
            label1WorkShop.Name = "label1WorkShop";
            label1WorkShop.Size = new Size(192, 20);
            label1WorkShop.TabIndex = 0;
            label1WorkShop.Text = "Дата оформления наряда:";
            // 
            // textBox1WorkShop
            // 
            textBox1WorkShop.Location = new Point(197, 18);
            textBox1WorkShop.Margin = new Padding(4, 5, 4, 5);
            textBox1WorkShop.Name = "textBox1WorkShop";
            textBox1WorkShop.Size = new Size(265, 27);
            textBox1WorkShop.TabIndex = 1;
            // 
            // label2WorkShop
            // 
            label2WorkShop.AutoSize = true;
            label2WorkShop.Location = new Point(16, 69);
            label2WorkShop.Margin = new Padding(4, 0, 4, 0);
            label2WorkShop.Name = "label2WorkShop";
            label2WorkShop.Size = new Size(192, 20);
            label2WorkShop.TabIndex = 2;
            label2WorkShop.Text = "Срок выполнения наряда:";
            // 
            // textBox2WorkShop
            // 
            textBox2WorkShop.Location = new Point(197, 65);
            textBox2WorkShop.Margin = new Padding(4, 5, 4, 5);
            textBox2WorkShop.Name = "textBox2WorkShop";
            textBox2WorkShop.Size = new Size(265, 27);
            textBox2WorkShop.TabIndex = 3;
            // 
            // label3WorkShop
            // 
            label3WorkShop.AutoSize = true;
            label3WorkShop.Location = new Point(16, 115);
            label3WorkShop.Margin = new Padding(4, 0, 4, 0);
            label3WorkShop.Name = "label3WorkShop";
            label3WorkShop.Size = new Size(93, 20);
            label3WorkShop.TabIndex = 4;
            label3WorkShop.Text = "Количество:";
            // 
            // textBox3WorkShop
            // 
            textBox3WorkShop.Location = new Point(197, 111);
            textBox3WorkShop.Margin = new Padding(4, 5, 4, 5);
            textBox3WorkShop.Name = "textBox3WorkShop";
            textBox3WorkShop.Size = new Size(265, 27);
            textBox3WorkShop.TabIndex = 5;
            // 
            // CheckedListBoxWorkOrder
            // 
            CheckedListBoxWorkOrder.CheckOnClick = true;
            CheckedListBoxWorkOrder.FormattingEnabled = true;
            CheckedListBoxWorkOrder.Location = new Point(20, 169);
            CheckedListBoxWorkOrder.Margin = new Padding(4, 5, 4, 5);
            CheckedListBoxWorkOrder.Name = "CheckedListBoxWorkOrder";
            CheckedListBoxWorkOrder.Size = new Size(443, 158);
            CheckedListBoxWorkOrder.TabIndex = 6;
            // 
            // button1WorkOrder
            // 
            button1WorkOrder.Location = new Point(20, 362);
            button1WorkOrder.Margin = new Padding(4, 5, 4, 5);
            button1WorkOrder.Name = "button1WorkOrder";
            button1WorkOrder.Size = new Size(444, 35);
            button1WorkOrder.TabIndex = 7;
            button1WorkOrder.Text = "Добавить наряд";
            button1WorkOrder.UseVisualStyleBackColor = true;
            // 
            // AddWorkOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 432);
            Controls.Add(button1WorkOrder);
            Controls.Add(CheckedListBoxWorkOrder);
            Controls.Add(textBox3WorkShop);
            Controls.Add(label3WorkShop);
            Controls.Add(textBox2WorkShop);
            Controls.Add(label2WorkShop);
            Controls.Add(textBox1WorkShop);
            Controls.Add(label1WorkShop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddWorkOrderForm";
            Text = "Добавить наряд";
            Load += AddWorkOrderForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1WorkShop;
        private System.Windows.Forms.TextBox textBox1WorkShop;
        private System.Windows.Forms.Label label2WorkShop;
        private System.Windows.Forms.TextBox textBox2WorkShop;
        private System.Windows.Forms.Label label3WorkShop;
        private System.Windows.Forms.TextBox textBox3WorkShop;
        private System.Windows.Forms.CheckedListBox CheckedListBoxWorkOrder;
        private System.Windows.Forms.Button button1WorkOrder;
    }
}
