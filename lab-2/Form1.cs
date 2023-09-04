namespace lab_2
{
    public partial class Form1 : Form
    {
        private string? _selectedLineType;
        private string? _selectedFigureType;
        private string[] initFigureTypes = new string[] { "Круг", "Квадрат", "Треугольник", "Прямоугольник" };

        public Form1()
        {
            InitializeComponent();
            InitFigureTypeComboBox();
        }

        private void InitFigureTypeComboBox()
        {
            FigureTypeComboBox.Items.AddRange(initFigureTypes);
        }

        private void AddLineType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LineTypeTextBox.Text))
            {
                LineTypeListBox.Items.Add(LineTypeTextBox.Text);
                LineTypeTextBox.Text = null;
            }
        }

        private void LineTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LineTypeListBox.Text))
            {
                _selectedLineType = LineTypeListBox.Text;
                UserChoiceTextBox.Text = null;
            }
        }

        private void FigureTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FigureTypeComboBox.Text))
            {
                _selectedFigureType = FigureTypeComboBox.Text;
                UserChoiceTextBox.Text = null;
            }
        }

        private void ShowUserChoiceButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_selectedLineType) && !string.IsNullOrEmpty(_selectedFigureType))
            {
                UserChoiceTextBox.Text = $"Тип линии: {_selectedLineType}{Environment.NewLine}Тип фигуры: {_selectedFigureType}";
            }
        }
    }
}