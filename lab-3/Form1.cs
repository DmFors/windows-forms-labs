using System.Drawing.Drawing2D;
namespace lab_3
{
    public partial class Form1 : Form
    {
        private Rectangle _rect;
        private Color _fillColor;
        private DashStyle _borderDashStyle;
        private int _borderWidth;
        private Color _borderColor;

        private bool _isDragging;

        public Form1()
        {
            InitializeComponent();
            panel1.ContextMenuStrip = contextMenuStrip1;
            _rect = new Rectangle(100, 100, 200, 200);
            _borderWidth = 5;
            _borderColor = Color.Black;
            _fillColor = Color.Aqua;

            panel1.MouseDown += OnMouseDown;
            panel1.MouseMove += OnMouseMove;
            panel1.MouseUp += OnMouseUp;

            DoubleBuffered = true;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_rect.Contains(e.Location))
                {
                    _isDragging = true;
                }
            }
        }

        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                _rect.Location = new Point(e.Location.X - _rect.Size.Width / 2, e.Location.Y - _rect.Size.Height / 2);
                panel1.Refresh();
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(_borderColor, _borderWidth);
            pen.DashStyle = _borderDashStyle;
            e.Graphics.DrawRectangle(pen, _rect);

            Brush fillBrush = new SolidBrush(_fillColor);
            e.Graphics.FillRectangle(fillBrush, _rect);
        }

        private void íåïðåðûâíàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderDashStyle = DashStyle.Solid;
            panel1.Refresh();
        }

        private void ïóíêòèðíàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderDashStyle = DashStyle.Dot;
            panel1.Refresh();
        }

        private void pt5BorderMenu_Click(object sender, EventArgs e)
        {
            _borderWidth = 5;
            panel1.Refresh();
        }

        private void pt10BorderMenu_Click(object sender, EventArgs e)
        {
            _borderWidth = 10;
            panel1.Refresh();
        }

        private void pt15BorderMenu_Click(object sender, EventArgs e)
        {
            _borderWidth = 15;
            panel1.Refresh();
        }

        private void öâåòÇàëèâêèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fillColorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = fillColorDialog.Color;
                panel1.Refresh();
            }
        }

        private void öâåòÃðàíèöûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (borderColorDialog.ShowDialog() == DialogResult.OK)
            {
                _borderColor = borderColorDialog.Color;
                panel1.Refresh();
            }
        }
    }
}