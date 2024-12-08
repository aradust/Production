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
        /// 
        private ProductionUsecase _ProductionUsecase;
        public MainForm()
        {
            _ProductionUsecase = new ProductionUsecase(new InMemoryProductRepository());

            // Пример данных, которые будут привязаны к DataGridView
            var products = new List<Product>
            {
                new Product(1, "Product1", DateTime.Today, 100),
                new Product(2, "Product1", DateTime.Today, 100),
                new Product(3, "Product1", DateTime.Today, 100),
                new Product(4, "Product1", DateTime.Today, 100)
            };
            foreach (var product in products)
            {
                _ProductionUsecase.AddProduct(product);
            }

            InitializeComponent();
            productsInMemoryDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
          
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
            using (var addProductForm = new AddProductForm())
            {
                // Отображаем форму как модальное окно
                addProductForm.ShowDialog();
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
            using (var addOperationForm = new AddOperationForm())
            {
                // Отображаем форму как модальное окно
                addOperationForm.ShowDialog();
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
            using (var addToolsForm = new AddToolsForm())
            {
                // Отображаем форму как модальное окно
                addToolsForm.ShowDialog();
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
    }
}
