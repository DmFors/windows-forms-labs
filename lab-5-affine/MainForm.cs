namespace lab_5_affine
{
    public partial class MainForm : Form
    {
        private Figure _figure;
        private Invoker _invoker;
        private Pen _pen;
        private Graphics _graphics;

        public MainForm()
        {
            InitializeComponent();
            shiftDXField.Minimum = decimal.MinValue;
            shiftDXField.Maximum = decimal.MaxValue;
            shiftDXField.Increment = 10;

            shiftDYField.Minimum = decimal.MinValue;
            shiftDYField.Maximum = decimal.MaxValue;
            shiftDYField.Increment = 10;

            scaleKXField.Minimum = decimal.MinValue;
            scaleKXField.Maximum = decimal.MaxValue;
            scaleKXField.Increment = 0.1M;

            scaleKYField.Minimum = decimal.MinValue;
            scaleKYField.Maximum = decimal.MaxValue;
            scaleKYField.Increment = 0.1M;

            _pen = new Pen(Color.Black, 5);
            _graphics = CreateGraphics();

            _invoker = new Invoker();
            _invoker.UndoStatusChanged += status => undoButton.Enabled = status;
            _invoker.RedoStatusChanged += status => redoButton.Enabled = status;
            _figure = new Figure(CreateV16Points(), Width - 20, Height - 20);
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

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            _figure.Draw(_graphics, _pen);
        }

        private void shift_Click(object sender, EventArgs e)
        {
            int dx = (int)shiftDXField.Value;
            int dy = (int)shiftDYField.Value;
            ICommand shiftCommand = new ShiftCommand(_figure, dx, dy);

            try
            {
                _invoker.ExecuteCommand(shiftCommand);
                Refresh();
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message);
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            double degrees = (double)rotateDegreeField.Value;
            degrees = -degrees;

            ICommand rotateCommand = new RotateCommand(_figure, degrees);

            try
            {
                _invoker.ExecuteCommand(rotateCommand);
                Refresh();
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message);
            }
        }

        private void changePivot_Click(object sender, EventArgs e)
        {
            ICommand setPivotCommand = new SetPivotCommand(_figure, (_figure.PivotIndex + 1) % _figure.FigurePoints.Count);
            _invoker.ExecuteCommand(setPivotCommand);

            Refresh();
        }

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

            ICommand scaleCommand = new ScaleCommand(_figure, kx, ky);

            try
            {
                _invoker.ExecuteCommand(scaleCommand);
                Refresh();
            }
            catch (Exception ex)
            {
                DisplayInfo(ex.Message);
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            _invoker.UndoCommand();
            Refresh();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            _invoker.RedoCommand();
            Refresh();
        }

        private static void DisplayInfo(string text)
        {
            InfoForm infoForm = new InfoForm(text);
            infoForm.StartPosition = FormStartPosition.CenterParent;
            infoForm.ShowDialog();
        }
    }
}