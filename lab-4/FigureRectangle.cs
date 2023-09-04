namespace lab_4
{
    internal class FigureRectangle : Figure
    {
        private Pen _pen;
        private Rectangle _rect;

        public FigureRectangle(Pen pen, int x, int y, int width, int heigth)
        {
            _pen = pen;
            _rect = new Rectangle(x, y, width, heigth);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(_pen, _rect);
        }
    }
}
