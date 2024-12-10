using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Форма для добавления новой операции в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddOperationForm : Form
    {
        public Operation Result { get; set; }

        private readonly OperationUsecase _OperationUsecase;
        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddOperationForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddOperationForm()
        {
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButtonOperation.Click += ConfirmButtonOperation_Click;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить".
        /// Проверяет ввод данных, добавляет новую операцию в репозиторий и сохраняет её в JSON-файл.
        /// </summary>
        private void ConfirmButtonOperation_Click(object sender, EventArgs e)
        {
            // Получаем название продукта из текстового поля
            string operationName = OperationNameTextBox.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(operationName))
            {
                MessageBox.Show("Введите название операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(operationName, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Создаем новый продукт с указанным названием и стоимостью
            Result = new Operation(operationName);
            

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Операция '{Result.Name}' успешно добавлена в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            // Создаем новый продукт с указанным названием
            Result = new Operation(operationName);

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Операция '{Result.Name}' успешно добавлена в файл",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            // Очищаем поле ввода
            OperationNameTextBox.Clear();
            

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {
            // Логика загрузки формы (если требуется)
        }

        private void OperationNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
