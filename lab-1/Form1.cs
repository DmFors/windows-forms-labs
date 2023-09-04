using System.Diagnostics;

namespace lab_1
{
    public partial class Form1 : Form
    {
        private string? _authorName;

        public Form1()
        {
            InitializeComponent();
            saveButton.Click += OnSaveButtonClicked;

            if (string.IsNullOrEmpty(_authorName))
            {
                авторПрограммыToolStripMenuItem.Enabled = false;
            }
        }

        private void редактированиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("редактирование нажато");
            authorNameLabel.Visible = !authorNameLabel.Visible;
            authorNameTextBox.Visible = !authorNameTextBox.Visible;
            saveButton.Visible = !saveButton.Visible;

        }

        private void OnSaveButtonClicked(object? sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(authorNameTextBox.Text))
            {
                _authorName = null;
                авторПрограммыToolStripMenuItem.Enabled = false;
            }
            else
            {
                _authorName = authorNameTextBox.Text;
                авторПрограммыToolStripMenuItem.Enabled = true;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"Лаборатнорная #1{Environment.NewLine}Версия 0.0.1", "О программе");
        }

        private void авторПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"Имя автора: {_authorName}", "Сведения об авторе");
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}