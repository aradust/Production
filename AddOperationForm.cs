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
            // Получаем данные из текстовых полей
            string operationName_1 = OperationNameTextBox.Text?.Trim();
            string operationName_2 = OperationtextBox2.Text?.Trim();

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(operationName_1))
            {
                MessageBox.Show("Введите название операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(operationName_2))
            {
                MessageBox.Show("Введите описание операции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что продолжительность введена корректно
            if (!TimeSpan.TryParse(OperationtextBox3.Text, out TimeSpan operationDuration) || operationDuration <= TimeSpan.Zero)
            {
                MessageBox.Show("Введите корректную продолжительность операции (формат: hh:mm:ss).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(operationName_1, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(operationName_2, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Описание операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новую операцию с указанными данными
            Result = new Operation(operationName_1)
            {
                Description = operationName_2,
                AverageDuration = operationDuration
            };

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Операция '{Result.Name}' успешно добавлена в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            OperationNameTextBox.Clear();
            OperationtextBox2.Clear();
            OperationtextBox3.Clear();

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

        private void DrawingsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddOperationForm_Load_1(object sender, EventArgs e)
        {

        }

        private void OperatopntextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
