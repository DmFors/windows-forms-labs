namespace lab_4
{
    public partial class MainForm : Form
    {

        private List<Figure> _drawFigureList; // ������ �����, �������������� �� ������� Canvas

        public MainForm()
        {
            InitializeComponent();
            _drawFigureList = new List<Figure>();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // ������������ ��� ������ �� ������� Canvas
            foreach (var figure in _drawFigureList)
            {
                figure.Draw(e.Graphics);
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigureForm createFigureForm = new CreateFigureForm();
            // ������������� �� ������� ����� ��� ��������� ��������� ������������� ������
            createFigureForm.DrawFigureButtonClicked += AddFigureToCanvas;
            createFigureForm.ShowDialog();
        }

        /// <summary>
        /// ��������� ������ �� �����
        /// </summary>
        /// <param name="figure">������</param>
        public void AddFigureToCanvas(Figure figure)
        {
            if (figure == null)
            {
                return;
            }

            _drawFigureList.Add(figure);
            ��������ToolStripMenuItem.Enabled = true;
            ��������ToolStripMenuItem.Enabled = true;
            pictureBox1.Refresh();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_drawFigureList.Count > 0) // �� ������ �������� ������
            {
                _drawFigureList.RemoveAt(_drawFigureList.Count - 1); // ������� ��������� ������������ ������
                Refresh();

                if (_drawFigureList.Count == 0) // ����� �� ������ ������ ���
                {
                    ��������ToolStripMenuItem.Enabled = false;
                    ��������ToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _drawFigureList.Clear();
            ��������ToolStripMenuItem.Enabled = false;
            ��������ToolStripMenuItem.Enabled = false;
            Refresh();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}