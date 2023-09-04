namespace lab_4
{
    public partial class CreateFigureForm : Form
    {
        public event Action<Figure>? DrawFigureButtonClicked;

        private Pen _pen;
        private Brush _brush;

        private List<FigureType> _figureTypes;
        private FigureType _selectedFigureType;

        public CreateFigureForm()
        {
            InitializeComponent();

            _pen = new Pen(Color.Black, 10);
            _brush = new SolidBrush(Color.Black);

            _figureTypes = new List<FigureType> { FigureType.Точка, FigureType.Отрезок, FigureType.Прямоугольник, FigureType.Овал };
            InitComboBox();
        }

        private void InitComboBox()
        {
            string[] _figureTypeComboBoxItems = _figureTypes.Select(figureType => figureType.ToString()).ToArray();
            FigureTypeComboBox.Items.AddRange(_figureTypeComboBoxItems);
        }

        private void FigureTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFigureType = _figureTypes[FigureTypeComboBox.SelectedIndex];
            DrawFigureButton.Enabled = true;
            PrepareUI(_selectedFigureType);
        }

        private void PrepareUI(FigureType figureType)
        {
            CleanFields();
            ParameterTipLabel.Visible = true;
            switch (figureType)
            {
                case FigureType.Точка:
                    TextBoxX1.Visible = true;
                    TextBoxY1.Visible = true;
                    break;
                case FigureType.Отрезок:
                    TextBoxX1.Visible = true;
                    TextBoxY1.Visible = true;
                    TextBoxX2.Visible = true;
                    TextBoxY2.Visible = true;
                    break;
                case FigureType.Прямоугольник:
                    TextBoxX1.Visible = true;
                    TextBoxY1.Visible = true;
                    TextBoxWidth.Visible = true;
                    TextBoxHeight.Visible = true;
                    break;
                case FigureType.Овал:
                    TextBoxX1.Visible = true;
                    TextBoxY1.Visible = true;
                    TextBoxWidth.Visible = true;
                    TextBoxHeight.Visible = true;
                    break;
            }
        }

        private void CleanFields()
        {
            ParameterTipLabel.Visible = false;

            TextBoxX1.Visible = false;
            TextBoxY1.Visible = false;
            TextBoxX2.Visible = false;
            TextBoxY2.Visible = false;
            TextBoxWidth.Visible = false;
            TextBoxHeight.Visible = false;

            TextBoxX1.Text = null;
            TextBoxY1.Text = null;
            TextBoxX2.Text = null;
            TextBoxY2.Text = null;
            TextBoxWidth.Text = null;
            TextBoxHeight.Text = null;
        }

        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
            if (!TryProcessUserInputData())
            {
                MessageBox.Show("Пожалуйста, введите все параметры целыми числами.", "Неправильный ввод");
            }
        }

        private bool TryProcessUserInputData()
        {
            int x1, y1, x2, y2, width, heigth;
            Figure? figure = null;

            switch (_selectedFigureType)
            {
                case FigureType.Точка:
                    if (int.TryParse(TextBoxX1.Text, out x1) &&
                        int.TryParse(TextBoxY1.Text, out y1))
                    {
                        figure = new FigureDot(_brush, x1, y1);
                    }
                    break;
                case FigureType.Отрезок:
                    if (int.TryParse(TextBoxX1.Text, out x1) &&
                        int.TryParse(TextBoxY1.Text, out y1) &&
                        int.TryParse(TextBoxX2.Text, out x2) &&
                        int.TryParse(TextBoxY2.Text, out y2))
                    {
                        figure = new FigureSegment(_pen, x1, y1, x2, y2);
                    }
                    break;
                case FigureType.Прямоугольник:
                    if (int.TryParse(TextBoxX1.Text, out x1) &&
                        int.TryParse(TextBoxY1.Text, out y1) &&
                        int.TryParse(TextBoxWidth.Text, out width) &&
                        int.TryParse(TextBoxHeight.Text, out heigth))
                    {
                        figure = new FigureRectangle(_pen, x1, y1, width, heigth);
                    }
                    break;
                case FigureType.Овал:
                    if (int.TryParse(TextBoxX1.Text, out x1) &&
                        int.TryParse(TextBoxY1.Text, out y1) &&
                        int.TryParse(TextBoxWidth.Text, out width) &&
                        int.TryParse(TextBoxHeight.Text, out heigth))
                    {
                        figure = new FigureEllipse(_pen, x1, y1, width, heigth);
                    }
                    break;
            }

            if (figure != null)
            {
                DrawFigureButtonClicked?.Invoke(figure);
                return true;
            }
            else
            {
                return false;
            }
        }

        private enum FigureType
        {
            Точка,
            Отрезок,
            Прямоугольник,
            Овал
        }
    }
}
