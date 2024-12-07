﻿namespace Production
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button AddOperationButton;
        private System.Windows.Forms.Button AddToolsButton;
        private System.Windows.Forms.DataGridView productsInMemoryDataGridView;

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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.productsInMemoryDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddOperationButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AddToolsButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastProductionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInMemoryDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // productsInMemoryDataGridView
            // 
            this.productsInMemoryDataGridView.AutoGenerateColumns = false;
            this.productsInMemoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsInMemoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastProductionDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.operationsDataGridViewTextBoxColumn});
            this.productsInMemoryDataGridView.DataSource = this.productBindingSource;
            this.productsInMemoryDataGridView.Location = new System.Drawing.Point(23, 75);
            this.productsInMemoryDataGridView.Name = "productsInMemoryDataGridView";
            this.productsInMemoryDataGridView.RowHeadersWidth = 51;
            this.productsInMemoryDataGridView.Size = new System.Drawing.Size(857, 352);
            this.productsInMemoryDataGridView.TabIndex = 2;
            this.productsInMemoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsInMemoryDataGridView_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AddOperationButton);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastProductionDateDataGridViewTextBoxColumn
            // 
            this.lastProductionDateDataGridViewTextBoxColumn.DataPropertyName = "LastProductionDate";
            this.lastProductionDateDataGridViewTextBoxColumn.HeaderText = "LastProductionDate";
            this.lastProductionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastProductionDateDataGridViewTextBoxColumn.Name = "lastProductionDateDataGridViewTextBoxColumn";
            this.lastProductionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationsDataGridViewTextBoxColumn
            // 
            this.operationsDataGridViewTextBoxColumn.DataPropertyName = "Operations";
            this.operationsDataGridViewTextBoxColumn.HeaderText = "Operations";
            this.operationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationsDataGridViewTextBoxColumn.Name = "operationsDataGridViewTextBoxColumn";
            this.operationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Production.Product);
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastProductionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}
