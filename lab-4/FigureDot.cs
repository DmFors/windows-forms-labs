namespace lab_4
{
    internal class FigureDot : Figure
    {
        private Brush _brush;
        private Rectangle _rect;

        public FigureDot(Brush brush, int x, int y)
        {
            _brush = brush;
            _rect = new Rectangle(x, y, 10, 10);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(_brush, _rect);
        }
    }
}
