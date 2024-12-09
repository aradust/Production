using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Форма для добавления нового продукта в репозиторий с сохранением в JSON-файл.
    /// </summary>
    public partial class AddProductForm : Form
    {
        public Product Result { get; set; }
        /// <summary>
        /// Экземпляр репозитория для управления продуктами.
        /// </summary>
        private readonly FileProductRepository _repository;

        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="AddProductForm"/>.
        /// Создает репозиторий с указанным путем к JSON-файлу и привязывает обработчики событий.
        /// </summary>
        public AddProductForm()
        {
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            ConfirmButton.Click += ConfirmButton_Click;

            // Инициализация репозитория, если нужно
            // _repository = new FileProductRepository("products.json");
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

        // Создаем новый продукт с указанным названием и стоимостью
        Result = new Product(productName)
        {
            Cost = productCost
        };

        // Уведомляем пользователя об успешном добавлении
        MessageBox.Show($"Продукт '{Result.Name}' с ценой {Result.Cost} успешно добавлен в систему",
            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Очищаем поля ввода
        ProductNameTextBox.Clear();
        ProductCostTextBox.Clear();

        // Закрываем форму с результатом OK
        DialogResult = DialogResult.OK;
        Close();
    }


    private void AddProductForm_Load(object sender, EventArgs e)
        {
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
