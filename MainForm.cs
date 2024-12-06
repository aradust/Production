using System;
using System.Windows.Forms;

namespace Production
{
    /// <summary>
    /// Главная форма приложения, предоставляющая доступ к функционалу управления продуктами.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр формы <see cref="MainForm"/>.
        /// </summary> 
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить продукт".
        /// Открывает форму для добавления нового продукта.
        /// </summary>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления продукта
            using (var addProductForm = new AddProductForm())
            {
                // Отображаем форму как модальное окно
                addProductForm.ShowDialog();
            }
        }
    }
}
