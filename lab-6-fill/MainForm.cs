namespace lab_6_fill
{
    public partial class MainForm : Form
    {
        private Pen _pen;
        private Painter _painter;
        private Color _fillColor;

        private bool _isChoosingSeedPoint;
        private Cursor _choosingSeedPointCursor = Cursors.Cross;

        public MainForm()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, 5);
            _painter = new Painter(pictureBox1);
            SetInfoText("");

            Figure figure = new Figure(CreateV15Points());
            figure.Shift(dx: 300, dy: 300);

            _painter.DrawFigure(figure, _pen);
        }

        private static List<FigurePoint> CreateTrianglePoints()
        {
            FigurePoint pt1 = new FigurePoint(400, 400);
            FigurePoint pt2 = new FigurePoint(500, 400);
            FigurePoint pt3 = new FigurePoint(500, 500);
            FigurePoint pt4 = new FigurePoint(400, 500);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt4);
            pt4.ConnectTo(pt1);

            return new List<FigurePoint>() { pt1, pt2, pt4 };
        }

        private static List<FigurePoint> CreateV5Points()
        {
            FigurePoint pt1 = new FigurePoint(0, 200);
            FigurePoint pt2 = new FigurePoint(400, 200);
            FigurePoint pt3 = new FigurePoint(200, 0);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt1);

            return new() { pt1, pt2, pt3 };
        }

        private static List<FigurePoint> CreateV11Points()
        {
            FigurePoint pt1 = new FigurePoint(0, 125);
            FigurePoint pt2 = new FigurePoint(100, 150);
            FigurePoint pt3 = new FigurePoint(100, 150);
            FigurePoint pt4 = new FigurePoint(125, 250);
            FigurePoint pt5 = new FigurePoint(150, 150);
            FigurePoint pt6 = new FigurePoint(250, 125);
            FigurePoint pt7 = new FigurePoint(150, 100);
            FigurePoint pt8 = new FigurePoint(125, 0);
            FigurePoint pt9 = new FigurePoint(100, 100);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt4);
            pt4.ConnectTo(pt5);
            pt5.ConnectTo(pt6);
            pt6.ConnectTo(pt7);
            pt7.ConnectTo(pt8);
            pt8.ConnectTo(pt9);
            pt9.ConnectTo(pt1);

            return new() { pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9 };
        }

        private static List<FigurePoint> CreateV15Points()
        {
            FigurePoint pt1 = new FigurePoint(0, 0);
            FigurePoint pt2 = new FigurePoint(0, 200);
            FigurePoint pt3 = new FigurePoint(400, 200);
            FigurePoint pt4 = new FigurePoint(500, 100);
            FigurePoint pt5 = new FigurePoint(400, 0);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt4);
            pt4.ConnectTo(pt5);
            pt5.ConnectTo(pt1);

            return new() { pt1, pt2, pt3, pt4, pt5 };
        }

        private static List<FigurePoint> CreateV16Points()
        {
            FigurePoint pt1 = new FigurePoint(0, 200);
            FigurePoint pt2 = new FigurePoint(0, 300);
            FigurePoint pt3 = new FigurePoint(500, 300);
            FigurePoint pt4 = new FigurePoint(500, 100);
            FigurePoint pt5 = new FigurePoint(550, 100);
            FigurePoint pt6 = new FigurePoint(450, 0);
            FigurePoint pt7 = new FigurePoint(350, 100);
            FigurePoint pt8 = new FigurePoint(400, 100);
            FigurePoint pt9 = new FigurePoint(400, 200);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt4);
            pt4.ConnectTo(pt5);
            pt5.ConnectTo(pt6);
            pt6.ConnectTo(pt7);
            pt7.ConnectTo(pt8);
            pt8.ConnectTo(pt9);
            pt9.ConnectTo(pt1);

            return new() { pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9 };
        }

        private static List<FigurePoint> CreateV666Points()
        {
            FigurePoint pt1 = new FigurePoint(0, 200);
            FigurePoint pt2 = new FigurePoint(0, 300);
            FigurePoint pt3 = new FigurePoint(500, 300);
            FigurePoint pt4 = new FigurePoint(500, 100);
            FigurePoint pt5 = new FigurePoint(550, 100);
            FigurePoint pt6 = new FigurePoint(450, 0);
            FigurePoint pt7 = new FigurePoint(350, 100);
            FigurePoint pt8 = new FigurePoint(400, 100);
            FigurePoint pt9 = new FigurePoint(400, 200);
            FigurePoint pt10 = new FigurePoint(100, 200);
            FigurePoint pt11 = new FigurePoint(100, 0);
            FigurePoint pt12 = new FigurePoint(0, 0);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt4);
            pt4.ConnectTo(pt5);
            pt5.ConnectTo(pt6);
            pt6.ConnectTo(pt7);
            pt7.ConnectTo(pt8);
            pt8.ConnectTo(pt9);
            pt9.ConnectTo(pt10);
            pt10.ConnectTo(pt11);
            pt11.ConnectTo(pt12);
            pt12.ConnectTo(pt1);

            return new() { pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9, pt10, pt11, pt12 };
        }

        // клик по кнопке выбора цвета
        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = colorDialog.Color;
                colorPreviewRect.BackColor = _fillColor;
            }
        }

        // клик по кнопке построчной заливки
        private void fillLineButton_Click(object sender, EventArgs e)
        {
            StopFillWithSeed(); // останавливаем выбор точки дл€ заливки с затравкой, если он происходит

            if (_fillColor == Color.Empty)
            {
                SetInfoText("ѕожалуйста, выберите цвет заливки");
                return;
            }

            SetInfoText("¬ыполн€етс€ заливка, подождите...");
            _painter.FillLineByLineScanning(_pen.Color, _fillColor);
            SetInfoText("");
        }

        // клик по кнопке заливки с затравкой
        private void fillSeedButton_Click(object sender, EventArgs e)
        {
            if (_fillColor == Color.Empty)
            {
                SetInfoText("ѕожалуйста, выберите цвет заливки");
                return;
            }
            else
            {
                SetInfoText("");
            }

            StartFillWithSeed();
        }

        // начинаем выбирать точку затравки
        private void StartFillWithSeed()
        {
            _isChoosingSeedPoint = true;
            pictureBox1.Cursor = _choosingSeedPointCursor;
            fillSeedButton.Enabled = false;
        }

        // заканчиваем выбирать точку затравки
        private void StopFillWithSeed()
        {
            _isChoosingSeedPoint = false;
            pictureBox1.Cursor = Cursors.Default;
            fillSeedButton.Enabled = true;
        }

        // клик по области рисовани€ дл€ выбора точки затравки
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isChoosingSeedPoint)
            {
                SetInfoText("¬ыполн€етс€ заливка, подождите...");
                _painter.FillWithSeed(_pen.Color, _fillColor, e.Location);
                SetInfoText("");
                StopFillWithSeed();
            }
        }

        // уведомлени€ дл€ пользовател€
        private void SetInfoText(string text)
        {
            infoLabel.Text = text;
            Refresh();
        }
    }
}