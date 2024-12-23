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
    public partial class AddDrawingForm : Form
    {
        public Drawing Result { get; set; } = new Drawing { };
        private readonly DrawingUsecase _DrawingUsecase;

        public AddDrawingForm()
        {
            InitializeComponent();
            Drawingbutton.Click += Drawingbutton_Click;
        }
        public AddDrawingForm(DrawingUsecase usecase)
        {
            _DrawingUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            Drawingbutton.Click += Drawingbutton_Click;
        }
        public AddDrawingForm(DrawingUsecase usecase, Drawing drawing)
        {
            Result.Id = drawing.Id;
            //_OperationUsecase = usecase;
            InitializeComponent();

            // Привязка обработчика события нажатия кнопки
            Drawingbutton.Click += Drawingbutton_Click;
            DrawingtextBox1.Text = drawing.Name;
            DrawingtextBox2.Text = drawing.Description;
            DrawingtextBox3.Text = drawing.Specifications;
           
        }

        private void AddDrawingForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Drawinglabel3_Click(object sender, EventArgs e)
        {

        }

        private void DrawingtextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrawingtextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Drawinglabel2_Click(object sender, EventArgs e)
        {

        }

        private void Drawingslabel1_Click(object sender, EventArgs e)
        {

        }

        private void Drawingbutton_Click(object sender, EventArgs e)
        {
            // Получаем название продукта из текстового поля
            string DrawingName_1 = DrawingtextBox1?.Text?.Trim();
            string DrawingName_2 = DrawingtextBox2?.Text?.Trim();
            string DrawingName_3 = DrawingtextBox3?.Text?.Trim();

            // Проверяем, что название введено
            if (string.IsNullOrWhiteSpace(DrawingName_1))
            {
                MessageBox.Show("Введите название чертежа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(DrawingName_2))
            {
                MessageBox.Show("Введите описание чертежа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(DrawingName_3))
            {
                MessageBox.Show("Введите спецификацию чертежа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что название состоит только из русских/английских букв и цифр
            if (!Regex.IsMatch(DrawingName_1, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Название операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(DrawingName_2, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Описание операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(DrawingName_3, @"^[a-zA-Zа-яА-Я0-9]+$"))
            {
                MessageBox.Show("Спецификация операции может содержать только русские/английские буквы и цифры.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создаем новый чертеж с указанным названием и стоимостью
            
             Result.Name = DrawingName_1;
             Result.Description = DrawingName_2;
             Result.Specifications = DrawingName_3;
           

            // Уведомляем пользователя об успешном добавлении
            MessageBox.Show($"Чертёж '{Result.Name}' успешно добавлен в систему",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очищаем поле ввода
            DrawingtextBox1.Clear();
            DrawingtextBox2.Clear();
            DrawingtextBox3.Clear();

            // Закрываем форму с результатом OK
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddDrawingForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
