namespace lab_6_fill
{
    public partial class MainForm : Form
    {
        private Pen _pen;
        private Painter _painter;
        private bool _isChoosingSeedPoint;
        private Color _fillColor;

        public MainForm()
        {
            InitializeComponent();
            _pen = new Pen(Color.Black, 5);
            _painter = new Painter(pictureBox1);

            Figure _figure1 = new Figure(CreateV16Points());
            _figure1.Shift(dx: 100, dy: 100);
            _painter.DrawFigure(_figure1, _pen);

            //Figure _figure2 = new Figure(CreateV16Points());
            //_figure2.Shift(dy: 400);
            //_painter.DrawFigure(_figure2, _pen);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fillSeedButton_Click(object sender, EventArgs e)
        {
            if (_fillColor == Color.Empty)
            {
                MessageBox.Show("Пожалуйста, выберите цвет заливки", "Сообщение", MessageBoxButtons.OK);
            }

            StartFillSeed();
        }

        private void StartFillSeed()
        {
            _isChoosingSeedPoint = true;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void StopFillSeed()
        {
            _isChoosingSeedPoint = false;
            pictureBox1.Cursor = Cursors.Default;
        }

        private static List<FigurePoint> CreateTrianglePoints()
        {
            FigurePoint pt1 = new FigurePoint(0, 0);
            FigurePoint pt2 = new FigurePoint(300, 0);
            FigurePoint pt3 = new FigurePoint(0, 300);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt1);

            return new List<FigurePoint>() { pt1, pt2, pt3 };
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
            FigurePoint pt1 = new FigurePoint(25, 30);
            FigurePoint pt2 = new FigurePoint(60, 30);
            FigurePoint pt3 = new FigurePoint(25, 80);
            FigurePoint pt4 = new FigurePoint(25, 110);
            FigurePoint pt5 = new FigurePoint(60, 110);
            FigurePoint pt6 = new FigurePoint(160, 110);
            FigurePoint pt7 = new FigurePoint(195, 110);
            FigurePoint pt8 = new FigurePoint(195, 80);
            FigurePoint pt9 = new FigurePoint(160, 30);
            FigurePoint pt10 = new FigurePoint(195, 30);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt4);
            pt4.ConnectTo(pt5);
            pt5.ConnectTo(pt6);
            pt6.ConnectTo(pt7);
            pt7.ConnectTo(pt8);
            pt8.ConnectTo(pt9);
            pt9.ConnectTo(pt10);
            pt10.ConnectTo(pt1);

            return new() { pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9, pt10 };
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isChoosingSeedPoint)
            {
                _painter.FillWithSeed(_pen.Color, _fillColor, e.Location);
                StopFillSeed();
            }
        }

        private void fillLineButton_Click(object sender, EventArgs e)
        {
            if (_fillColor == Color.Empty)
            {
                MessageBox.Show("Пожалуйста, выберите цвет заливки", "Сообщение", MessageBoxButtons.OK);
            }

            StopFillSeed();
            _painter.FillLineByLineScanning(_pen.Color, _fillColor);
        }

        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = colorDialog.Color;
            }
        }
    }
}