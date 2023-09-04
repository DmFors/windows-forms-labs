namespace lab_4
{
    internal class FigureSegment : Figure
    {
        private Pen _pen;
        private Point _point1;
        private Point _point2;

        public FigureSegment(Pen pen, int x1, int y1, int x2, int y2)
        {
            _pen = pen;
            _point1 = new Point(x1, y1);
            _point2 = new Point(x2, y2);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(_pen, _point1, _point2);
        }
    }
}
