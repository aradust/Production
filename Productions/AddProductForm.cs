using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Форма для добавления нового продукта в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddProductForm : Form
    {
        public Product Result { get; set; } = new Product { };

        private readonly OperationUsecase _OperationUsecase;
        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddProductForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddProductForm(OperationUsecase usecase)
        {
            _OperationUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButton.Click += ConfirmButton_Click;

            foreach (var operation in _OperationUsecase.GetAllOperations())
            {
                DrawingsCheckedListBox.Items.Add($"{operation.Id.ToString()} - {operation.Name}");
            }
        }

        public AddProductForm(OperationUsecase usecase, Product product)
        {
            Result.Id = product.Id;
            _OperationUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButton.Click += ConfirmButton_Click;

            ProductNameTextBox.Text = product.Name;
            ProductCostTextBox.Text = product.Cost.ToString();

            foreach (var operation in _OperationUsecase.GetAllOperations())
            {
                var index = DrawingsCheckedListBox.Items.Add($"{operation.Id.ToString()} - {operation.Name}");
                if (product.Operations.Select(o => o.Id).Contains(operation.Id))
                {
                    DrawingsCheckedListBox.SetItemChecked(index, true);
                }
            }
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

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(productName, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название продукта может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем стоимость продукта из текстового поля
            if (!int.TryParse(ProductCostTextBox.Text, out int productCost) || productCost <= 0)
            {
                MessageBox.Show("Введите корректную стоимость продукта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранные операции
            var selectedOperations = new List<Operation>();
            foreach (var item in DrawingsCheckedListBox.CheckedItems)
            {
                // Разбиваем строку, чтобы извлечь ID и имя операции
                var parts = item.ToString().Split(new[] { '-' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && int.TryParse(parts[0], out int operationId))
                {
                    selectedOperations.Add(_OperationUsecase.GetOperationById(operationId));
                }
            }

            if (selectedOperations.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый продукт с указанным названием, стоимостью и выбранными операциями
            Result.Name = productName;
            Result.Cost = productCost;
            Result.Operations = selectedOperations;
            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Продукт '{Result.Name}' с ценой {Result.Cost} успешно добавлен.\nВыбранные операции:\n" +
                string.Join("\n", selectedOperations.Select(op => $"- {op.Name}")),
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            ProductNameTextBox.Clear();
            ProductCostTextBox.Clear();
            foreach (int index in DrawingsCheckedListBox.CheckedIndices)
            {
                DrawingsCheckedListBox.SetItemChecked(index, false);
            }

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
