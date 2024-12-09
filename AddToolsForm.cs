using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Форма для добавления новой операции в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddToolsForm : Form
    {
        public Tools Result { get; set; }
        private readonly FileToolsRepository _repository;

        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddOperationForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddToolsForm()
        {
            InitializeComponent();

            // Инициализация репозитория
            _repository = new FileToolsRepository("tools.json");

            // Привязка обработчика события нажатия кнопки
            ToolsButton.Click += ToolsButton_Click;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить".
        /// Проверяет ввод данных, добавляет новую операцию в репозиторий и сохраняет её в JSON-файл.
        /// </summary>
        private void ToolsButton_Click(object sender, EventArgs e)
        {// Получаем название продукта из текстового поля
            string ToolsName = ToolsNameTextBox.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(ToolsName))
            {
                MessageBox.Show("Введите название инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(ToolsName, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название инструмента может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Создаем новый продукт с указанным названием и стоимостью
            Result = new Tools(ToolsName);


            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Инструмент '{Result.Name}' успешно добавлен в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            ToolsNameTextBox.Clear();


            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddToolsForm_Load(object sender, EventArgs e)
        {
            // Логика загрузки формы (если требуется)
        }

        private void ToolsNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
