namespace lab_1
{
    public partial class MainForm : Form
    {
        private string? _authorName; // имя автора, выбранное пользователем

        public MainForm()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(_authorName))
            {
                авторПрограммыToolStripMenuItem.Enabled = false;
            }
        }

        private void РедактированиеToolStripMenuItem1_Click(object sender, EventArgs e) // нажата кнопка редактирование
        {
            ToggleMainMenuVisibility();
        }

        /// <summary>
        /// Переключает видимость главного меню
        /// </summary>
        private void ToggleMainMenuVisibility()
        {
            authorNameLabel.Visible = !authorNameLabel.Visible;
            authorNameTextBox.Visible = !authorNameTextBox.Visible;
            saveButton.Visible = !saveButton.Visible;
        }

        private void SaveButton_Click(object? sender, EventArgs e) // нажата кнопка сохранения
        {
            if (string.IsNullOrEmpty(authorNameTextBox.Text))
            {
                _authorName = null;
                авторПрограммыToolStripMenuItem.Enabled = false;
            }
            else // пользователь ввел автора
            {
                _authorName = authorNameTextBox.Text;
                authorNameTextBox.Text = null;
                авторПрограммыToolStripMenuItem.Enabled = true;

                ToggleMainMenuVisibility();
            }
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e) // нажата кнопка о программе
        {
            MessageBox.Show(this, $"Лаборатнорная #1{Environment.NewLine}Версия 0.0.1", "О программе");
        }

        private void АвторПрограммыToolStripMenuItem_Click(object sender, EventArgs e) // нажата кнопка автор программы
        {
            MessageBox.Show(this, $"Имя автора: {_authorName}", "Сведения об авторе");
        }

        private void ВыходToolStripMenuItem1_Click(object sender, EventArgs e) // нажата кнопка выход
        {
            Close();
        }
    }
}