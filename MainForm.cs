using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
       
        public MainForm()
        {
            _ProductionUsecase = new ProductionUsecase(new FileProductRepository("products.json"));
            _OperationUsecase = new OperationUsecase(new FileOperationRepository("operations.json"));
            _ToolsUsecase = new ToolsUsecase(new FileToolsRepository("tools.json"));
            _MaterialUsecase = new MaterialUsecase(new FileMaterialRepository("material.json"));
            InitializeComponent();
            productsInMemoryDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
            dataGridView1.DataSource =_ToolsUsecase.GetAllTools();
            dataGridViewMaterial.DataSource =_MaterialUsecase.GetAllMaterial();
        }
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
                    productsInMemoryDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
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

       

        /// <summary>
        /// Обработчик события для вкладки "Продукты".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void tabPage1_Click(object sender, EventArgs e)
        {
            // Логика для обработки клика по вкладке Продукты (если необходимо)
        }

        /// <summary>
        /// Обработчик события для вкладки "Операции".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void tabPage2_Click(object sender, EventArgs e)
        {
            // Логика для обработки клика по вкладке Операции (если необходимо)
        }

        /// <summary>
        /// Обработчик события для вкладки "Инструменты".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void tabPage3_Click(object sender, EventArgs e)
        {
            // Логика для обработки клика по вкладке Инструменты (если необходимо)
        }

        /// <summary>
        /// Обработчик события для панели <see cref="splitContainer2_Panel2"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Логика для обработки рисования на панели (если необходимо)
        }

        /// <summary>
        /// Обработчик события для панели <see cref="splitContainer2_Panel1"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Логика для обработки рисования на панели (если необходимо)
        }

        /// <summary>
        /// Обработчик события для панели <see cref="splitContainer3_Panel1"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Логика для обработки рисования на панели (если необходимо)
        }

        private void dataGridViewMemory1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsInMemoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductDeleteButton_Click(object sender, EventArgs e)
        {
            
       
            
                int Id = (int)productsInMemoryDataGridView.CurrentRow.Cells[0].Value;
                Console.WriteLine(Id);
                _ProductionUsecase.DeleteProduct(Id);
                productsInMemoryDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            
          //  else { throw new ArgumentNullException("Список продуктов пуст"); }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOperation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OperationButton_2_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridViewOperation.CurrentRow.Cells[0].Value;
            Console.WriteLine(Id);
            _OperationUsecase.DeleteOperation(Id);
            dataGridViewOperation.DataSource = _OperationUsecase.GetAllOperations();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteToolsButton_Click(object sender, EventArgs e)
        {
            int Id = (int)dataGridView1.CurrentRow.Cells[2].Value;
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
    }
}
