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
        public partial class AddWorkShopForm : Form
        {
            public WorkShop Result { get; set; }
            public AddWorkShopForm()
            {
                InitializeComponent();
                WSbutton.Click += WSbutton_Click;
            }


            private void AddWorkShopFormcs_Load(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void WSbutton_Click(object sender, EventArgs e)
            {

                // Получаем название продукта из текстового поля
                string WorkShopName = textBox1.Text;


                // Проверяем, что название введено
                if (string.IsNullOrWhiteSpace(WorkShopName))
                {
                    MessageBox.Show("Введите название цеха.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                // Проверяем, что название состоит только из русских/английских букв и циф
                if (!Regex.IsMatch(WorkShopName, @"^[a-zA-Zа-яА-Я0-9]+$"))
                {
                    MessageBox.Show("Название цеха может содержать только русские/английские буквы и цифры.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }


                // Создаем новый продукт с указанным названием и стоимостью
                Result = new WorkShop(WorkShopName);

                // Уведомляем пользователя об успешном добавлении
                MessageBox.Show($"Цех '{Result.Name}' успешно добавлен в систему",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля ввода
                DialogResult = DialogResult.OK;
                textBox1.Clear();


                // Закрываем форму с результатом OK
                
                Close();
            }
        }
    }
