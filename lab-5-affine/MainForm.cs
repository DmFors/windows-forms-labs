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

            _pen = new Pen(Color.Black, 10);
            _graphics = CreateGraphics();

            _invoker = new Invoker();
            _invoker.UndoStatusChanged += status => undo.Enabled = status;
            _figure = new Figure(CreateFigurePoints());
        }

        private static List<FigurePoint> CreateFigurePoints()
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
            if (int.TryParse(shiftDX.Text, out int dx) && int.TryParse(shiftDY.Text, out int dy))
            {
                ICommand shiftCommand = new ShiftCommand(_figure, dx, dy);
                _invoker.ExecuteCommand(shiftCommand);

                Refresh();
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(rotateDegree.Text, out int degrees))
            {
                degrees = -degrees;

                ICommand rotateCommand = new RotateCommand(_figure, degrees);
                _invoker.ExecuteCommand(rotateCommand);

                Refresh();
            }
        }

        private void changePivot_Click(object sender, EventArgs e)
        {
            _figure.SetPivotIndex((_figure.PivotIndex + 1) % _figure.FigurePoints.Count);
            Refresh();
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(scaleKX.Text, out double kx) && double.TryParse(scaleKY.Text, out double ky))
            {
                kx = 1 / kx;
                ky = 1 / ky;

                ICommand scaleCommand = new ScaleCommand(_figure, kx, ky);
                _invoker.ExecuteCommand(scaleCommand);
                Refresh();
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (_invoker.UndoCommand())
            {
                Refresh();
            }
        }
    }
}