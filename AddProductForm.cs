using System;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Форма для добавления нового продукта в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddProductForm : Form
    {
        /// <summary>
        /// Экземпляр репозитория для управления продуктами.
        /// </summary>
        private readonly FileProductRepository _repository;

        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddProductForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddProductForm()
        {
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButton.Click += ConfirmButton_Click;

            // Инициализация репозитория с указанием файла для хранения данных
            _repository = new FileProductRepository("products.json");
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить".
        /// Проверяет ввод данных, добавляет новый продукт в репозиторий и сохраняет его в JSON-файл.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // Получаем название продукта из текстового поля
            string productName = ProductNameTextBox.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Введите название продукта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый продукт с указанным названием
            var product = new Product(productName);

            // Добавляем продукт в репозиторий
            _repository.Add(product);

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Продукт '{product.Name}' успешно добавлен в файл",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поле ввода
            ProductNameTextBox.Clear();
        }
    }
}
