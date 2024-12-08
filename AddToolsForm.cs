using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace Production
{
    /// <summary>

    /// Форма для добавления нового продукта в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddToolsForm : Form
    {
        /// <summary>
        /// Экземпляр репозитория для управления продуктами.
        /// </summary>
        private readonly FileToolsRepository _repository;

        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddProductForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddToolsForm()
        {
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButton2.Click += ConfirmButton2_Click;

            // Инициализация репозитория с указанием файла для хранения данных
            _repository = new FileToolsRepository("tools.json");
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить".
        /// Проверяет ввод данных, добавляет новый продукт в репозиторий и сохраняет его в JSON-файл.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные о событии.</param>
        private void ConfirmButton2_Click(object sender, EventArgs e)
        {
            // Получаем название продукта из текстового поля
            string toolsName = ToolsNameTextBox.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(toolsName))
            {
                MessageBox.Show("Введите тип инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый продукт с указанным названием
            var tools = new Tools(toolsName);

            // Добавляем продукт в репозиторий
            _repository.Add(tools);

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Инструмент '{tools.Name}' успешно добавлен в файл",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поле ввода
            ToolsNameTextBox.Clear();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}