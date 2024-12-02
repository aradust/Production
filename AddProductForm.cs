using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    public partial class AddProductForm : Form
    {

        public AddProductForm()
        {
            InitializeComponent();
            AddProductErrorProvider = new ErrorProvider();
            ProductNameTextBox.Validating += ProductNameTextBox_Validating;
        }

        private void ProductNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = ProductNameTextBox.Text;

            // Регулярное выражение для проверки наличия спецсимволов
            if (Regex.IsMatch(input, @"[^a-zA-Z0-9\s]"))
            {
                AddProductErrorProvider.SetError(ProductNameTextBox, "Поле не должно содержать специальных символов.");
                e.Cancel = true; // Отменяем потерю фокуса
            }
            else
            {
                AddProductErrorProvider.SetError(ProductNameTextBox, string.Empty); // Убираем ошибку
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmAddProductButton_Click(object sender, EventArgs e)
        {

        }
    }
}
