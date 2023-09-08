namespace lab_4
{
    public partial class MainForm : Form
    {

        private List<Figure> _drawFigureList; // список фигур, отрисовываемых на полотне Canvas

        public MainForm()
        {
            InitializeComponent();
            _drawFigureList = new List<Figure>();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // отрисовываем все фигуры на полотне Canvas
            foreach (var figure in _drawFigureList)
            {
                figure.Draw(e.Graphics);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigureForm createFigureForm = new CreateFigureForm();
            // подписываемся на событие формы для рисования выбранной пользователем фигуры
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