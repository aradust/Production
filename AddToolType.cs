using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    public partial class AddToolType: Form
    {
        public ToolType Result { get; set; }

        public AddToolType()
        {
            InitializeComponent();
            confirmAddToolTypeButton.Click += ButtonConfirm_Click;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string toolTypeName = addToolTypeNameTextBox.Text;
            string toolTypeDescription = addToolTypeDescriptionTextBox.Text;

            // Проверяем, что поля заполнены
            if (string.IsNullOrWhiteSpace(toolTypeName))
            {
                MessageBox.Show("Введите название типа инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(toolTypeDescription))
            {
                MessageBox.Show("Введите описание типа инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем корректность введенных данных
            if (!Regex.IsMatch(toolTypeName, @"^[a-zA-Zа-яА-Я0-9\s]+$"))
            {
                MessageBox.Show("Название может содержать только буквы, цифры и пробелы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(toolTypeDescription, @"^[a-zA-Zа-яА-Я0-9\s]+$"))
            {
                MessageBox.Show("Описание может содержать только буквы, цифры и пробелы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый объект ToolType
            Result = new ToolType
            {
                Name = toolTypeName,
                Description = toolTypeDescription
            };

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Тип инструмента '{Result.Name}' успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            addToolTypeNameTextBox.Clear();
            addToolTypeDescriptionTextBox.Clear();

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
