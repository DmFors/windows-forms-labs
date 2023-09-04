namespace lab_4
{
    internal class FigureEllipse : Figure
    {
        private Pen _pen;
        private Rectangle _rect;

        public FigureEllipse(Pen pen, int x, int y, int width, int heigth)
        {
            _pen = pen;
            _rect = new Rectangle(x, y, width, heigth);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(_pen, _rect);
        }
    }
}
