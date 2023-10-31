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
            if (!CanFillPoint(borderColor, fillColor, seedPoint))
            {
                return; // TODO: ui error
            }

            Stack<Point> pointStack = new Stack<Point>();
            pointStack.Push(seedPoint);

            while (pointStack.Count > 0)
            {
                Point point = pointStack.Pop();

                if (CanFillPoint(borderColor, fillColor, point))
                {
                    _bitmap.SetPixel(point.X, point.Y, fillColor); // fill point
                    if (DateTime.Now.Ticks % 100 == 0) _pictureBox.Invoke(_pictureBox.Invalidate);

                    pointStack.Push(new Point(point.X, point.Y - 1)); // up
                    pointStack.Push(new Point(point.X, point.Y + 1)); // down
                    pointStack.Push(new Point(point.X - 1, point.Y)); // left
                    pointStack.Push(new Point(point.X + 1, point.Y)); // right
                }
            }

            _pictureBox.Invoke(_pictureBox.Invalidate);
            MessageBox.Show("Закраска завершена!", "Сообщение", MessageBoxButtons.OK);
        }

        private bool CanFillPoint(Color borderColor, Color fillColor, Point point) => IsInPictureBox(point) && !IsPixelOfColor(point, borderColor) && !IsPixelOfColor(point, fillColor);

        private bool IsInPictureBox(Point p) => p.X >= 0 && p.X < _pictureBox.Width && p.Y >= 0 && p.Y < _pictureBox.Height;
    }
}
