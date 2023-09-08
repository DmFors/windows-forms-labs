namespace lab_2
{
    public partial class MainForm : Form
    {
        private string? _selectedLineType; // тип линии, выбранный пользователем
        private string? _selectedFigureType; // тип фигуры, выбранный пользователем
        private string[] _figureTypeComboBoxItems = new string[] { "Круг", "Квадрат", "Треугольник", "Прямоугольник" };

        public MainForm()
        {
            InitializeComponent();

            FigureTypeComboBox.Items.AddRange(_figureTypeComboBoxItems); // добавление вариантов выбора для ComboBox
        }

        private void AddLineType_Click(object sender, EventArgs e) // нажата кнопка добавления нового типа линии
        {
            if (!string.IsNullOrEmpty(LineTypeTextBox.Text))
            {
                LineTypeListBox.Items.Add(LineTypeTextBox.Text);
                LineTypeTextBox.Text = null;
            }
        }

        private void LineTypeListBox_SelectedIndexChanged(object sender, EventArgs e) // пользователь выбрал тип линии
        {
            if (!string.IsNullOrEmpty(LineTypeListBox.Text))
            {
                _selectedLineType = LineTypeListBox.Text;
                UserChoiceTextBox.Text = null;
            }
        }

        private void FigureTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) // пользователь выбрал тип фигуры
        {
            if (!string.IsNullOrEmpty(FigureTypeComboBox.Text))
            {
                _selectedFigureType = FigureTypeComboBox.Text;
                UserChoiceTextBox.Text = null;
            }
        }

        private void ShowUserChoiceButton_Click(object sender, EventArgs e) // нажата кнопка посмотреть
        {
            if (!string.IsNullOrEmpty(_selectedLineType) && !string.IsNullOrEmpty(_selectedFigureType))
            {
                UserChoiceTextBox.Text = $"Тип линии: {_selectedLineType}{Environment.NewLine}Тип фигуры: {_selectedFigureType}";
            }
        }
    }
}