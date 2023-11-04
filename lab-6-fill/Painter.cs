﻿namespace lab_6_fill
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

        // построчная заливка
        public void FillLineByLineScanning(Color borderColor, Color fillColor)
        {
            Pen pen = new Pen(fillColor);

            for (int line = 0; line < _bitmap.Height; line++)
            {
                List<Point> lineBorderPoints = GetLineBorderPoints(borderColor, line);

                for (int i = 0; i < lineBorderPoints.Count - 1; i += 2)
                {
                    Point borderPointA = lineBorderPoints[i];
                    Point borderPointB = lineBorderPoints[i + 1];

                    if (IsGapBetweenBorderPoints(borderPointA, borderPointB, fillColor))
                    {
                        Point pointA = new Point(borderPointA.X + 1, borderPointA.Y);
                        Point pointB = new Point(borderPointB.X - 1, borderPointB.Y);

                        _graphics.DrawLine(pen, pointA, pointB);

                        _pictureBox.Refresh();
                        Task.Delay(1).Wait(); // ждем 1 мс
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

        private bool IsGapBetweenBorderPoints(Point borderPointA, Point borderPointB, Color fillColor)
        {
            int gapLengthInPixels = borderPointB.X - borderPointA.X - 1;
            if (gapLengthInPixels < 1)
            {
                return false;
            }

            for (int x = borderPointA.X + 1; x < borderPointB.X; x++)
            {
                Point gapPoint = new Point(x, borderPointA.Y);
                if (IsPixelOfColor(gapPoint, fillColor))
                {
                    return false;
                }
            }
            return true;
        }

        // заливка с затравкой
        public void FillWithSeed(Color borderColor, Color fillColor, Point seedPoint)
        {
            if (!CanFillPixel(borderColor, fillColor, seedPoint))
            {
                return;
            }

            Stack<Point> pointStack = new Stack<Point>();
            pointStack.Push(seedPoint);

            int filledPixelCount = 0;
            while (pointStack.Count > 0)
            {
                Point point = pointStack.Pop();

                if (CanFillPixel(borderColor, fillColor, point))
                {
                    _bitmap.SetPixel(point.X, point.Y, fillColor); // закрашиваем пиксель
                    if (++filledPixelCount % 100 == 0) _pictureBox.Refresh(); // обновляем картинку каждые n закрашенных пикселей

                    pointStack.Push(new Point(point.X, point.Y - 1)); // верх
                    pointStack.Push(new Point(point.X, point.Y + 1)); // низ
                    pointStack.Push(new Point(point.X - 1, point.Y)); // лево
                    pointStack.Push(new Point(point.X + 1, point.Y)); // право
                }
            }

            _pictureBox.Invalidate();
        }

        private bool IsPixelOfColor(int x, int y, Color color) => _bitmap.GetPixel(x, y).ToArgb() == color.ToArgb();

        private bool IsPixelOfColor(Point point, Color color) => IsPixelOfColor(point.X, point.Y, color);

        private bool CanFillPixel(Color borderColor, Color fillColor, Point point) => IsInPictureBox(point) && !IsPixelOfColor(point, borderColor) && !IsPixelOfColor(point, fillColor);

        private bool IsInPictureBox(Point p) => p.X >= 0 && p.X < _pictureBox.Width && p.Y >= 0 && p.Y < _pictureBox.Height;
    }
}
