namespace lab_4
{
    public partial class MainForm : Form
    {

        private List<Figure> _drawFigureList;

        public MainForm()
        {
            InitializeComponent();
            _drawFigureList = new List<Figure>();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var figure in _drawFigureList)
            {
                figure.Draw(e.Graphics);
            }
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ó·˙ÂÍÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigureForm createFigureForm = new CreateFigureForm();
            createFigureForm.DrawFigureButtonClicked += OnDrawFigureButtonClicked;
            createFigureForm.ShowDialog();
        }

        private void OnDrawFigureButtonClicked(Figure figure)
        {
            _drawFigureList.Add(figure);
            pictureBox1.Refresh();
        }
    }
}