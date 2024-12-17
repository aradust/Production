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
        public Operation Result { get; set; } = new Operation();

        private readonly ToolsUsecase _ToolsUsecase;
        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddOperationForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddOperationForm(ToolsUsecase toolsUsecase)
        {
            InitializeComponent();
            _ToolsUsecase = toolsUsecase;
            foreach (var tool in _ToolsUsecase.GetAllTools())
            {
                ToolsCheckedListBox.Items.Add($"{tool.Id.ToString()} - {tool.Name}");
            }

            // Привязка обработчика события нажатия кнопки
            ConfirmButtonOperation.Click += ConfirmButtonOperation_Click;
        }

        public AddOperationForm(ToolsUsecase toolsUsecase, Operation operation)
        {
            InitializeComponent();
            _ToolsUsecase = toolsUsecase;
            Result.Id = operation.Id; 
            foreach (var tool in _ToolsUsecase.GetAllTools())
            {
                var index = ToolsCheckedListBox.Items.Add($"{tool.Id.ToString()} - {tool.Name}");
                if (operation.Tools.Select(t => t.Id).Contains(tool.Id))
                {
                    ToolsCheckedListBox.SetItemChecked(index, true);
                }
            }
            OperationNameTextBox.Text = operation.Name;
            OperationtextBox2.Text = operation.Description;
            durationMaskedTextBox.Text = operation.AverageDuration.ToString();

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
            if (!TimeSpan.TryParse(durationMaskedTextBox.Text, out TimeSpan operationDuration) || operationDuration <= TimeSpan.Zero)
            {
                MessageBox.Show("Введите корректную продолжительность операции (формат: hh:mm).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Получаем выбранные операции
            var selectedTools = new List<Tools>();
            foreach (var item in ToolsCheckedListBox.CheckedItems)
            {
                // Разбиваем строку, чтобы извлечь ID и имя операции
                var parts = item.ToString().Split(new[] { '-' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && int.TryParse(parts[0], out int toolId))
                {
                    selectedTools.Add(_ToolsUsecase.GetToolsById(toolId));
                }
            }

            if (selectedTools.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Создаем новую операцию с указанными данными
            Result.Name = operationName_1;
            Result.Description = operationName_2;
            Result.AverageDuration = operationDuration;
            Result.Tools = selectedTools;

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Операция '{Result.Name}' успешно добавлена в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            OperationNameTextBox.Clear();
            OperationtextBox2.Clear();
            durationMaskedTextBox.Clear();

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
