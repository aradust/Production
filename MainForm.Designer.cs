namespace Production
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ProductDeleteButton;
        private System.Windows.Forms.DataGridView productsInMemoryDataGridView;
        private System.Windows.Forms.Button AddOperationButton;
        private System.Windows.Forms.Button OperationButton_2;
        private System.Windows.Forms.DataGridView dataGridViewOperation;
        private System.Windows.Forms.Button AddToolsButton;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductDeleteButton = new System.Windows.Forms.Button();
            this.productsInMemoryDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddOperationButton = new System.Windows.Forms.Button();
            this.OperationButton_2 = new System.Windows.Forms.Button();
            this.dataGridViewOperation = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AddToolsButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInMemoryDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(914, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddProductButton);
            this.tabPage1.Controls.Add(this.ProductDeleteButton);
            this.tabPage1.Controls.Add(this.productsInMemoryDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продукты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(23, 21);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(171, 32);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductDeleteButton
            // 
            this.ProductDeleteButton.Location = new System.Drawing.Point(229, 21);
            this.ProductDeleteButton.Name = "ProductDeleteButton";
            this.ProductDeleteButton.Size = new System.Drawing.Size(171, 32);
            this.ProductDeleteButton.TabIndex = 1;
            this.ProductDeleteButton.Text = "Удалить продукт";
            this.ProductDeleteButton.UseVisualStyleBackColor = true;
            this.ProductDeleteButton.Click += new System.EventHandler(this.ProductDeleteButton_Click);
            // 
            // productsInMemoryDataGridView
            // 
            this.productsInMemoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsInMemoryDataGridView.Location = new System.Drawing.Point(23, 75);
            this.productsInMemoryDataGridView.Name = "productsInMemoryDataGridView";
            this.productsInMemoryDataGridView.RowHeadersWidth = 51;
            this.productsInMemoryDataGridView.Size = new System.Drawing.Size(857, 352);
            this.productsInMemoryDataGridView.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddOperationButton);
            this.tabPage2.Controls.Add(this.OperationButton_2);
            this.tabPage2.Controls.Add(this.dataGridViewOperation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Операции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddOperationButton
            // 
            this.AddOperationButton.Location = new System.Drawing.Point(23, 21);
            this.AddOperationButton.Name = "AddOperationButton";
            this.AddOperationButton.Size = new System.Drawing.Size(171, 32);
            this.AddOperationButton.TabIndex = 0;
            this.AddOperationButton.Text = "Добавить операцию";
            this.AddOperationButton.UseVisualStyleBackColor = true;
            this.AddOperationButton.Click += new System.EventHandler(this.AddOperationButton_Click);
            // 
            // OperationButton_2
            // 
            this.OperationButton_2.Location = new System.Drawing.Point(220, 21);
            this.OperationButton_2.Name = "OperationButton_2";
            this.OperationButton_2.Size = new System.Drawing.Size(171, 32);
            this.OperationButton_2.TabIndex = 1;
            this.OperationButton_2.Text = "Удалить операцию";
            this.OperationButton_2.UseVisualStyleBackColor = true;
            this.OperationButton_2.Click += new System.EventHandler(this.OperationButton_2_Click);
            // 
            // dataGridViewOperation
            // 
            this.dataGridViewOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperation.Location = new System.Drawing.Point(23, 91);
            this.dataGridViewOperation.Name = "dataGridViewOperation";
            this.dataGridViewOperation.RowHeadersWidth = 51;
            this.dataGridViewOperation.Size = new System.Drawing.Size(857, 352);
            this.dataGridViewOperation.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AddToolsButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(906, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Инструменты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AddToolsButton
            // 
            this.AddToolsButton.Location = new System.Drawing.Point(23, 21);
            this.AddToolsButton.Name = "AddToolsButton";
            this.AddToolsButton.Size = new System.Drawing.Size(171, 32);
            this.AddToolsButton.TabIndex = 0;
            this.AddToolsButton.Text = "Добавить инструмент";
            this.AddToolsButton.UseVisualStyleBackColor = true;
            this.AddToolsButton.Click += new System.EventHandler(this.AddToolsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsInMemoryDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
