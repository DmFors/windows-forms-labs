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
                ��������������ToolStripMenuItem.Enabled = false;
            }
        }

        private void ��������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("�������������� ������");
            authorNameLabel.Visible = !authorNameLabel.Visible;
            authorNameTextBox.Visible = !authorNameTextBox.Visible;
            saveButton.Visible = !saveButton.Visible;

        }

        private void OnSaveButtonClicked(object? sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(authorNameTextBox.Text))
            {
                _authorName = null;
                ��������������ToolStripMenuItem.Enabled = false;
            }
            else
            {
                _authorName = authorNameTextBox.Text;
                ��������������ToolStripMenuItem.Enabled = true;
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"������������� #1{Environment.NewLine}������ 0.0.1", "� ���������");
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"��� ������: {_authorName}", "�������� �� ������");
        }

        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}