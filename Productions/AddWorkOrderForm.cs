using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Production
{
    public partial class AddWorkOrderForm : Form
    {
        public WorkOrder Result { get; set; }
        /// <summary>
        /// Экземпляр репозитория для управления продуктами.
        /// </summary>
        private readonly FileWorkOrderRepository _repository;

        private readonly ProductionUsecase _ProductUsecase;
        public AddWorkOrderForm(ProductionUsecase usecase)
        {
            _ProductUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            button1WorkOrder.Click += button1WorkOrder_Click;

            foreach (var product in _ProductUsecase.GetAllProducts())
            {
                CheckedListBoxWorkOrder.Items.Add($"{product.Id} - {product.Name}");
            }

            CheckedListBoxWorkOrder.ItemCheck += CheckedListBoxWorkOrder_ItemCheck;
        }

        private void CheckedListBoxWorkOrder_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Оставляем выбранным только один элемент
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < CheckedListBoxWorkOrder.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        CheckedListBoxWorkOrder.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void CheckedListBoxWorkOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddWorkOrderForm_Load(object sender, EventArgs e)
        {
        }

        private void textBox3WorkShop_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3WorkShop_Click(object sender, EventArgs e)
        {
        }

        private void textBox2WorkShop_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2WorkShop_Click(object sender, EventArgs e)
        {
        }

        private void textBox1WorkShop_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1WorkShop_Click(object sender, EventArgs e)
        {
        }

        private void button1WorkOrder_Click(object sender, EventArgs e)
        {
            // Получаем дату оформления наряда
            if (!DateTime.TryParse(textBox1WorkShop.Text, out DateTime date) || date <= DateTime.MinValue)
            {
                MessageBox.Show("Введите корректную дату оформления наряда (формат: hh:mm:ss).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(textBox2WorkShop.Text, out DateTime deadline) || deadline <= date)
            {
                MessageBox.Show("Введите корректный срок выполнения наряда (он должен быть позже даты оформления).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3WorkShop.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество продуктов (число больше нуля).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, выбран ли продукт
            if (CheckedListBoxWorkOrder.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите один продукт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckedListBoxWorkOrder.CheckedItems.Count > 1)
            {
                MessageBox.Show("Можно выбрать только один продукт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранный продукт
            var selectedItem = CheckedListBoxWorkOrder.CheckedItems[0].ToString();
            var parts = selectedItem.Split(new[] { '-' }, 2, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2 || !int.TryParse(parts[0].Trim(), out int productId))
            {
                MessageBox.Show("Не удалось получить информацию о выбранном продукте.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = _ProductUsecase.GetProductById(productId);
            if (selectedProduct == null)
            {
                MessageBox.Show("Выбранный продукт не найден в системе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем WorkOrder
            Result = new WorkOrder
            {
                ProductId = selectedProduct.Id,
                DateIssued = date,
                DeadLine = deadline,
                QuantityRequired = quantity,
                Products = new List<Product> { selectedProduct },
                
            };

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Наряд успешно добавлен. Продукт: {selectedProduct.Name}, Дата: {date}, Срок: {deadline}, Количество: {quantity}",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очистка формы
            textBox1WorkShop.Clear();
            textBox2WorkShop.Clear();
            textBox3WorkShop.Clear();
            foreach (int index in CheckedListBoxWorkOrder.CheckedIndices)
            {
                CheckedListBoxWorkOrder.SetItemChecked(index, false);
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
