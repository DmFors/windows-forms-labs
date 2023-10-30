namespace lab_5_temp
{
    public partial class MainForm : Form
    {
        private Graphics _graphics;
        private Pen _pen;
        private Figure _figure;
        public MainForm()
        {
            InitializeComponent();
            rotateDegreeField.Value = shiftDXField.Value = shiftDYField.Value = scaleKXField.Value = scaleKYField.Value = 0;

            _pen = new Pen(Color.Black, 5);
            _graphics = CreateGraphics();
            _figure = new Figure(CreateTrianglePoints(), this);
        }

        private List<FigurePoint> CreateTrianglePoints()
        {
            FigurePoint pt1 = new FigurePoint(700, 700);
            FigurePoint pt2 = new FigurePoint(1100, 700);
            FigurePoint pt3 = new FigurePoint(900, 500);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt1);

            return new List<FigurePoint>() { pt1, pt2, pt3 };
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            _figure.Draw(_graphics, _pen);
        }

        private void shift_Click(object sender, EventArgs e)
        {
            int dx = (int)shiftDXField.Value;
            int dy = (int)shiftDYField.Value;

            try
            {
                _figure.Shift(dx, dy);
                Refresh();
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message);
            }
        }

        private void DisplayInfo(string message)
        {
            InfoForm infoForm = new InfoForm(message);
            infoForm.StartPosition = FormStartPosition.CenterParent;
            infoForm.ShowDialog();
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            double kx = (double)scaleKXField.Value;
            double ky = (double)scaleKYField.Value;

            if (kx == 0 || ky == 0)
            {
                DisplayInfo("Масштабирование возможно только при kx и ky != 0");
                return;
            }

            kx = 1 / kx;
            ky = 1 / ky;

            try
            {
                _figure.Scale(kx, ky);
                Refresh();
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message);
            }
        }
    }
}