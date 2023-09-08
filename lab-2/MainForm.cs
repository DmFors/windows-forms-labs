namespace lab_2
{
    public partial class MainForm : Form
    {
        private string? _selectedLineType; // ��� �����, ��������� �������������
        private string? _selectedFigureType; // ��� ������, ��������� �������������
        private string[] _figureTypeComboBoxItems = new string[] { "����", "�������", "�����������", "�������������" };

        public MainForm()
        {
            InitializeComponent();

            FigureTypeComboBox.Items.AddRange(_figureTypeComboBoxItems); // ���������� ��������� ������ ��� ComboBox
        }

        private void AddLineType_Click(object sender, EventArgs e) // ������ ������ ���������� ������ ���� �����
        {
            if (!string.IsNullOrEmpty(LineTypeTextBox.Text))
            {
                LineTypeListBox.Items.Add(LineTypeTextBox.Text);
                LineTypeTextBox.Text = null;
            }
        }

        private void LineTypeListBox_SelectedIndexChanged(object sender, EventArgs e) // ������������ ������ ��� �����
        {
            if (!string.IsNullOrEmpty(LineTypeListBox.Text))
            {
                _selectedLineType = LineTypeListBox.Text;
                UserChoiceTextBox.Text = null;
            }
        }

        private void FigureTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) // ������������ ������ ��� ������
        {
            if (!string.IsNullOrEmpty(FigureTypeComboBox.Text))
            {
                _selectedFigureType = FigureTypeComboBox.Text;
                UserChoiceTextBox.Text = null;
            }
        }

        private void ShowUserChoiceButton_Click(object sender, EventArgs e) // ������ ������ ����������
        {
            if (!string.IsNullOrEmpty(_selectedLineType) && !string.IsNullOrEmpty(_selectedFigureType))
            {
                UserChoiceTextBox.Text = $"��� �����: {_selectedLineType}{Environment.NewLine}��� ������: {_selectedFigureType}";
            }
        }
    }
}