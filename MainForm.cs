using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Production
{
    public partial class MainForm : Form
    {
        private ProductionUsecase _ProductionUsecase;
        public MainForm()
        {
            _ProductionUsecase = new ProductionUsecase(new InMemoryProductRepository());

            // Пример данных, которые будут привязаны к DataGridView
            var products = new List<Product>
            {
                new Product(1, "Product1", DateTime.Today, 100),
                new Product(1, "Product1", DateTime.Today, 100),
                new Product(1, "Product1", DateTime.Today, 100),
                new Product(1, "Product1", DateTime.Today, 100)
            };
            foreach (var product in products)
            {
                _ProductionUsecase.AddProduct(product);
            }

            InitializeComponent();
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            dataGridView1.DataSource = _ProductionUsecase.GetAllProducts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // Создаём экземпляр формы AddProductForm
            AddProductForm addProductForm = new AddProductForm();

            // Открываем форму как диалоговое окно
            addProductForm.ShowDialog();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void addProductButton1_Click(object sender, EventArgs e)
        {
            // Создаём экземпляр формы AddProductForm
            AddProductForm addProductForm = new AddProductForm();

            // Открываем форму как диалоговое окно
            addProductForm.ShowDialog();
            /// .... 
            /// newProduct(); _ProductUsecase.Add(newProduct);
        }
    }
}
