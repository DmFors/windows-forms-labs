namespace lab_6_fill
{
    public partial class MainForm : Form
    {
        private Pen _pen;
        private Painter _painter;
        private bool _isChoosingSeedPoint;
        private Color _fillColor = Color.Purple;

        public MainForm()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, 5);
            _painter = new Painter(pictureBox1);
            SetInfoText("");

            Figure figure1 = new Figure(CreateV16Points());
            figure1.Shift(dx: 100, dy: 100);
            _painter.DrawFigure(figure1, _pen);
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = colorDialog.Color;
                colorPreviewRect.BackColor = _fillColor;
            }
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

        private void fillLineButton_Click(object sender, EventArgs e)
        {
            StopFillWithSeed();

            if (_fillColor == Color.Empty)
            {
                SetInfoText("Пожалуйста, выберите цвет заливки");
                return;
            }
            else
            {
                SetInfoText("");
            }

            SetInfoText("Выполняется заливка, подождите...");
            _painter.FillLineByLineScanning(_pen.Color, _fillColor);
            SetInfoText("");
        }

        private void fillSeedButton_Click(object sender, EventArgs e)
        {
            if (_fillColor == Color.Empty)
            {
                SetInfoText("Пожалуйста, выберите цвет заливки");
                return;
            }
            else
            {
                SetInfoText("");
            }

            StartFillWithSeed();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isChoosingSeedPoint)
            {
                SetInfoText("Выполняется заливка, подождите...");
                _painter.FillWithSeed(_pen.Color, _fillColor, e.Location);
                SetInfoText("");
                StopFillWithSeed();
            }
        }

        private void StartFillWithSeed()
        {
            _isChoosingSeedPoint = true;
            pictureBox1.Cursor = Cursors.Cross;
            fillSeedButton.Enabled = false;
        }

        private void StopFillWithSeed()
        {
            _isChoosingSeedPoint = false;
            pictureBox1.Cursor = Cursors.Default;
            fillSeedButton.Enabled = true;
        }
        private void SetInfoText(string text)
        {
            infoLabel.Text = text;
            Refresh();
        }
    }
}