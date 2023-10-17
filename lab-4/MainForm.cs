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

        private void ОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigureForm createFigureForm = new CreateFigureForm();
            // подписываемся на событие формы для рисования выбранной пользователем фигуры
            createFigureForm.DrawFigureButtonClicked += AddFigureToCanvas;
            createFigureForm.ShowDialog();
        }

        /// <summary>
        /// Добавляет фигуру на холст
        /// </summary>
        /// <param name="figure">Фигура</param>
        public void AddFigureToCanvas(Figure figure)
        {
            if (figure == null)
            {
                return;
            }

            _drawFigureList.Add(figure);
            отменитьToolStripMenuItem.Enabled = true;
            очиститьToolStripMenuItem.Enabled = true;
            pictureBox1.Refresh();
        }

        private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_drawFigureList.Count > 0) // на холсте остались фигуры
            {
                _drawFigureList.RemoveAt(_drawFigureList.Count - 1); // убираем последнюю нарисованную фигуру
                Refresh();

                if (_drawFigureList.Count == 0) // фигур на холсте больше нет
                {
                    отменитьToolStripMenuItem.Enabled = false;
                    очиститьToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void ОчиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _drawFigureList.Clear();
            отменитьToolStripMenuItem.Enabled = false;
            очиститьToolStripMenuItem.Enabled = false;
            Refresh();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}