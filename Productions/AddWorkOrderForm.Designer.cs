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
            this.label1WorkShop = new System.Windows.Forms.Label();
            this.textBox1WorkShop = new System.Windows.Forms.TextBox();
            this.label2WorkShop = new System.Windows.Forms.Label();
            this.textBox2WorkShop = new System.Windows.Forms.TextBox();
            this.label3WorkShop = new System.Windows.Forms.Label();
            this.textBox3WorkShop = new System.Windows.Forms.TextBox();
            this.CheckedListBoxWorkOrder = new System.Windows.Forms.CheckedListBox();
            this.button1WorkOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1WorkShop
            // 
            this.label1WorkShop.AutoSize = true;
            this.label1WorkShop.Location = new System.Drawing.Point(12, 15);
            this.label1WorkShop.Name = "label1WorkShop";
            this.label1WorkShop.Size = new System.Drawing.Size(130, 13);
            this.label1WorkShop.TabIndex = 0;
            this.label1WorkShop.Text = "Дата оформления наряда:";
            // 
            // textBox1WorkShop
            // 
            this.textBox1WorkShop.Location = new System.Drawing.Point(148, 12);
            this.textBox1WorkShop.Name = "textBox1WorkShop";
            this.textBox1WorkShop.Size = new System.Drawing.Size(200, 20);
            this.textBox1WorkShop.TabIndex = 1;
            // 
            // label2WorkShop
            // 
            this.label2WorkShop.AutoSize = true;
            this.label2WorkShop.Location = new System.Drawing.Point(12, 45);
            this.label2WorkShop.Name = "label2WorkShop";
            this.label2WorkShop.Size = new System.Drawing.Size(121, 13);
            this.label2WorkShop.TabIndex = 2;
            this.label2WorkShop.Text = "Срок выполнения наряда:";
            // 
            // textBox2WorkShop
            // 
            this.textBox2WorkShop.Location = new System.Drawing.Point(148, 42);
            this.textBox2WorkShop.Name = "textBox2WorkShop";
            this.textBox2WorkShop.Size = new System.Drawing.Size(200, 20);
            this.textBox2WorkShop.TabIndex = 3;
            // 
            // label3WorkShop
            // 
            this.label3WorkShop.AutoSize = true;
            this.label3WorkShop.Location = new System.Drawing.Point(12, 75);
            this.label3WorkShop.Name = "label3WorkShop";
            this.label3WorkShop.Size = new System.Drawing.Size(62, 13);
            this.label3WorkShop.TabIndex = 4;
            this.label3WorkShop.Text = "Количество:";
            // 
            // textBox3WorkShop
            // 
            this.textBox3WorkShop.Location = new System.Drawing.Point(148, 72);
            this.textBox3WorkShop.Name = "textBox3WorkShop";
            this.textBox3WorkShop.Size = new System.Drawing.Size(200, 20);
            this.textBox3WorkShop.TabIndex = 5;
            // 
            // CheckedListBoxWorkOrder
            // 
            this.CheckedListBoxWorkOrder.CheckOnClick = true;
            this.CheckedListBoxWorkOrder.FormattingEnabled = true;
            this.CheckedListBoxWorkOrder.Location = new System.Drawing.Point(15, 110);
            this.CheckedListBoxWorkOrder.Name = "CheckedListBoxWorkOrder";
            this.CheckedListBoxWorkOrder.Size = new System.Drawing.Size(333, 109);
            this.CheckedListBoxWorkOrder.TabIndex = 6;
            // 
            // button1WorkOrder
            // 
            this.button1WorkOrder.Location = new System.Drawing.Point(15, 235);
            this.button1WorkOrder.Name = "button1WorkOrder";
            this.button1WorkOrder.Size = new System.Drawing.Size(333, 23);
            this.button1WorkOrder.TabIndex = 7;
            this.button1WorkOrder.Text = "Добавить наряд";
            this.button1WorkOrder.UseVisualStyleBackColor = true;
            // 
            // AddWorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.button1WorkOrder);
            this.Controls.Add(this.CheckedListBoxWorkOrder);
            this.Controls.Add(this.textBox3WorkShop);
            this.Controls.Add(this.label3WorkShop);
            this.Controls.Add(this.textBox2WorkShop);
            this.Controls.Add(this.label2WorkShop);
            this.Controls.Add(this.textBox1WorkShop);
            this.Controls.Add(this.label1WorkShop);
            this.Name = "AddWorkOrderForm";
            this.Text = "Добавить наряд";
            this.ResumeLayout(false);
            this.PerformLayout();
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
