using System.Drawing.Drawing2D;
namespace lab_3
{
    public partial class MainForm : Form
    {
        private Rectangle _rect; // �������������, � ������� ���������� �������������� ������������
        private Color _fillColor; // ���� ��������������
        private DashStyle _borderDashStyle; // ������������ ��������������
        private int _borderWidth; // ������ ������� ��������������
        private Color _borderColor; // ���� ������� ��������������

        private bool _isDragging; // ��������������� �� ������������� � ������ ������

        public MainForm()
        {
            InitializeComponent();

            panel1.ContextMenuStrip = contextMenuStrip1; // ��������� ����������� ���� �� ������
            _rect = new Rectangle(100, 100, 200, 200);
            _borderWidth = 5;
            _borderColor = Color.Black;
            _fillColor = Color.Aqua;

            // ������� ��� �������������� ��������������
            panel1.MouseDown += OnMouseDown;
            panel1.MouseMove += OnMouseMove;
            panel1.MouseUp += OnMouseUp;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e) // ������ ������ ����
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_rect.Contains(e.Location))
                {
                    _isDragging = true;
                }
            }
        }

        private void OnMouseMove(object? sender, MouseEventArgs e) // ���� ������������
        {
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                _rect.Location = new Point(e.Location.X - _rect.Size.Width / 2, e.Location.Y - _rect.Size.Height / 2);
                panel1.Refresh(); // �������������� ���������
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e) // ������ ������ ����
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) // ��������� ��������������
        {
            Pen pen = new Pen(_borderColor, _borderWidth);
            pen.DashStyle = _borderDashStyle;
            e.Graphics.DrawRectangle(pen, _rect);

            Brush fillBrush = new SolidBrush(_fillColor);
            e.Graphics.FillRectangle(fillBrush, _rect);
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e) // ������������ ������ ����������� �����
        {
            _borderDashStyle = DashStyle.Solid;
            panel1.Refresh();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e) // ������������ ������ ���������� �����
        {
            _borderDashStyle = DashStyle.Dot;
            panel1.Refresh();
        }

        private void pt5BorderMenu_Click(object sender, EventArgs e) // ������������ ������ 5pt ������
        {
            _borderWidth = 5;
            panel1.Refresh();
        }

        private void pt10BorderMenu_Click(object sender, EventArgs e) // ������������ ������ 10pt ������
        {
            _borderWidth = 10;
            panel1.Refresh();
        }

        private void pt15BorderMenu_Click(object sender, EventArgs e) // ������������ ������ 15pt ������
        {
            _borderWidth = 15;
            panel1.Refresh();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e) // ������������ ������ ���� �������
        {
            if (fillColorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = fillColorDialog.Color;
                panel1.Refresh();
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e) // ������������ ������ ���� �������
        {
            if (borderColorDialog.ShowDialog() == DialogResult.OK)
            {
                _borderColor = borderColorDialog.Color;
                panel1.Refresh();
            }
        }
    }
}