namespace Production
{
    partial class MainForm
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolsTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OperationTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Операции = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.tooltabpage = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastProductionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationUsecaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolsUsecaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ToolsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.OperationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.tooltabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationUsecaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsUsecaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolsTabPage
            // 
            this.ToolsTabPage.Controls.Add(this.splitContainer3);
            this.ToolsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ToolsTabPage.Name = "ToolsTabPage";
            this.ToolsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ToolsTabPage.Size = new System.Drawing.Size(781, 412);
            this.ToolsTabPage.TabIndex = 2;
            this.ToolsTabPage.Text = "Инструменты";
            this.ToolsTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer3.Size = new System.Drawing.Size(775, 406);
            this.splitContainer3.SplitterDistance = 258;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ttDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.dateReceivedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateTakeDataGridViewTextBoxColumn,
            this.takerDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.toolsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(513, 406);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // OperationTabPage
            // 
            this.OperationTabPage.Controls.Add(this.splitContainer2);
            this.OperationTabPage.Location = new System.Drawing.Point(4, 25);
            this.OperationTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.OperationTabPage.Name = "OperationTabPage";
            this.OperationTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.OperationTabPage.Size = new System.Drawing.Size(781, 412);
            this.OperationTabPage.TabIndex = 1;
            this.OperationTabPage.Text = "Операции";
            this.OperationTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Операции);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(773, 404);
            this.splitContainer2.SplitterDistance = 256;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // Операции
            // 
            this.Операции.Dock = System.Windows.Forms.DockStyle.Top;
            this.Операции.Location = new System.Drawing.Point(0, 0);
            this.Операции.Margin = new System.Windows.Forms.Padding(4);
            this.Операции.Name = "Операции";
            this.Операции.Size = new System.Drawing.Size(256, 28);
            this.Операции.TabIndex = 0;
            this.Операции.Text = "Новый продукт";
            this.Операции.UseVisualStyleBackColor = true;
            this.Операции.Click += new System.EventHandler(this.addProductButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.operationUsecaseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(512, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(781, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продукты";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddProductButton);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.productsDataGridView);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(773, 404);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(4, 33);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(247, 28);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastProductionDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.operationsDataGridViewTextBoxColumn});
            this.productsDataGridView.DataSource = this.productBindingSource;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.Size = new System.Drawing.Size(512, 404);
            this.productsDataGridView.TabIndex = 2;
            // 
            // tooltabpage
            // 
            this.tooltabpage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tooltabpage.Controls.Add(this.tabPage1);
            this.tooltabpage.Controls.Add(this.OperationTabPage);
            this.tooltabpage.Controls.Add(this.ToolsTabPage);
            this.tooltabpage.Location = new System.Drawing.Point(5, 7);
            this.tooltabpage.Margin = new System.Windows.Forms.Padding(4);
            this.tooltabpage.Name = "tooltabpage";
            this.tooltabpage.SelectedIndex = 0;
            this.tooltabpage.Size = new System.Drawing.Size(789, 441);
            this.tooltabpage.TabIndex = 0;
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
            // operationUsecaseBindingSource
            // 
            this.operationUsecaseBindingSource.DataSource = typeof(Production.OperationUsecase);
            // 
            // ttDataGridViewTextBoxColumn
            // 
            this.ttDataGridViewTextBoxColumn.DataPropertyName = "Tt";
            this.ttDataGridViewTextBoxColumn.HeaderText = "Tt";
            this.ttDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ttDataGridViewTextBoxColumn.Name = "ttDataGridViewTextBoxColumn";
            this.ttDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateReceivedDataGridViewTextBoxColumn
            // 
            this.dateReceivedDataGridViewTextBoxColumn.DataPropertyName = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.HeaderText = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReceivedDataGridViewTextBoxColumn.Name = "dateReceivedDataGridViewTextBoxColumn";
            this.dateReceivedDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTakeDataGridViewTextBoxColumn
            // 
            this.dateTakeDataGridViewTextBoxColumn.DataPropertyName = "DateTake";
            this.dateTakeDataGridViewTextBoxColumn.HeaderText = "DateTake";
            this.dateTakeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTakeDataGridViewTextBoxColumn.Name = "dateTakeDataGridViewTextBoxColumn";
            this.dateTakeDataGridViewTextBoxColumn.Width = 125;
            // 
            // takerDataGridViewTextBoxColumn
            // 
            this.takerDataGridViewTextBoxColumn.DataPropertyName = "Taker";
            this.takerDataGridViewTextBoxColumn.HeaderText = "Taker";
            this.takerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takerDataGridViewTextBoxColumn.Name = "takerDataGridViewTextBoxColumn";
            this.takerDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolsBindingSource
            // 
            this.toolsBindingSource.DataSource = typeof(Production.Tools);
            // 
            // toolsUsecaseBindingSource
            // 
            this.toolsUsecaseBindingSource.DataSource = typeof(Production.ToolsUsecase);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Production.Product);
            this.productBindingSource1.CurrentChanged += new System.EventHandler(this.productBindingSource1_CurrentChanged);
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataSource = typeof(Production.Product);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tooltabpage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(394, 358);
            this.Name = "MainForm";
            this.Text = "Производство";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.ToolsTabPage.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.OperationTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.tooltabpage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationUsecaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsUsecaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.TabPage ToolsTabPage;
        private System.Windows.Forms.TabPage OperationTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Операции;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastProductionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tooltabpage;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource toolsUsecaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toolsBindingSource;
        private System.Windows.Forms.BindingSource operationUsecaseBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource2;
    }
}

