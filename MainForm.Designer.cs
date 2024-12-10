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
            this.components = new System.ComponentModel.Container();
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
            this.SplitContainerTools = new System.Windows.Forms.SplitContainer();
            this.DeleteToolsButton = new System.Windows.Forms.Button();
            this.AddToolsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.splitContainerMaterial = new System.Windows.Forms.SplitContainer();
            this.buttonDeleteMaterial = new System.Windows.Forms.Button();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInMemoryDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTools)).BeginInit();
            this.SplitContainerTools.Panel1.SuspendLayout();
            this.SplitContainerTools.Panel2.SuspendLayout();
            this.SplitContainerTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).BeginInit();
            this.tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterial)).BeginInit();
            this.splitContainerMaterial.Panel1.SuspendLayout();
            this.splitContainerMaterial.Panel2.SuspendLayout();
            this.splitContainerMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabMaterial);
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
            this.productsInMemoryDataGridView.AllowUserToAddRows = false;
            this.productsInMemoryDataGridView.AllowUserToDeleteRows = false;
            this.productsInMemoryDataGridView.AllowUserToOrderColumns = true;
            this.productsInMemoryDataGridView.AutoGenerateColumns = false;
            this.productsInMemoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsInMemoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productsInMemoryDataGridView.DataSource = this.bindingSource1;
            this.productsInMemoryDataGridView.Location = new System.Drawing.Point(23, 75);
            this.productsInMemoryDataGridView.Name = "productsInMemoryDataGridView";
            this.productsInMemoryDataGridView.ReadOnly = true;
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
            this.tabPage3.Controls.Add(this.SplitContainerTools);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(906, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Инструменты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SplitContainerTools
            // 
            this.SplitContainerTools.Location = new System.Drawing.Point(3, 3);
            this.SplitContainerTools.Name = "SplitContainerTools";
            // 
            // SplitContainerTools.Panel1
            // 
            this.SplitContainerTools.Panel1.Controls.Add(this.DeleteToolsButton);
            this.SplitContainerTools.Panel1.Controls.Add(this.AddToolsButton);
            // 
            // SplitContainerTools.Panel2
            // 
            this.SplitContainerTools.Panel2.Controls.Add(this.dataGridView1);
            this.SplitContainerTools.Size = new System.Drawing.Size(903, 442);
            this.SplitContainerTools.SplitterDistance = 301;
            this.SplitContainerTools.TabIndex = 1;
            // 
            // DeleteToolsButton
            // 
            this.DeleteToolsButton.Location = new System.Drawing.Point(42, 75);
            this.DeleteToolsButton.Name = "DeleteToolsButton";
            this.DeleteToolsButton.Size = new System.Drawing.Size(171, 28);
            this.DeleteToolsButton.TabIndex = 1;
            this.DeleteToolsButton.Text = "Удалить инструмент";
            this.DeleteToolsButton.UseVisualStyleBackColor = true;
            this.DeleteToolsButton.Click += new System.EventHandler(this.DeleteToolsButton_Click);
            // 
            // AddToolsButton
            // 
            this.AddToolsButton.Location = new System.Drawing.Point(42, 21);
            this.AddToolsButton.Name = "AddToolsButton";
            this.AddToolsButton.Size = new System.Drawing.Size(171, 32);
            this.AddToolsButton.TabIndex = 0;
            this.AddToolsButton.Text = "Добавить инструмент";
            this.AddToolsButton.UseVisualStyleBackColor = true;
            this.AddToolsButton.Click += new System.EventHandler(this.AddToolsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.ttDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn2,
            this.dateReceivedDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.dateTakeDataGridViewTextBoxColumn1,
            this.takerDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.toolsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolsBindingSource
            // 
            this.toolsBindingSource.DataSource = typeof(Production.Tools);
            // 
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.splitContainerMaterial);
            this.tabMaterial.Location = new System.Drawing.Point(4, 25);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterial.Size = new System.Drawing.Size(906, 451);
            this.tabMaterial.TabIndex = 3;
            this.tabMaterial.Text = "Материал";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // splitContainerMaterial
            // 
            this.splitContainerMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMaterial.Location = new System.Drawing.Point(3, 3);
            this.splitContainerMaterial.Name = "splitContainerMaterial";
            // 
            // splitContainerMaterial.Panel1
            // 
            this.splitContainerMaterial.Panel1.Controls.Add(this.buttonDeleteMaterial);
            this.splitContainerMaterial.Panel1.Controls.Add(this.buttonAddMaterial);
            // 
            // splitContainerMaterial.Panel2
            // 
            this.splitContainerMaterial.Panel2.Controls.Add(this.dataGridViewMaterial);
            this.splitContainerMaterial.Size = new System.Drawing.Size(900, 445);
            this.splitContainerMaterial.SplitterDistance = 300;
            this.splitContainerMaterial.TabIndex = 0;
            // 
            // buttonDeleteMaterial
            // 
            this.buttonDeleteMaterial.Location = new System.Drawing.Point(50, 75);
            this.buttonDeleteMaterial.Name = "buttonDeleteMaterial";
            this.buttonDeleteMaterial.Size = new System.Drawing.Size(194, 23);
            this.buttonDeleteMaterial.TabIndex = 1;
            this.buttonDeleteMaterial.Text = "Удалить Материал";
            this.buttonDeleteMaterial.UseVisualStyleBackColor = true;
            this.buttonDeleteMaterial.Click += new System.EventHandler(this.buttonDeleteMaterial_Click);
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.Location = new System.Drawing.Point(50, 18);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(194, 25);
            this.buttonAddMaterial.TabIndex = 0;
            this.buttonAddMaterial.Text = "Добавить Материал";
            this.buttonAddMaterial.UseVisualStyleBackColor = true;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.AutoGenerateColumns = false;
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewMaterial.DataSource = this.materialBindingSource;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.RowHeadersWidth = 51;
            this.dataGridViewMaterial.RowTemplate.Height = 24;
            this.dataGridViewMaterial.Size = new System.Drawing.Size(596, 448);
            this.dataGridViewMaterial.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Material);
            // 
            // ttDataGridViewTextBoxColumn
            // 
            this.ttDataGridViewTextBoxColumn.DataPropertyName = "Tt";
            this.ttDataGridViewTextBoxColumn.HeaderText = "Tt";
            this.ttDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ttDataGridViewTextBoxColumn.Name = "ttDataGridViewTextBoxColumn";
            this.ttDataGridViewTextBoxColumn.Width = 125;
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
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // ttDataGridViewTextBoxColumn1
            // 
            this.ttDataGridViewTextBoxColumn1.DataPropertyName = "Tt";
            this.ttDataGridViewTextBoxColumn1.HeaderText = "Tt";
            this.ttDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ttDataGridViewTextBoxColumn1.Name = "ttDataGridViewTextBoxColumn1";
            this.ttDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dateReceivedDataGridViewTextBoxColumn1
            // 
            this.dateReceivedDataGridViewTextBoxColumn1.DataPropertyName = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn1.HeaderText = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateReceivedDataGridViewTextBoxColumn1.Name = "dateReceivedDataGridViewTextBoxColumn1";
            this.dateReceivedDataGridViewTextBoxColumn1.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateTakeDataGridViewTextBoxColumn1
            // 
            this.dateTakeDataGridViewTextBoxColumn1.DataPropertyName = "DateTake";
            this.dateTakeDataGridViewTextBoxColumn1.HeaderText = "DateTake";
            this.dateTakeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateTakeDataGridViewTextBoxColumn1.Name = "dateTakeDataGridViewTextBoxColumn1";
            this.dateTakeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // takerDataGridViewTextBoxColumn1
            // 
            this.takerDataGridViewTextBoxColumn1.DataPropertyName = "Taker";
            this.takerDataGridViewTextBoxColumn1.HeaderText = "Taker";
            this.takerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.takerDataGridViewTextBoxColumn1.Name = "takerDataGridViewTextBoxColumn1";
            this.takerDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Production.Product);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastProductionDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastProductionDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Operations";
            this.dataGridViewTextBoxColumn5.HeaderText = "Operations";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OperationsSummary";
            this.dataGridViewTextBoxColumn6.HeaderText = "OperationsSummary";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
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
            this.SplitContainerTools.Panel1.ResumeLayout(false);
            this.SplitContainerTools.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTools)).EndInit();
            this.SplitContainerTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).EndInit();
            this.tabMaterial.ResumeLayout(false);
            this.splitContainerMaterial.Panel1.ResumeLayout(false);
            this.splitContainerMaterial.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterial)).EndInit();
            this.splitContainerMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer SplitContainerTools;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toolsBindingSource;
        private System.Windows.Forms.Button DeleteToolsButton;
        private System.Windows.Forms.TabPage tabMaterial;
        private System.Windows.Forms.SplitContainer splitContainerMaterial;
        private System.Windows.Forms.Button buttonDeleteMaterial;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastProductionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationsSummaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn takerDataGridViewTextBoxColumn1;
    }
}
