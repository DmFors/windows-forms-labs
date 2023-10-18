namespace lab_5_affine
{
    public partial class MainForm : Form
    {
        private Figure _figure;
        private Pen _pen;
        private Graphics _graphics;

        public MainForm()
        {
            InitializeComponent();
            rotateDegreeField.Value = shiftDXField.Value = shiftDYField.Value = scaleKXField.Value = scaleKYField.Value = 0;

            _pen = new Pen(Color.Black, 5);
            _graphics = CreateGraphics();

            _figure = new Figure(CreateV5Points(), ClientSize.Width, ClientSize.Height);
        }

        private static List<FigurePoint> CreateV5Points()
        {
            FigurePoint pt1 = new FigurePoint(700, 700);
            FigurePoint pt2 = new FigurePoint(1100, 700);
            FigurePoint pt3 = new FigurePoint(900, 500);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt1);

            return new() { pt1, pt2, pt3 };
        }

        private static List<FigurePoint> CreateV11Points()
        {
            FigurePoint pt1 = new FigurePoint(525, 600);
            FigurePoint pt2 = new FigurePoint(625, 625);
            FigurePoint pt3 = new FigurePoint(625, 625);
            FigurePoint pt4 = new FigurePoint(650, 725);
            FigurePoint pt5 = new FigurePoint(675, 625);
            FigurePoint pt6 = new FigurePoint(775, 600);
            FigurePoint pt7 = new FigurePoint(675, 575);
            FigurePoint pt8 = new FigurePoint(650, 475);
            FigurePoint pt9 = new FigurePoint(625, 575);

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
            FigurePoint pt1 = new FigurePoint(500, 500);
            FigurePoint pt2 = new FigurePoint(500, 700);
            FigurePoint pt3 = new FigurePoint(900, 700);
            FigurePoint pt4 = new FigurePoint(1000, 600);
            FigurePoint pt5 = new FigurePoint(900, 500);

            pt1.ConnectTo(pt2);
            pt2.ConnectTo(pt3);
            pt3.ConnectTo(pt4);
            pt4.ConnectTo(pt5);
            pt5.ConnectTo(pt1);

            return new() { pt1, pt2, pt3, pt4, pt5 };
        }

        private static List<FigurePoint> CreateV16Points()
        {
            FigurePoint pt1 = new FigurePoint(500, 500);
            FigurePoint pt2 = new FigurePoint(500, 600);
            FigurePoint pt3 = new FigurePoint(1000, 600);
            FigurePoint pt4 = new FigurePoint(1000, 400);
            FigurePoint pt5 = new FigurePoint(1050, 400);
            FigurePoint pt6 = new FigurePoint(950, 300);
            FigurePoint pt7 = new FigurePoint(850, 400);
            FigurePoint pt8 = new FigurePoint(900, 400);
            FigurePoint pt9 = new FigurePoint(900, 500);

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

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            _figure.Draw(_graphics, _pen);
        }

        //пользователь нажал кнопку сдвига
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

        // пользователь нажал кнопку поворота
        private void rotateButton_Click(object sender, EventArgs e)
        {
            double degrees = (double)rotateDegreeField.Value;
            degrees = -degrees;

            try
            {
                _figure.Rotate(degrees);
                Refresh();
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message);
            }
        }

        // пользователь нажал кнопку изменения масштаба
        private void scaleButton_Click(object sender, EventArgs e)
        {
            double kx = (double)scaleKXField.Value;
            double ky = (double)scaleKYField.Value;

            if (kx == 0 || ky == 0)
            {
                DisplayInfo("Для корректного масштабирования kx и ky не должны быть равными 0.");
                return;
            }

            // for convenient use in the UI
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

        // отображает информационное окно
        private static void DisplayInfo(string text)
        {
            InfoForm infoForm = new InfoForm(text);
            infoForm.StartPosition = FormStartPosition.CenterParent;
            infoForm.ShowDialog();
        }
    }
}