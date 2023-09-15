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
            if (CheckUserInput())
            {
                UserChoiceTextBox.Text = $"Тип линии: {_selectedLineType}{Environment.NewLine}Тип фигуры: {_selectedFigureType}";
            }
        }

        /// <summary>
        /// Проверяет ввод пользователя и уведомляет в случае ошибок
        /// </summary>
        /// <returns>true - ввод правильный, false - ввод не правильный</returns>
        private bool CheckUserInput()
        {
            string message;
            if (string.IsNullOrEmpty(_selectedLineType))
            {
                if (LineTypeListBox.Items.Count == 0)
                {
                    message = "Добавьте хотя бы один тип линии";
                }
                else
                {
                    message = "Выберите тип линии";
                }
            }
            else if (string.IsNullOrEmpty(_selectedFigureType))
            {
                message = "Выберите тип фигуры";
            }
            else
            {
                return true;
            }

            MessageBox.Show(message, "Ошибка");
            return false;
        }
    }
}