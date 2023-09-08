using System.Drawing.Drawing2D;
namespace lab_3
{
    public partial class MainForm : Form
    {
        private Rectangle _rect; // прямоугольник, с которым происходит взаимодействие пользователя
        private Color _fillColor; // цвет прямоугольника
        private DashStyle _borderDashStyle; // стильграницы прямоугольника
        private int _borderWidth; // ширина границы прямоугольника
        private Color _borderColor; // цвет границы прямоугольника

        private bool _isDragging; // перетаскивается ли прямоугольник в данный момент

        public MainForm()
        {
            InitializeComponent();

            panel1.ContextMenuStrip = contextMenuStrip1; // добавляем контекстное меню на панель
            _rect = new Rectangle(100, 100, 200, 200);
            _borderWidth = 5;
            _borderColor = Color.Black;
            _fillColor = Color.Aqua;

            // события для перетаскивания прямоугольника
            panel1.MouseDown += OnMouseDown;
            panel1.MouseMove += OnMouseMove;
            panel1.MouseUp += OnMouseUp;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e) // Нажата кнопка мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_rect.Contains(e.Location))
                {
                    _isDragging = true;
                }
            }
        }

        private void OnMouseMove(object? sender, MouseEventArgs e) // Мышь перемещается
        {
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                _rect.Location = new Point(e.Location.X - _rect.Size.Width / 2, e.Location.Y - _rect.Size.Height / 2);
                panel1.Refresh(); // перерисовываем интерфейс
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e) // Отжата кнопка мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) // рисование прямоугольника
        {
            Pen pen = new Pen(_borderColor, _borderWidth);
            pen.DashStyle = _borderDashStyle;
            e.Graphics.DrawRectangle(pen, _rect);

            Brush fillBrush = new SolidBrush(_fillColor);
            e.Graphics.FillRectangle(fillBrush, _rect);
        }

        private void непрерывнаяToolStripMenuItem_Click(object sender, EventArgs e) // пользователь выбрал непрерывную линию
        {
            _borderDashStyle = DashStyle.Solid;
            panel1.Refresh();
        }

        private void пунктирнаяToolStripMenuItem_Click(object sender, EventArgs e) // пользователь выбрал пунктирную линию
        {
            _borderDashStyle = DashStyle.Dot;
            panel1.Refresh();
        }

        private void pt5BorderMenu_Click(object sender, EventArgs e) // пользователь выбрал 5pt ширину
        {
            _borderWidth = 5;
            panel1.Refresh();
        }

        private void pt10BorderMenu_Click(object sender, EventArgs e) // пользователь выбрал 10pt ширину
        {
            _borderWidth = 10;
            panel1.Refresh();
        }

        private void pt15BorderMenu_Click(object sender, EventArgs e) // пользователь выбрал 15pt ширину
        {
            _borderWidth = 15;
            panel1.Refresh();
        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e) // пользователь выбрал цвет заливки
        {
            if (fillColorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = fillColorDialog.Color;
                panel1.Refresh();
            }
        }

        private void цветГраницыToolStripMenuItem_Click(object sender, EventArgs e) // пользователь выбрал цвет границы
        {
            if (borderColorDialog.ShowDialog() == DialogResult.OK)
            {
                _borderColor = borderColorDialog.Color;
                panel1.Refresh();
            }
        }
    }
}