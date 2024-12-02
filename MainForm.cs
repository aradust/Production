using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Production
{
    public partial class MainForm : Form
    {
        private ProductionUsecase _ProductionUsecase;
        private OperationUsecase _OperationUsecase;
        private ToolsUsecase _ToolsUseCase;
        public MainForm()
        {
            _ProductionUsecase = new ProductionUsecase(new InMemoryProductRepository());
            _OperationUsecase = new OperationUsecase(new InMemoryOperationRepository());
            _ToolsUseCase = new ToolsUsecase(new InMemoryToolsRepository());

            // Пример данных, которые будут привязаны к DataGridView
            var products = new List<Product>

            {
                new Product(1, "Product1", DateTime.Today, 100),
                new Product(2, "Product2", DateTime.Today, 100),
                new Product(3, "Product3", DateTime.Today, 100),
                new Product(4, "Product4", DateTime.Today, 100)
            };

            foreach (var product in products)
            {
                _ProductionUsecase.AddProduct(product);
            }
            var operations = new List<Operation>
            {
                new Operation(1,"okun",1,1,"okun",1)
            };
            foreach (var operation in operations)
            {
                _OperationUsecase.AddOperation(operation);
            }



            InitializeComponent();
            productsDataGridView.DataSource = _ProductionUsecase.GetAllProducts();
            dataGridView1.DataSource = _ProductionUsecase.GetAllProducts();
           // operationsDataGridView.DataSource = _OperationUsecase.GetAllOperation();
            //dataGridView.DataSource = _OperationUsecase.GetAllOperation();
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
            using (var inputForm = new AddProductForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем данные из формы и добавляем в контейнер
                    //MyStruct data = inputForm.Result;
                    //container.Add(data);

                   // MessageBox.Show($"Добавлен элемент: {data.Name}, {data.Age} лет.");
                }
            }
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

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
