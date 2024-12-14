﻿using System;
using System.Collections.Generic;
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
        private List<Tools> toolsList = new List<Tools>();


        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить продукт".
        /// Открывает форму для добавления нового продукта.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления продукта
            using (var addProductForm = new AddProductForm(_OperationUsecase))
            {

                // Отображаем форму как модальное окно
                DialogResult result = addProductForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ProductionUsecase.AddProduct(addProductForm.Result);
                    productsDataGridView.DataSource = null;
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
            using (var addOperationForm = new AddOperationForm())
            {
                // Отображаем форму как модальное окно
                DialogResult result = addOperationForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Добавляем операцию через Usecase
                    _OperationUsecase.AddOperation(addOperationForm.Result);

                    // Обновляем источник данных DataGridView
                    dataGridViewOperation.DataSource = null; // Сбрасываем источник данных
                    dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations(); // Привязываем обновленные данные
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
            using (var addToolsForm = new AddToolsForm())
            {

                // Отображаем форму как модальное окно
                DialogResult result = addToolsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _ToolsUsecase.AddTools(addToolsForm.Result);

                    // Обновляем источник данных DataGridView
                    dataGridView1.DataSource = null; // Сбрасываем источник данных
                    dataGridView1.DataSource = _ToolsUsecase.GetAllTools();
                }
            }
        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            int Id = (int)productsDataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _ProductionUsecase.DeleteProduct(Id);
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
        }

        private void OperationButton_2_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridViewOperation.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _OperationUsecase.DeleteOperation(Id);
            dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
        }

        private void DeleteToolsButton_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _ToolsUsecase.DeleteTools(Id);
            dataGridView1.DataSource = _ToolsUsecase.GetAllTools();
        }


        private void buttonDeleteMaterial_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridViewMaterial.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _MaterialUsecase.DeleteMaterial(Id);
            dataGridViewMaterial.DataSource = _MaterialUsecase.GetAllMaterial();
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
                }
            }
        }

        private void Drawingbutton2_Click(object sender, EventArgs e)
        {
            int Id = (int)DrawingdataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _DrawingUsecase.DeleteDrawing(Id);
            DrawingdataGridView.DataSource = _DrawingUsecase.GetAllDrawings();
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
                }
            }
        }

        private void WorkShopbutton2_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridView2.CurrentRow.Cells[1].Value;
            Console.WriteLine(Id);
            _WorkShopUsecase.DeleteWorkShop(Id);
            dataGridView2.DataSource = _WorkShopUsecase.GetAllWorkShop();
        }

        private void WorkOrderbutton2_Click(object sender, EventArgs e)
        {
            int Id = (int)WorkOrderdataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _WorkOrderUsecase.DeleteWorkOrder(Id);
            WorkOrderdataGridView.DataSource = _WorkOrderUsecase.GetAllWorkOrders();

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
                    WorkOrderdataGridView.DataSource = _WorkOrderUsecase.GetAllWorkOrders();
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
                    toolTypeDataGridView.DataSource = _ToolTypeUsecase.GetAll();
                }
            }
        }

        private void deleteToolTypeButton_Click(object sender, EventArgs e)
        {
            int Id = (int)toolTypeDataGridView.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _ToolTypeUsecase.Delete(Id);
            toolTypeDataGridView.DataSource = _ToolTypeUsecase.GetAll();
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
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
        }


        private void DeleteOperationButton_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridViewOperation.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _OperationUsecase.DeleteOperation(Id);
            dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WorkOrderdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}