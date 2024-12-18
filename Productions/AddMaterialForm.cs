using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production
{
    public partial class AddMaterialForm : Form
    {
        public Material Result { get; set; } = new Material();
        public AddMaterialForm()
        {
            InitializeComponent();
            buttonMaterial.Click += buttonMaterial_Click;
        }
        public AddMaterialForm(Material material)
        {
            InitializeComponent();

            Result.Id = material.Id;
            textBoxMaterial.Text = material.Name;
            MaterialtextBox2.Text = material.Description;
            checkBox1.Checked = material.IsConsumable;

            buttonMaterial.Click += buttonMaterial_Click;
        }


        private void buttonMaterial_Click(object sender, EventArgs e)
        {
            // Получаем название продукта из текстового поля
            string materialName_1 = textBoxMaterial.Text;
            string materialName_2 = MaterialtextBox2.Text;

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(materialName_1))
            {
                MessageBox.Show("Введите название материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(materialName_2))
            {
                MessageBox.Show("Введите описание материала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(materialName_1, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название материала может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(materialName_2, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Описание материала может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Создаем новый продукт с указанным названием и стоимостью
            Result.Name = materialName_1;
            Result.Description = materialName_2;
            Result.IsConsumable = checkBox1.Checked;


            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Материал '{Result.Name}' успешно добавлен в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поля ввода
            textBoxMaterial.Clear();
            MaterialtextBox2.Clear();
            checkBox1.Checked =false;


            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}




     