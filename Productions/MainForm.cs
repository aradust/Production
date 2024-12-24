using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using Production.Usecase;

namespace Production
{
    /// <summary>
    /// Главная форма приложения, предоставляющая доступ к функционалу управления продуктами.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="MainForm"/>.
        /// </summary>
        private OperationUsecase _OperationUsecase;
        private ProductionUsecase _ProductionUsecase;
        private ToolsUsecase _ToolsUsecase;
        private MaterialUsecase _MaterialUsecase;
        private DrawingUsecase _DrawingUsecase;
        private WorkShopUsecase _WorkShopUsecase;
        private WorkOrderUsecase _WorkOrderUsecase;
        private ToolTypeUsecase _ToolTypeUsecase;
        public MainForm()
        {
            _ProductionUsecase = new ProductionUsecase(new FileProductRepository("products.json"));
            _OperationUsecase = new OperationUsecase(new FileOperationRepository("operations.json"));
            _ToolsUsecase = new ToolsUsecase(new FileToolsRepository("tools.json"));
            _MaterialUsecase = new MaterialUsecase(new FileMaterialRepository("material.json"));
            _DrawingUsecase = new DrawingUsecase(new FileDrawingRepository("drawing.json"));
            _WorkShopUsecase = new WorkShopUsecase(new FileWorkShopRepository("workshop.json"));
            _WorkOrderUsecase = new WorkOrderUsecase(new FileWorkOrderRepository("workorder.json"));
            _ToolTypeUsecase = new ToolTypeUsecase(new FileToolTypeRepository("tooltype.json"));

            InitializeComponent();
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
            dataGridView1.DataSource = _ToolsUsecase.GetAllTools();
            dataGridViewMaterial.DataSource = _MaterialUsecase.GetAllMaterial();
            DrawingdataGridView.DataSource = _DrawingUsecase.GetAllDrawings();
            dataGridView2.DataSource = _WorkShopUsecase.GetAllWorkShop();
            WorkOrderdataGridView.DataSource = _WorkOrderUsecase.GetAllWorkOrders();
            toolTypeDataGridView.DataSource = _ToolTypeUsecase.GetAll();

            WorkOrderdataGridView.Columns[5].Visible = false;


        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить продукт".
        /// Открывает форму для добавления нового продукта.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (_OperationUsecase.GetAllOperations().Count() == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем экземпляр формы добавления продукта
            using (var addProductForm = new AddProductForm(_OperationUsecase))
            {

                // Отображаем форму как модальное окно
                DialogResult result = addProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ProductionUsecase.AddProduct(addProductForm.Result);
                    productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
                }
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить операцию".
        /// Открывает форму для добавления новой операции.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void AddOperationButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления операции
            using (var addOperationForm = new AddOperationForm(_ToolsUsecase))
            {
                // Отображаем форму как модальное окно
                DialogResult result = addOperationForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Добавляем операцию через Usecase
                    _OperationUsecase.AddOperation(addOperationForm.Result);

                    // Обновляем источник данных DataGridView
                    dataGridViewOperation.DataSource = null;
                    dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
                    dataGridViewOperation.Update();
                }
            }
        }


        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить инструмент".
        /// Открывает форму для добавления нового инструмента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void AddToolsButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления продукта
            using (var addToolsForm = new AddToolsForm(_ToolTypeUsecase))
            {

                // Отображаем форму как модальное окно
                DialogResult result = addToolsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ToolsUsecase.AddTools(addToolsForm.Result);

                    // Обновляем источник данных DataGridView
                    dataGridView1.DataSource = null; // Сбрасываем источник данных
                    dataGridView1.DataSource = _ToolsUsecase.GetAllTools();
                    dataGridView1.Update();
                }
            }
        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            int Id = (int)productsDataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _ProductionUsecase.DeleteProduct(Id);

            productsDataGridView.DataSource = null;
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            productsDataGridView.Update();
        }

        private void DeleteToolsButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного инструмента или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _ToolsUsecase.DeleteTools(Id);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _ToolsUsecase.GetAllTools();
            dataGridView1.Update();
        }


        private void buttonDeleteMaterial_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterial.CurrentRow == null || dataGridViewMaterial.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного материала или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridViewMaterial.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _MaterialUsecase.DeleteMaterial(Id);
            dataGridViewMaterial.DataSource = null; // Сбрасываем источник данных
            dataGridViewMaterial.DataSource = _MaterialUsecase.GetAllMaterial();
            dataGridViewMaterial.Update();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {

            // Создаем экземпляр формы добавления продукта
            using (var addMaterialForm = new AddMaterialForm())
            {

                // Отображаем форму как модальное окно
                DialogResult result = addMaterialForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _MaterialUsecase.AddMaterial(addMaterialForm.Result);

                    // Обновляем источник данных DataGridView
                    dataGridViewMaterial.DataSource = null; // Сбрасываем источник данных
                    dataGridViewMaterial.DataSource = _MaterialUsecase.GetAllMaterial();
                    dataGridViewMaterial.Update();
                }
            }
        }

        private void Drawingbutton1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления продукта
            using (var addDrawingForm = new AddDrawingForm())
            {

                // Отображаем форму как модальное окно
                DialogResult result = addDrawingForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _DrawingUsecase.AddDrawing(addDrawingForm.Result);

                    // Обновляем источник данных DataGridView
                    DrawingdataGridView.DataSource = null; // Сбрасываем источник данных
                    DrawingdataGridView.DataSource = _DrawingUsecase.GetAllDrawings();
                    DrawingdataGridView.Update();
                }
            }
        }

        private void Drawingbutton2_Click(object sender, EventArgs e)
        {
            if (DrawingdataGridView.CurrentRow == null || DrawingdataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного чертежа или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)DrawingdataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _DrawingUsecase.DeleteDrawing(Id);

            DrawingdataGridView.DataSource = null;
            DrawingdataGridView.DataSource = _DrawingUsecase.GetAllDrawings();
            DrawingdataGridView.Update();
        }

        private void WorkShopbutton1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления операции
            using (var addWorkShopForm = new AddWorkShopForm())
            {
                // Отображаем форму как модальное окно
                DialogResult result = addWorkShopForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Добавляем операцию через Usecase
                    _WorkShopUsecase.AddWorkShop(addWorkShopForm.Result);

                    // Обновляем источник данных DataGridView
                    dataGridView2.DataSource = null; // Сбрасываем источник данных
                    dataGridView2.DataSource = _WorkShopUsecase.GetAllWorkShop(); // Привязываем обновленные данные
                    dataGridView2.Update();
                }
            }
        }

        private void WorkShopbutton2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного цеха или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridView2.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _WorkShopUsecase.DeleteWorkShop(Id);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _WorkShopUsecase.GetAllWorkShop();
            dataGridView2.Update();
        }

        private void WorkOrderbutton2_Click(object sender, EventArgs e)
        {
            if (WorkOrderdataGridView.CurrentRow == null || WorkOrderdataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного цеха или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)WorkOrderdataGridView.CurrentRow.Cells[0].Value;
            _WorkOrderUsecase.DeleteWorkOrder(Id);

            WorkOrderdataGridView.DataSource = null;
            WorkOrderdataGridView.DataSource = _WorkOrderUsecase.GetAllWorkOrders();
            WorkOrderdataGridView.Update();
        }

        private void WorkOrderbutton1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления продукта
            using (var addWorkOrderForm = new AddWorkOrderForm(_ProductionUsecase))
            {

                // Отображаем форму как модальное окно
                DialogResult result = addWorkOrderForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _WorkOrderUsecase.AddWorkOrder(addWorkOrderForm.Result);
                    WorkOrderdataGridView.DataSource = null;
                    WorkOrderdataGridView.DataSource = _WorkOrderUsecase.GetAllWorkOrders();
                    WorkOrderdataGridView.Update();
                }
            }
        }

        private void addToolTypeButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления продукта
            using (var addToolTypeForm = new AddToolType())
            {

                // Отображаем форму как модальное окно
                DialogResult result = addToolTypeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ToolTypeUsecase.Add(addToolTypeForm.Result);
                    toolTypeDataGridView.DataSource = null;
                    toolTypeDataGridView.DataSource = _ToolTypeUsecase.GetAll();
                    toolTypeDataGridView.Update();
                }
            }
        }

        private void deleteToolTypeButton_Click(object sender, EventArgs e)
        {
            if (toolTypeDataGridView.CurrentRow == null || toolTypeDataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного Инструмента или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)toolTypeDataGridView.CurrentRow.Cells[0].Value;
            _ToolTypeUsecase.Delete(Id);

            toolTypeDataGridView.DataSource = null;
            toolTypeDataGridView.DataSource = _ToolTypeUsecase.GetAll();
            toolTypeDataGridView.Update();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow == null || productsDataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного продукта или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)productsDataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);

            _ProductionUsecase.DeleteProduct(Id);

            productsDataGridView.DataSource = null;
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            productsDataGridView.Update();
        }

        private void DeleteOperationButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewOperation.CurrentRow == null || dataGridViewOperation.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранной операции или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridViewOperation.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _OperationUsecase.DeleteOperation(Id);

            dataGridViewOperation.DataSource = null;
            dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
            dataGridViewOperation.Update();
        }
        private void EditProductButton_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow == null || productsDataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного продукта или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_OperationUsecase.GetAllOperations().Count() == 0)
            {
                MessageBox.Show("Добавьте хотя бы одну операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)productsDataGridView.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления продукта
            var product = _ProductionUsecase.GetProductById(Id);

            using (var addProductForm = new AddProductForm(_OperationUsecase, product))
            {
                // Отображаем форму как модальное окно
                DialogResult result = addProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ProductionUsecase.UpdateProduct(addProductForm.Result);
                    productsDataGridView.DataSource = null;
                    productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
                    productsDataGridView.Update();
                }
            }
        }

        private void EditOperationButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewOperation.CurrentRow == null || dataGridViewOperation.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранной операции или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_ToolsUsecase.GetAllTools().Count() == 0)
            {
                MessageBox.Show("Добавьте хотя бы однин инструмент.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridViewOperation.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления продукта
            var operation = _OperationUsecase.GetOperationById(Id);

            using (var addProductForm = new AddOperationForm(_ToolsUsecase, operation))
            {
                // Отображаем форму как модальное окно
                DialogResult result = addProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _OperationUsecase.UpdateOperation(addProductForm.Result);
                    dataGridViewOperation.DataSource = null;
                    dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
                    dataGridViewOperation.Update();
                }
            }
        }

        private void EditMaterialButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMaterial.CurrentRow == null || dataGridViewMaterial.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного материала или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridViewMaterial.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления продукта
            var material = _MaterialUsecase.GetMaterialById(Id);

            using (var addProductForm = new AddMaterialForm(material))
            {
                // Отображаем форму как модальное окно
                DialogResult result = addProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _MaterialUsecase.UpdateMaterial(addProductForm.Result);
                    dataGridViewMaterial.DataSource = null;
                    dataGridViewMaterial.DataSource = _MaterialUsecase.GetAllMaterial();
                    dataGridViewMaterial.Update();
                }
            }
        }

        private void EditWorkShopButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного типа инструмента или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridView2.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления типа инструмента
            var workshop = _WorkShopUsecase.GetWorkShopById(Id);

            using (var addworkshopform = new AddWorkShopForm(_WorkShopUsecase, workshop))
            {
                // Отображаем форму как модальное окно
                DialogResult result = addworkshopform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _WorkShopUsecase.UpdateWorkShop(addworkshopform.Result);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = _WorkShopUsecase.GetAllWorkShop();
                    dataGridView2.Update();
                }
            }

        }

        private void EditToolTypeButton_Click(object sender, EventArgs e)
        {

            if (toolTypeDataGridView.CurrentRow == null || toolTypeDataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного типа инструмента или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)toolTypeDataGridView.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления типа инструмента
            var tooltype = _ToolTypeUsecase.GetById(Id);

            using (var addtoolTypeform = new AddToolType(_ToolTypeUsecase, tooltype))
            {
                // Отображаем форму как модальное окно
                DialogResult result = addtoolTypeform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ToolTypeUsecase.Update(addtoolTypeform.Result);
                    toolTypeDataGridView.DataSource = null;
                    toolTypeDataGridView.DataSource = _ToolTypeUsecase.GetAll();
                    toolTypeDataGridView.Update();
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditWorkOrderButton_Click(object sender, EventArgs e)
        {


            if (WorkOrderdataGridView.CurrentRow == null || WorkOrderdataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного наряда или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)WorkOrderdataGridView.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления типа инструмента
            var workorder = _WorkOrderUsecase.GetWorkOrderById(Id);

            using (var workorderTypeform = new AddWorkOrderForm(_WorkOrderUsecase, _ProductionUsecase, workorder))
            {
                // Отображаем форму как модальное окно
                DialogResult result = workorderTypeform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _WorkOrderUsecase.UpdateWorkOrder(workorderTypeform.Result);
                    WorkOrderdataGridView.DataSource = null;
                    WorkOrderdataGridView.DataSource = _WorkOrderUsecase.GetAllWorkOrders();
                    WorkOrderdataGridView.Update();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (DrawingdataGridView.CurrentRow == null || DrawingdataGridView.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного чертежа или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)DrawingdataGridView.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления типа инструмента
            var drawing = _DrawingUsecase.GetDrawingById(Id);

            using (var drawingTypeform = new AddDrawingForm(_DrawingUsecase, drawing))
            {
                // Отображаем форму как модальное окно
                DialogResult result = drawingTypeform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _DrawingUsecase.UpdateDrawing(drawingTypeform.Result);
                    DrawingdataGridView.DataSource = null;
                    DrawingdataGridView.DataSource = _DrawingUsecase.GetAllDrawings();
                    DrawingdataGridView.Update();
                }
            }

        }

        private void EditToolButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Ошибка: Нет выбранного инструмента или хранилище пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            // Создаем экземпляр формы добавления типа инструмента
            var tool = _ToolsUsecase.GetToolsById(Id);

            using (var toolTypeform = new AddToolsForm(_ToolsUsecase, tool,_ToolTypeUsecase))
            {
                // Отображаем форму как модальное окно
                DialogResult result = toolTypeform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ToolsUsecase.UpdateTools(toolTypeform.Result);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _ToolsUsecase.GetAllTools();
                    dataGridView1.Update();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}