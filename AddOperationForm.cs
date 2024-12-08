using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Форма для добавления нового продукта в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddOperationForm : Form
    {
        /// <summary>
        /// Экземпляр репозитория для управления продуктами.
        /// </summary>
        private readonly FileOperationRepository _repository;

        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddProductForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddOperationForm()
        {
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButton.Click += ConfirmButton_Click;

            // Инициализация репозитория с указанием файла для хранения данных
            _repository = new FileOperationRepository("operations.json");
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
            string operationName = OperationNameTextBox.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(operationName))
            {
                MessageBox.Show("Введите название операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый продукт с указанным названием
            var operation = new Operation(operationName);

            // Добавляем продукт в репозиторий
            _repository.Add(operation);

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Операция '{operation.Name}' успешно добавлена в файл",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поле ввода
            OperationNameTextBox.Clear();
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {

        }
    }
}

