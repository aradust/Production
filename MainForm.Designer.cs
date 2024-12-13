namespace Production
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.ttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkOrdertab = new System.Windows.Forms.TabPage();
            this.WorkOrdersplitContainer = new System.Windows.Forms.SplitContainer();
            this.AddWorlOrderButton = new System.Windows.Forms.Button();
            this.DeleteWorlOrderButton = new System.Windows.Forms.Button();
            this.WorkOrderdataGridView = new System.Windows.Forms.DataGridView();
            this.WorkshopTab = new System.Windows.Forms.TabPage();
            this.WorkShopsplitContainer = new System.Windows.Forms.SplitContainer();
            this.DeleteWorkShopButton = new System.Windows.Forms.Button();
            this.AddWorkShopButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DrawingsplitContainer = new System.Windows.Forms.SplitContainer();
            this.DeleteDrawingButton = new System.Windows.Forms.Button();
            this.AddDrawingButton = new System.Windows.Forms.Button();
            this.DrawingdataGridView = new System.Windows.Forms.DataGridView();
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.splitContainerMaterial = new System.Windows.Forms.SplitContainer();
            this.DeleteMaterialButton = new System.Windows.Forms.Button();
            this.AddMaterialButton = new System.Windows.Forms.Button();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SplitContainerTools = new System.Windows.Forms.SplitContainer();
            this.DeleteToolButton = new System.Windows.Forms.Button();
            this.AddToolButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.AddOperationButton = new System.Windows.Forms.Button();
            this.DeleteOperationButton = new System.Windows.Forms.Button();
            this.dataGridViewOperation = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddToolTypeButton = new System.Windows.Forms.Button();
            this.DeleteToolTypeButton = new System.Windows.Forms.Button();
            this.toolTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workShopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityTakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityStayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isConsumableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkOrdertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrdersplitContainer)).BeginInit();
            this.WorkOrdersplitContainer.Panel1.SuspendLayout();
            this.WorkOrdersplitContainer.Panel2.SuspendLayout();
            this.WorkOrdersplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderdataGridView)).BeginInit();
            this.WorkshopTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkShopsplitContainer)).BeginInit();
            this.WorkShopsplitContainer.Panel1.SuspendLayout();
            this.WorkShopsplitContainer.Panel2.SuspendLayout();
            this.WorkShopsplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingsplitContainer)).BeginInit();
            this.DrawingsplitContainer.Panel1.SuspendLayout();
            this.DrawingsplitContainer.Panel2.SuspendLayout();
            this.DrawingsplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingdataGridView)).BeginInit();
            this.tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterial)).BeginInit();
            this.splitContainerMaterial.Panel1.SuspendLayout();
            this.splitContainerMaterial.Panel2.SuspendLayout();
            this.splitContainerMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTools)).BeginInit();
            this.SplitContainerTools.Panel1.SuspendLayout();
            this.SplitContainerTools.Panel2.SuspendLayout();
            this.SplitContainerTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTypeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // WorkOrdertab
            // 
            this.WorkOrdertab.Controls.Add(this.WorkOrdersplitContainer);
            this.WorkOrdertab.Location = new System.Drawing.Point(4, 25);
            this.WorkOrdertab.Name = "WorkOrdertab";
            this.WorkOrdertab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkOrdertab.Size = new System.Drawing.Size(906, 451);
            this.WorkOrdertab.TabIndex = 6;
            this.WorkOrdertab.Text = "Наряд";
            this.WorkOrdertab.UseVisualStyleBackColor = true;
            // 
            // WorkOrdersplitContainer
            // 
            this.WorkOrdersplitContainer.Location = new System.Drawing.Point(0, 3);
            this.WorkOrdersplitContainer.Name = "WorkOrdersplitContainer";
            // 
            // WorkOrdersplitContainer.Panel1
            // 
            this.WorkOrdersplitContainer.Panel1.Controls.Add(this.AddWorlOrderButton);
            this.WorkOrdersplitContainer.Panel1.Controls.Add(this.DeleteWorlOrderButton);
            // 
            // WorkOrdersplitContainer.Panel2
            // 
            this.WorkOrdersplitContainer.Panel2.Controls.Add(this.WorkOrderdataGridView);
            this.WorkOrdersplitContainer.Size = new System.Drawing.Size(903, 448);
            this.WorkOrdersplitContainer.SplitterDistance = 255;
            this.WorkOrdersplitContainer.TabIndex = 2;
            // 
            // AddWorlOrderButton
            // 
            this.AddWorlOrderButton.Location = new System.Drawing.Point(39, 14);
            this.AddWorlOrderButton.Name = "AddWorlOrderButton";
            this.AddWorlOrderButton.Size = new System.Drawing.Size(158, 23);
            this.AddWorlOrderButton.TabIndex = 0;
            this.AddWorlOrderButton.Text = "Добавить наряд";
            this.AddWorlOrderButton.UseVisualStyleBackColor = true;
            this.AddWorlOrderButton.Click += new System.EventHandler(this.WorkOrderbutton1_Click);
            // 
            // DeleteWorlOrderButton
            // 
            this.DeleteWorlOrderButton.Location = new System.Drawing.Point(39, 66);
            this.DeleteWorlOrderButton.Name = "DeleteWorlOrderButton";
            this.DeleteWorlOrderButton.Size = new System.Drawing.Size(158, 23);
            this.DeleteWorlOrderButton.TabIndex = 1;
            this.DeleteWorlOrderButton.Text = "Удалить наряд";
            this.DeleteWorlOrderButton.UseVisualStyleBackColor = true;
            this.DeleteWorlOrderButton.Click += new System.EventHandler(this.WorkOrderbutton2_Click);
            // 
            // WorkOrderdataGridView
            // 
            this.WorkOrderdataGridView.AllowUserToAddRows = false;
            this.WorkOrderdataGridView.AllowUserToDeleteRows = false;
            this.WorkOrderdataGridView.AutoGenerateColumns = false;
            this.WorkOrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkOrderdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.productIdDataGridViewTextBoxColumn,
            this.dateIssuedDataGridViewTextBoxColumn,
            this.deadLineDataGridViewTextBoxColumn,
            this.quantityRequiredDataGridViewTextBoxColumn,
            this.productsDataGridViewTextBoxColumn});
            this.WorkOrderdataGridView.DataSource = this.workOrderBindingSource;
            this.WorkOrderdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkOrderdataGridView.Location = new System.Drawing.Point(0, 0);
            this.WorkOrderdataGridView.Name = "WorkOrderdataGridView";
            this.WorkOrderdataGridView.ReadOnly = true;
            this.WorkOrderdataGridView.RowHeadersWidth = 51;
            this.WorkOrderdataGridView.RowTemplate.Height = 24;
            this.WorkOrderdataGridView.Size = new System.Drawing.Size(644, 448);
            this.WorkOrderdataGridView.TabIndex = 0;
            // 
            // WorkshopTab
            // 
            this.WorkshopTab.Controls.Add(this.WorkShopsplitContainer);
            this.WorkshopTab.Controls.Add(this.label1);
            this.WorkshopTab.Location = new System.Drawing.Point(4, 25);
            this.WorkshopTab.Name = "WorkshopTab";
            this.WorkshopTab.Padding = new System.Windows.Forms.Padding(3);
            this.WorkshopTab.Size = new System.Drawing.Size(906, 451);
            this.WorkshopTab.TabIndex = 5;
            this.WorkshopTab.Text = "Цех";
            this.WorkshopTab.UseVisualStyleBackColor = true;
            // 
            // WorkShopsplitContainer
            // 
            this.WorkShopsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkShopsplitContainer.Location = new System.Drawing.Point(3, 3);
            this.WorkShopsplitContainer.Name = "WorkShopsplitContainer";
            // 
            // WorkShopsplitContainer.Panel1
            // 
            this.WorkShopsplitContainer.Panel1.Controls.Add(this.DeleteWorkShopButton);
            this.WorkShopsplitContainer.Panel1.Controls.Add(this.AddWorkShopButton);
            // 
            // WorkShopsplitContainer.Panel2
            // 
            this.WorkShopsplitContainer.Panel2.Controls.Add(this.dataGridView2);
            this.WorkShopsplitContainer.Size = new System.Drawing.Size(900, 445);
            this.WorkShopsplitContainer.SplitterDistance = 242;
            this.WorkShopsplitContainer.TabIndex = 3;
            // 
            // DeleteWorkShopButton
            // 
            this.DeleteWorkShopButton.Location = new System.Drawing.Point(61, 100);
            this.DeleteWorkShopButton.Name = "DeleteWorkShopButton";
            this.DeleteWorkShopButton.Size = new System.Drawing.Size(146, 23);
            this.DeleteWorkShopButton.TabIndex = 2;
            this.DeleteWorkShopButton.Text = "Удалить Цех";
            this.DeleteWorkShopButton.UseVisualStyleBackColor = true;
            this.DeleteWorkShopButton.Click += new System.EventHandler(this.WorkShopbutton2_Click);
            // 
            // AddWorkShopButton
            // 
            this.AddWorkShopButton.Location = new System.Drawing.Point(61, 39);
            this.AddWorkShopButton.Name = "AddWorkShopButton";
            this.AddWorkShopButton.Size = new System.Drawing.Size(146, 23);
            this.AddWorkShopButton.TabIndex = 0;
            this.AddWorkShopButton.Text = "Добавить Цех";
            this.AddWorkShopButton.UseVisualStyleBackColor = true;
            this.AddWorkShopButton.Click += new System.EventHandler(this.WorkShopbutton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView2.DataSource = this.workShopBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(654, 445);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DrawingsplitContainer);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(906, 451);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Чертёж";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DrawingsplitContainer
            // 
            this.DrawingsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingsplitContainer.Location = new System.Drawing.Point(3, 3);
            this.DrawingsplitContainer.Name = "DrawingsplitContainer";
            // 
            // DrawingsplitContainer.Panel1
            // 
            this.DrawingsplitContainer.Panel1.Controls.Add(this.DeleteDrawingButton);
            this.DrawingsplitContainer.Panel1.Controls.Add(this.AddDrawingButton);
            // 
            // DrawingsplitContainer.Panel2
            // 
            this.DrawingsplitContainer.Panel2.Controls.Add(this.DrawingdataGridView);
            this.DrawingsplitContainer.Size = new System.Drawing.Size(900, 445);
            this.DrawingsplitContainer.SplitterDistance = 250;
            this.DrawingsplitContainer.TabIndex = 0;
            // 
            // DeleteDrawingButton
            // 
            this.DeleteDrawingButton.Location = new System.Drawing.Point(18, 83);
            this.DeleteDrawingButton.Name = "DeleteDrawingButton";
            this.DeleteDrawingButton.Size = new System.Drawing.Size(145, 42);
            this.DeleteDrawingButton.TabIndex = 1;
            this.DeleteDrawingButton.Text = "Удалить Чертёж";
            this.DeleteDrawingButton.UseVisualStyleBackColor = true;
            this.DeleteDrawingButton.Click += new System.EventHandler(this.Drawingbutton2_Click);
            // 
            // AddDrawingButton
            // 
            this.AddDrawingButton.Location = new System.Drawing.Point(18, 18);
            this.AddDrawingButton.Name = "AddDrawingButton";
            this.AddDrawingButton.Size = new System.Drawing.Size(145, 35);
            this.AddDrawingButton.TabIndex = 0;
            this.AddDrawingButton.Text = "Добавить Чертёж";
            this.AddDrawingButton.UseVisualStyleBackColor = true;
            this.AddDrawingButton.Click += new System.EventHandler(this.Drawingbutton1_Click);
            // 
            // DrawingdataGridView
            // 
            this.DrawingdataGridView.AllowUserToAddRows = false;
            this.DrawingdataGridView.AllowUserToDeleteRows = false;
            this.DrawingdataGridView.AutoGenerateColumns = false;
            this.DrawingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrawingdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.descriptionDataGridViewTextBoxColumn1,
            this.specificationsDataGridViewTextBoxColumn});
            this.DrawingdataGridView.DataSource = this.drawingBindingSource;
            this.DrawingdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DrawingdataGridView.Name = "DrawingdataGridView";
            this.DrawingdataGridView.ReadOnly = true;
            this.DrawingdataGridView.RowHeadersWidth = 51;
            this.DrawingdataGridView.RowTemplate.Height = 24;
            this.DrawingdataGridView.Size = new System.Drawing.Size(646, 445);
            this.DrawingdataGridView.TabIndex = 0;
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
            this.splitContainerMaterial.Panel1.Controls.Add(this.DeleteMaterialButton);
            this.splitContainerMaterial.Panel1.Controls.Add(this.AddMaterialButton);
            // 
            // splitContainerMaterial.Panel2
            // 
            this.splitContainerMaterial.Panel2.Controls.Add(this.dataGridViewMaterial);
            this.splitContainerMaterial.Size = new System.Drawing.Size(900, 445);
            this.splitContainerMaterial.SplitterDistance = 247;
            this.splitContainerMaterial.TabIndex = 0;
            // 
            // DeleteMaterialButton
            // 
            this.DeleteMaterialButton.Location = new System.Drawing.Point(5, 44);
            this.DeleteMaterialButton.Name = "DeleteMaterialButton";
            this.DeleteMaterialButton.Size = new System.Drawing.Size(194, 25);
            this.DeleteMaterialButton.TabIndex = 1;
            this.DeleteMaterialButton.Text = "Удалить Материал";
            this.DeleteMaterialButton.UseVisualStyleBackColor = true;
            this.DeleteMaterialButton.Click += new System.EventHandler(this.buttonDeleteMaterial_Click);
            // 
            // AddMaterialButton
            // 
            this.AddMaterialButton.Location = new System.Drawing.Point(5, 13);
            this.AddMaterialButton.Name = "AddMaterialButton";
            this.AddMaterialButton.Size = new System.Drawing.Size(194, 25);
            this.AddMaterialButton.TabIndex = 0;
            this.AddMaterialButton.Text = "Добавить Материал";
            this.AddMaterialButton.UseVisualStyleBackColor = true;
            this.AddMaterialButton.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.AllowUserToAddRows = false;
            this.dataGridViewMaterial.AllowUserToDeleteRows = false;
            this.dataGridViewMaterial.AutoGenerateColumns = false;
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.descriptionDataGridViewTextBoxColumn,
            this.isConsumableDataGridViewCheckBoxColumn});
            this.dataGridViewMaterial.DataSource = this.materialBindingSource;
            this.dataGridViewMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.ReadOnly = true;
            this.dataGridViewMaterial.RowHeadersWidth = 51;
            this.dataGridViewMaterial.RowTemplate.Height = 24;
            this.dataGridViewMaterial.Size = new System.Drawing.Size(649, 445);
            this.dataGridViewMaterial.TabIndex = 0;
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
            this.SplitContainerTools.Panel1.Controls.Add(this.DeleteToolButton);
            this.SplitContainerTools.Panel1.Controls.Add(this.AddToolButton);
            // 
            // SplitContainerTools.Panel2
            // 
            this.SplitContainerTools.Panel2.Controls.Add(this.dataGridView1);
            this.SplitContainerTools.Size = new System.Drawing.Size(903, 442);
            this.SplitContainerTools.SplitterDistance = 254;
            this.SplitContainerTools.TabIndex = 1;
            // 
            // DeleteToolButton
            // 
            this.DeleteToolButton.Location = new System.Drawing.Point(42, 75);
            this.DeleteToolButton.Name = "DeleteToolButton";
            this.DeleteToolButton.Size = new System.Drawing.Size(171, 28);
            this.DeleteToolButton.TabIndex = 1;
            this.DeleteToolButton.Text = "Удалить инструмент";
            this.DeleteToolButton.UseVisualStyleBackColor = true;
            this.DeleteToolButton.Click += new System.EventHandler(this.DeleteToolsButton_Click);
            // 
            // AddToolButton
            // 
            this.AddToolButton.Location = new System.Drawing.Point(42, 21);
            this.AddToolButton.Name = "AddToolButton";
            this.AddToolButton.Size = new System.Drawing.Size(171, 32);
            this.AddToolButton.TabIndex = 0;
            this.AddToolButton.Text = "Добавить инструмент";
            this.AddToolButton.UseVisualStyleBackColor = true;
            this.AddToolButton.Click += new System.EventHandler(this.AddToolsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn25,
            this.dateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn4,
            this.quantityTakeDataGridViewTextBoxColumn,
            this.quantityStayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toolsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Операции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.AddOperationButton);
            this.splitContainer3.Panel1.Controls.Add(this.DeleteOperationButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewOperation);
            this.splitContainer3.Size = new System.Drawing.Size(900, 445);
            this.splitContainer3.SplitterDistance = 246;
            this.splitContainer3.TabIndex = 3;
            // 
            // AddOperationButton
            // 
            this.AddOperationButton.Location = new System.Drawing.Point(5, 5);
            this.AddOperationButton.Name = "AddOperationButton";
            this.AddOperationButton.Size = new System.Drawing.Size(171, 32);
            this.AddOperationButton.TabIndex = 3;
            this.AddOperationButton.Text = "Добавить операцию";
            this.AddOperationButton.UseVisualStyleBackColor = true;
            this.AddOperationButton.Click += new System.EventHandler(this.AddOperationButton_Click);
            // 
            // DeleteOperationButton
            // 
            this.DeleteOperationButton.Location = new System.Drawing.Point(5, 43);
            this.DeleteOperationButton.Name = "DeleteOperationButton";
            this.DeleteOperationButton.Size = new System.Drawing.Size(171, 32);
            this.DeleteOperationButton.TabIndex = 4;
            this.DeleteOperationButton.Text = "Удалить операцию";
            this.DeleteOperationButton.UseVisualStyleBackColor = true;
            this.DeleteOperationButton.Click += new System.EventHandler(this.DeleteOperationButton_Click);
            // 
            // dataGridViewOperation
            // 
            this.dataGridViewOperation.AllowUserToAddRows = false;
            this.dataGridViewOperation.AllowUserToDeleteRows = false;
            this.dataGridViewOperation.AutoGenerateColumns = false;
            this.dataGridViewOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn23,
            this.workShopIdDataGridViewTextBoxColumn,
            this.drawingIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn3,
            this.averageDurationDataGridViewTextBoxColumn,
            this.drawingsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn24});
            this.dataGridViewOperation.DataSource = this.operationBindingSource;
            this.dataGridViewOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOperation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOperation.Name = "dataGridViewOperation";
            this.dataGridViewOperation.ReadOnly = true;
            this.dataGridViewOperation.RowHeadersWidth = 51;
            this.dataGridViewOperation.Size = new System.Drawing.Size(650, 445);
            this.dataGridViewOperation.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabMaterial);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.WorkshopTab);
            this.tabControl.Controls.Add(this.WorkOrdertab);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(914, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продукты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddProductButton);
            this.splitContainer2.Panel1.Controls.Add(this.DeleteProductButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.productsDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(900, 445);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 3;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(18, 7);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(171, 32);
            this.AddProductButton.TabIndex = 3;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(18, 45);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(171, 32);
            this.DeleteProductButton.TabIndex = 4;
            this.DeleteProductButton.Text = "Удалить продукт";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18});
            this.productsDataGridView.DataSource = this.bindingSource1;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.Size = new System.Drawing.Size(650, 445);
            this.productsDataGridView.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(906, 451);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Типы инструментов";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddToolTypeButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteToolTypeButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolTypeDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(900, 445);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 1;
            // 
            // AddToolTypeButton
            // 
            this.AddToolTypeButton.Location = new System.Drawing.Point(25, 14);
            this.AddToolTypeButton.Name = "AddToolTypeButton";
            this.AddToolTypeButton.Size = new System.Drawing.Size(159, 42);
            this.AddToolTypeButton.TabIndex = 2;
            this.AddToolTypeButton.Text = "Добавить тип инструмента";
            this.AddToolTypeButton.UseVisualStyleBackColor = true;
            this.AddToolTypeButton.Click += new System.EventHandler(this.addToolTypeButton_Click);
            // 
            // DeleteToolTypeButton
            // 
            this.DeleteToolTypeButton.Location = new System.Drawing.Point(25, 73);
            this.DeleteToolTypeButton.Name = "DeleteToolTypeButton";
            this.DeleteToolTypeButton.Size = new System.Drawing.Size(159, 42);
            this.DeleteToolTypeButton.TabIndex = 1;
            this.DeleteToolTypeButton.Text = "Удалить тип инструмента";
            this.DeleteToolTypeButton.UseVisualStyleBackColor = true;
            this.DeleteToolTypeButton.Click += new System.EventHandler(this.deleteToolTypeButton_Click);
            // 
            // toolTypeDataGridView
            // 
            this.toolTypeDataGridView.AllowUserToAddRows = false;
            this.toolTypeDataGridView.AllowUserToDeleteRows = false;
            this.toolTypeDataGridView.AutoGenerateColumns = false;
            this.toolTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn22,
            this.descriptionDataGridViewTextBoxColumn2});
            this.toolTypeDataGridView.DataSource = this.toolTypeBindingSource;
            this.toolTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTypeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.toolTypeDataGridView.Name = "toolTypeDataGridView";
            this.toolTypeDataGridView.ReadOnly = true;
            this.toolTypeDataGridView.RowHeadersWidth = 51;
            this.toolTypeDataGridView.RowTemplate.Height = 24;
            this.toolTypeDataGridView.Size = new System.Drawing.Size(648, 445);
            this.toolTypeDataGridView.TabIndex = 0;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Operations";
            this.dataGridViewTextBoxColumn5.HeaderText = "Operations";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastProductionDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastProductionDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Name";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "LastProductionDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "LastProductionDate";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn16.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "OperationsSummary";
            this.dataGridViewTextBoxColumn18.HeaderText = "OperationsSummary";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Production.Product);
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn23.HeaderText = "Name";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // workShopIdDataGridViewTextBoxColumn
            // 
            this.workShopIdDataGridViewTextBoxColumn.DataPropertyName = "WorkShopId";
            this.workShopIdDataGridViewTextBoxColumn.HeaderText = "WorkShopId";
            this.workShopIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workShopIdDataGridViewTextBoxColumn.Name = "workShopIdDataGridViewTextBoxColumn";
            this.workShopIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.workShopIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // drawingIdDataGridViewTextBoxColumn
            // 
            this.drawingIdDataGridViewTextBoxColumn.DataPropertyName = "DrawingId";
            this.drawingIdDataGridViewTextBoxColumn.HeaderText = "DrawingId";
            this.drawingIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drawingIdDataGridViewTextBoxColumn.Name = "drawingIdDataGridViewTextBoxColumn";
            this.drawingIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.drawingIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn3
            // 
            this.descriptionDataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn3.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn3.Name = "descriptionDataGridViewTextBoxColumn3";
            this.descriptionDataGridViewTextBoxColumn3.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn3.Width = 125;
            // 
            // averageDurationDataGridViewTextBoxColumn
            // 
            this.averageDurationDataGridViewTextBoxColumn.DataPropertyName = "AverageDuration";
            this.averageDurationDataGridViewTextBoxColumn.HeaderText = "AverageDuration";
            this.averageDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averageDurationDataGridViewTextBoxColumn.Name = "averageDurationDataGridViewTextBoxColumn";
            this.averageDurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.averageDurationDataGridViewTextBoxColumn.Width = 125;
            // 
            // drawingsDataGridViewTextBoxColumn
            // 
            this.drawingsDataGridViewTextBoxColumn.DataPropertyName = "Drawings";
            this.drawingsDataGridViewTextBoxColumn.HeaderText = "Drawings";
            this.drawingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drawingsDataGridViewTextBoxColumn.Name = "drawingsDataGridViewTextBoxColumn";
            this.drawingsDataGridViewTextBoxColumn.ReadOnly = true;
            this.drawingsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "OperationsSummary";
            this.dataGridViewTextBoxColumn24.HeaderText = "OperationsSummary";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataSource = typeof(Production.Operation);
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn25.HeaderText = "Name";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn4
            // 
            this.descriptionDataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn4.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn4.Name = "descriptionDataGridViewTextBoxColumn4";
            this.descriptionDataGridViewTextBoxColumn4.Width = 125;
            // 
            // quantityTakeDataGridViewTextBoxColumn
            // 
            this.quantityTakeDataGridViewTextBoxColumn.DataPropertyName = "QuantityTake";
            this.quantityTakeDataGridViewTextBoxColumn.HeaderText = "QuantityTake";
            this.quantityTakeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityTakeDataGridViewTextBoxColumn.Name = "quantityTakeDataGridViewTextBoxColumn";
            this.quantityTakeDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityStayDataGridViewTextBoxColumn
            // 
            this.quantityStayDataGridViewTextBoxColumn.DataPropertyName = "QuantityStay";
            this.quantityStayDataGridViewTextBoxColumn.HeaderText = "QuantityStay";
            this.quantityStayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityStayDataGridViewTextBoxColumn.Name = "quantityStayDataGridViewTextBoxColumn";
            this.quantityStayDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolsBindingSource
            // 
            this.toolsBindingSource.DataSource = typeof(Production.Tools);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // isConsumableDataGridViewCheckBoxColumn
            // 
            this.isConsumableDataGridViewCheckBoxColumn.DataPropertyName = "IsConsumable";
            this.isConsumableDataGridViewCheckBoxColumn.HeaderText = "IsConsumable";
            this.isConsumableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isConsumableDataGridViewCheckBoxColumn.Name = "isConsumableDataGridViewCheckBoxColumn";
            this.isConsumableDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isConsumableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Material);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // specificationsDataGridViewTextBoxColumn
            // 
            this.specificationsDataGridViewTextBoxColumn.DataPropertyName = "Specifications";
            this.specificationsDataGridViewTextBoxColumn.HeaderText = "Specifications";
            this.specificationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specificationsDataGridViewTextBoxColumn.Name = "specificationsDataGridViewTextBoxColumn";
            this.specificationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // drawingBindingSource
            // 
            this.drawingBindingSource.DataSource = typeof(Production.Drawing);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn12.HeaderText = "Id";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // workShopBindingSource
            // 
            this.workShopBindingSource.DataSource = typeof(Production.WorkShop);
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn19.HeaderText = "Id";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateIssuedDataGridViewTextBoxColumn
            // 
            this.dateIssuedDataGridViewTextBoxColumn.DataPropertyName = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.HeaderText = "DateIssued";
            this.dateIssuedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateIssuedDataGridViewTextBoxColumn.Name = "dateIssuedDataGridViewTextBoxColumn";
            this.dateIssuedDataGridViewTextBoxColumn.Width = 125;
            // 
            // deadLineDataGridViewTextBoxColumn
            // 
            this.deadLineDataGridViewTextBoxColumn.DataPropertyName = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.HeaderText = "DeadLine";
            this.deadLineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deadLineDataGridViewTextBoxColumn.Name = "deadLineDataGridViewTextBoxColumn";
            this.deadLineDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityRequiredDataGridViewTextBoxColumn
            // 
            this.quantityRequiredDataGridViewTextBoxColumn.DataPropertyName = "QuantityRequired";
            this.quantityRequiredDataGridViewTextBoxColumn.HeaderText = "QuantityRequired";
            this.quantityRequiredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityRequiredDataGridViewTextBoxColumn.Name = "quantityRequiredDataGridViewTextBoxColumn";
            this.quantityRequiredDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            this.productsDataGridViewTextBoxColumn.Width = 125;
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataSource = typeof(Production.WorkOrder);
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn20.HeaderText = "Id";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn22.HeaderText = "Name";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn2.Width = 125;
            // 
            // toolTypeBindingSource
            // 
            this.toolTypeBindingSource.DataSource = typeof(Production.ToolType);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.WorkOrdertab.ResumeLayout(false);
            this.WorkOrdersplitContainer.Panel1.ResumeLayout(false);
            this.WorkOrdersplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrdersplitContainer)).EndInit();
            this.WorkOrdersplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderdataGridView)).EndInit();
            this.WorkshopTab.ResumeLayout(false);
            this.WorkshopTab.PerformLayout();
            this.WorkShopsplitContainer.Panel1.ResumeLayout(false);
            this.WorkShopsplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkShopsplitContainer)).EndInit();
            this.WorkShopsplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.DrawingsplitContainer.Panel1.ResumeLayout(false);
            this.DrawingsplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingsplitContainer)).EndInit();
            this.DrawingsplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingdataGridView)).EndInit();
            this.tabMaterial.ResumeLayout(false);
            this.splitContainerMaterial.Panel1.ResumeLayout(false);
            this.splitContainerMaterial.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterial)).EndInit();
            this.splitContainerMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.SplitContainerTools.Panel1.ResumeLayout(false);
            this.SplitContainerTools.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTools)).EndInit();
            this.SplitContainerTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastProductionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationsSummaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource drawingBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource workShopBindingSource;
        private System.Windows.Forms.TabPage WorkOrdertab;
        private System.Windows.Forms.SplitContainer WorkOrdersplitContainer;
        private System.Windows.Forms.Button AddWorlOrderButton;
        private System.Windows.Forms.Button DeleteWorlOrderButton;
        private System.Windows.Forms.DataGridView WorkOrderdataGridView;
        private System.Windows.Forms.TabPage WorkshopTab;
        private System.Windows.Forms.SplitContainer WorkShopsplitContainer;
        private System.Windows.Forms.Button DeleteWorkShopButton;
        private System.Windows.Forms.Button AddWorkShopButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer DrawingsplitContainer;
        private System.Windows.Forms.Button DeleteDrawingButton;
        private System.Windows.Forms.Button AddDrawingButton;
        private System.Windows.Forms.DataGridView DrawingdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabMaterial;
        private System.Windows.Forms.SplitContainer splitContainerMaterial;
        private System.Windows.Forms.Button DeleteMaterialButton;
        private System.Windows.Forms.Button AddMaterialButton;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isConsumableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer SplitContainerTools;
        private System.Windows.Forms.Button DeleteToolButton;
        private System.Windows.Forms.Button AddToolButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn takerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView toolTypeDataGridView;
        private System.Windows.Forms.Button AddToolTypeButton;
        private System.Windows.Forms.Button DeleteToolTypeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource toolTypeBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button AddOperationButton;
        private System.Windows.Forms.Button DeleteOperationButton;
        private System.Windows.Forms.DataGridView dataGridViewOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn workShopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityTakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityStayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource toolsBindingSource;
    }
}
