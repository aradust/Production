using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

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
        {
            // Получаем данные из текстовых полей
            string toolsName = ToolsNameTextBox.Text;
            string description = ToolstextBox3.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(toolsName))
            {
                MessageBox.Show("Введите тип инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Введите описание инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем формат названия и описания
            if (!Regex.IsMatch(toolsName, @"^[a-zA-Zа-яА-Я0-9 ]+$"))
            {
                MessageBox.Show("Название инструмента может содержать только буквы, цифры и пробелы.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(description, @"^[a-zA-Zа-яА-Я0-9 ]+$"))
            {
                MessageBox.Show("Описание инструмента может содержать только буквы, цифры и пробелы.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем дату
            if (!DateTime.TryParse(ToolstextBox1.Text, out DateTime date) || date <= DateTime.MinValue)
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем количество
            if (!int.TryParse(ToolstextBox4.Text, out int quantityT) || quantityT <= 0)
            {
                MessageBox.Show("Введите корректное количество (выдано).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ToolstextBox5.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество (осталось).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем идентификаторы экземпляров
            var insid = new HashSet<int>();
            try
            {
                // Если пользователь ввел идентификаторы, проверяем их
                if (!string.IsNullOrWhiteSpace(ToolstextBox6.Text))
                {
                    foreach (var id in ToolstextBox6.Text.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (int.TryParse(id, out int parsedId))
                        {
                            insid.Add(parsedId);
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                }

                // Автоматическое добавление оставшихся идентификаторов
                int startId = insid.Count > 0 ? insid.Max() + 1 : 1;
                while (insid.Count < quantityT)
                {
                    insid.Add(startId++);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные идентификаторы экземпляров (через запятую, точку с запятой или пробел).",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый инструмент
            Result = new Tools(toolsName)
            {
                Name = toolsName,
                Description = description,
                Date = date,
                QuantityTake = quantityT,
                QuantityStay = quantity,
                InstanceId = insid.ToList()
            };

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Инструмент '{Result.Name}' успешно добавлен в систему.",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            ToolsNameTextBox.Clear();
            ToolstextBox3.Clear();
            ToolstextBox1.Clear();
            ToolstextBox4.Clear();
            ToolstextBox5.Clear();
            ToolstextBox6.Clear();

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

        private void ToolsButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolstextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Toolslabel5_Click(object sender, EventArgs e)
        {

        }

        private void ToolstextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Toolslabel4_Click(object sender, EventArgs e)
        {

        }

        private void ToolstextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Toolslabel3_Click(object sender, EventArgs e)
        {

        }

        private void ToolstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Toolslabel2_Click(object sender, EventArgs e)
        {

        }

        private void ToolsNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolsNameLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void Toolslabel6_Click(object sender, EventArgs e)
        {

        }

        private void ToolstextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
