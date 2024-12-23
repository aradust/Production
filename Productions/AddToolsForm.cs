using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Production.Usecase;

namespace Production
{

    public partial class AddToolsForm : Form
    {
        public Tools Result { get; set; } = new Tools { };
        private readonly ToolTypeUsecase _toolTypeUsecase;
        private readonly ToolsUsecase _ToolsUsecase;

        public AddToolsForm(ToolTypeUsecase _ToolTypeUsecase)
        {
            InitializeComponent();
            _toolTypeUsecase = _ToolTypeUsecase;

            // Привязка обработчика события нажатия кнопки
            ToolsButton.Click += ToolsButton_Click;
            foreach (var tool in _toolTypeUsecase.GetAll())
            {
                toolTypeListCheckBox.Items.Add($"{tool.Id.ToString()} - {tool.Name}");
            }
        }
        public AddToolsForm(ToolsUsecase usecase)
        {
            _ToolsUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ToolsButton.Click += ToolsButton_Click;

            foreach (var tool in _ToolsUsecase.GetAllTools())
            {
                toolTypeListCheckBox.Items.Add($"{tool.Id.ToString()} - {tool.Name}");
            }
        }

        public AddToolsForm(ToolsUsecase usecase, Tools tool,ToolTypeUsecase _toolTypeUsecase)
        {
            Result.Id = tool.Id;
            _ToolsUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ToolsButton.Click += ToolsButton_Click;
            ToolsNameTextBox.Text = tool.Name;
            ToolstextBox3.Text = tool.Description;
            ToolstextBox1.Text = tool.Date.ToString();

            foreach (var tooltype in _toolTypeUsecase.GetAll())
            {
                var index = toolTypeListCheckBox.Items.Add($"{tooltype.Id.ToString()} - {tooltype.Name}");
                if (tool.Tooltype.Select(o => o.Id).Contains(tooltype.Id))
                {
                    toolTypeListCheckBox.SetItemChecked(index, true);
                }
            }
        }

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


            if (!DateTime.TryParse(ToolstextBox1.Text, out DateTime date) || date <= DateTime.MinValue)
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранные операции
            var selectedToolType = new List<ToolType>();
            foreach (var item in toolTypeListCheckBox.CheckedItems)
            {
                // Разбиваем строку, чтобы извлечь ID и имя операции
                var parts = item.ToString().Split(new[] { '-' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && int.TryParse(parts[0], out int toolId))
                {
                    selectedToolType.Add(_toolTypeUsecase.GetById(toolId));
                }
            }

            if (selectedToolType.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один тип инструмента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            Result.Name = toolsName;
            Result.Description = description;
            Result.Date = date;
            Result.TypeId = selectedToolType[0].Id;
            


            MessageBox.Show($"Инструмент '{Result.Name}' успешно добавлен в систему.",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ToolsNameTextBox.Clear();
            ToolstextBox3.Clear();


            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddToolsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
