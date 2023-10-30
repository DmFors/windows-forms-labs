namespace lab_6_fill
{
    public class Painter
    {
        private PictureBox _pictureBox;
        private Bitmap _bitmap;
        private Graphics _graphics;

        public Painter(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            _pictureBox.Image = _bitmap;
            _graphics = Graphics.FromImage(_bitmap);
        }

        public void DrawFigure(Figure figure, Pen pen)
        {
            figure.Draw(_graphics, pen);
            _pictureBox.Invalidate();
        }

        public void FillLineByLineScanning(Color borderColor, Color fillColor, bool isXAxis = true)
        {
            Pen pen = new Pen(fillColor);

            for (int line = 0; line < _bitmap.Height; line++)
            {
                List<Point> lineBorderPoints = GetLineBorderPoints(borderColor, line);

                for (int i = 0; i < lineBorderPoints.Count - 1; i++)
                {
                    Point borderPointA = lineBorderPoints[i];
                    Point borderPointB = lineBorderPoints[i + 1];

                    int gapInPixels = borderPointB.X - borderPointA.X - 1;
                    if (gapInPixels >= 1)
                    {
                        Point pointA = new Point(borderPointA.X + 1, borderPointA.Y);
                        Point pointB = new Point(borderPointB.X - 1, borderPointB.Y);

                        _graphics.DrawLine(pen, pointA, pointB);
                    }
                }
            }
            _pictureBox.Invalidate();
        }

        private List<Point> GetLineBorderPoints(Color borderColor, int lineY)
        {
            List<Point> borderPoints = new();

            for (int x = 0; x < _bitmap.Width; x++)
            {
                if (IsPixelOfColor(x, lineY, borderColor))
                {
                    borderPoints.Add(new Point(x, lineY));
                }
            }
            return borderPoints;
        }

        private bool IsPixelOfColor(int x, int y, Color color) => _bitmap.GetPixel(x, y).ToArgb() == color.ToArgb();

        private bool IsPixelOfColor(Point point, Color color) => IsPixelOfColor(point.X, point.Y, color);

        public void FillWithSeed(Color borderColor, Color fillColor, Point seedPoint)
        {
            if (!IsInPictureBox(seedPoint) || IsPixelOfColor(seedPoint, borderColor) || IsPixelOfColor(seedPoint, fillColor))
            {
                return;
            }

            _bitmap.SetPixel(seedPoint.X, seedPoint.Y, fillColor);
            _pictureBox.Refresh();

            Point pointUp = new Point(seedPoint.X, seedPoint.Y + 1);
            Point pointDown = new Point(seedPoint.X, seedPoint.Y - 1);
            Point pointLeft = new Point(seedPoint.X - 1, seedPoint.Y);
            Point pointRight = new Point(seedPoint.X + 1, seedPoint.Y);

            FillWithSeed(borderColor, fillColor, pointUp);
            FillWithSeed(borderColor, fillColor, pointDown);
            FillWithSeed(borderColor, fillColor, pointLeft);
            FillWithSeed(borderColor, fillColor, pointRight);
        }

        private bool IsInPictureBox(Point p) => p.X >= 0 || p.X <= _pictureBox.Width || p.Y >= 0 || p.Y <= _pictureBox.Width;
    }
}
