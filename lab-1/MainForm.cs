namespace lab_1
{
    public partial class MainForm : Form
    {
        private string? _authorName; // ��� ������, ��������� �������������

        public MainForm()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(_authorName))
            {
                ��������������ToolStripMenuItem.Enabled = false;
            }
        }

        private void ��������������ToolStripMenuItem1_Click(object sender, EventArgs e) // ������ ������ ��������������
        {
            ToggleMainMenuVisibility();
        }

        /// <summary>
        /// ����������� ��������� �������� ����
        /// </summary>
        private void ToggleMainMenuVisibility()
        {
            authorNameLabel.Visible = !authorNameLabel.Visible;
            authorNameTextBox.Visible = !authorNameTextBox.Visible;
            saveButton.Visible = !saveButton.Visible;
        }

        private void SaveButton_Click(object? sender, EventArgs e) // ������ ������ ����������
        {
            if (string.IsNullOrEmpty(authorNameTextBox.Text))
            {
                _authorName = null;
                ��������������ToolStripMenuItem.Enabled = false;
            }
            else // ������������ ���� ������
            {
                _authorName = authorNameTextBox.Text;
                authorNameTextBox.Text = null;
                ��������������ToolStripMenuItem.Enabled = true;

                ToggleMainMenuVisibility();
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e) // ������ ������ � ���������
        {
            MessageBox.Show(this, $"������������� #1{Environment.NewLine}������ 0.0.1", "� ���������");
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e) // ������ ������ ����� ���������
        {
            MessageBox.Show(this, $"��� ������: {_authorName}", "�������� �� ������");
        }

        private void �����ToolStripMenuItem1_Click(object sender, EventArgs e) // ������ ������ �����
        {
            Close();
        }
    }
}