using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    public partial class AddMaterialForm : Form
    {
        public Material Result { get; set; }
        public AddMaterialForm()
        {
            InitializeComponent();
            buttonMaterial.Click += buttonMaterial_Click;
        }

        private void buttonMaterial_Click(object sender, EventArgs e)
        {
            // Получаем название продукта из текстового поля
            string materialName = textBoxMaterial.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(materialName))
            {
                MessageBox.Show("Введите название материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(materialName, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Создаем новый продукт с указанным названием и стоимостью
            Result = new Material(materialName);


            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Материал '{Result.Name}' успешно добавлен в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            textBoxMaterial.Clear();


            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }



        private void AddMaterialForm_Load(object sender, EventArgs e)
        {

        }
        private void labelMaterial_Click(object sender, EventArgs e)
        {

        }

       

        

       
    }
}




     