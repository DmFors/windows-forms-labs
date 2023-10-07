namespace lab_5_affine
{
    public class Figure
    {
        private int _formWidth;
        private int _formHeight;

        public List<FigurePoint> FigurePoints { get; protected set; }
        public int PivotIndex { get; protected set; }

        public Figure(List<FigurePoint> points, int formWidth = -1, int formHeight = -1)
        {
            FigurePoints = points;
            _formWidth = formWidth;
            _formHeight = formHeight;
        }

        public void SetPivotIndex(int pivotIndex)
        {
            PivotIndex = pivotIndex;
        }

        public void Draw(Graphics graphics, Pen pen)
        {
            foreach (var figurePoint in FigurePoints)
            {
                foreach (var connectedFigurePoint in figurePoint.ConnectedPoints)
                {
                    graphics.DrawLine(pen, figurePoint.Point, connectedFigurePoint.Point);
                }
            }

            DrawPivotPoint(graphics, pen);
        }

        private void DrawPivotPoint(Graphics graphics, Pen pen)
        {
            int pointWidth = (int)(pen.Width * 2);
            Point pivotPoint = FigurePoints[PivotIndex].Point;
            graphics.FillRectangle(new SolidBrush(Color.Red), pivotPoint.X - pointWidth / 2, pivotPoint.Y - pointWidth / 2, pointWidth, pointWidth);
        }

        public void Shift(int dx = 0, int dy = 0)
        {
            List<Point> newPoints = new();
            for (int i = 0; i < FigurePoints.Count; i++)
            {
                Point currentPoint = FigurePoints[i].Point;

                int x = currentPoint.X + dx;
                int y = currentPoint.Y + dy;

                Point newPoint = new Point(x, y);

                CheckPointInsideForm(newPoint);

                newPoints.Add(newPoint);
            }
            ReplacePoints(newPoints);
        }

        public void Rotate(double degree)
        {
            double radian = DegreeToRadian(degree);

            Point pivotPoint = FigurePoints[PivotIndex].Point;

            List<Point> newPoints = new();
            for (int i = 0; i < FigurePoints.Count; i++)
            {
                Point currentPoint = FigurePoints[i].Point;

                int dx = currentPoint.X - pivotPoint.X;
                int dy = currentPoint.Y - pivotPoint.Y;

                int x = (int)Math.Round(dx * Math.Cos(radian) - dy * Math.Sin(radian) + pivotPoint.X);
                int y = (int)Math.Round(dx * Math.Sin(radian) + dy * Math.Cos(radian) + pivotPoint.Y);

                Point newPoint = new Point(x, y);

                CheckPointInsideForm(newPoint);
                newPoints.Add(newPoint);
            }
            ReplacePoints(newPoints);
        }

        public void Scale(double kx, double ky)
        {
            Point pivotPoint = FigurePoints[PivotIndex].Point;

            List<Point> newPoints = new();
            for (int i = 0; i < FigurePoints.Count; i++)
            {
                Point currentPoint = FigurePoints[i].Point;

                int dx = currentPoint.X - pivotPoint.X;
                int dy = currentPoint.Y - pivotPoint.Y;

                int x = (int)Math.Round(dx / kx + pivotPoint.X);
                int y = (int)Math.Round(dy / ky + pivotPoint.Y);

                Point newPoint = new Point(x, y);
                CheckPointInsideForm(newPoint);
                newPoints.Add(newPoint);
            }
            ReplacePoints(newPoints);
        }

        private void ReplacePoints(List<Point> newPoints)
        {
            if (newPoints.Count > FigurePoints.Count)
            {
                return;
            }

            for (int i = 0; i < newPoints.Count; i++)
            {
                FigurePoints[i].Point = newPoints[i];
            }
        }

        private void CheckPointInsideForm(Point newPoint)
        {
            if (_formWidth < 0 || _formHeight < 0)
            {
                return;
            }

            if (newPoint.X < 0 || newPoint.X > _formWidth || newPoint.Y < 0 || newPoint.Y > _formHeight)
            {
                throw new Exception("Фигура выходит за пределы формы.");
            }
        }

        private double DegreeToRadian(double degree) => degree * Math.PI / 180;

        private Point ScreenToDecart(Point point, int screenWidth, int screenHeight) => new Point(point.X, screenHeight - point.Y);
    }
}

//int xNew = (int)Math.Round(-pivotPoint.X + pivotPoint.X * Math.Cos(radian) + currentPoint.X * Math.Cos(radian) - pivotPoint.Y * Math.Sin(radian) - currentPoint.Y * Math.Sin(radian));
//int yNew = (int)Math.Round(-pivotPoint.Y + pivotPoint.Y * Math.Cos(radian) + currentPoint.Y * Math.Cos(radian) + pivotPoint.X * Math.Sin(radian) + currentPoint.X * Math.Sin(radian));

//xNew += height;
//Debug.WriteLine($"var 1: ({x},{y}). var 2: ({xNew},{yNew})");

//int hw = width / 2;
//int hh = height / 2;

//int dx = pivotPoint.X - hw;
//int dy = hh - pivotPoint.X;

//int xNew = (int)Math.Round((currentPoint.X - hw - dx) * Math.Cos(radian) - (hh - currentPoint.Y - dy) * Math.Sin(radian) + hw + dx);
//int yNew = (int)Math.Round(-(currentPoint.X - hw - dx) * Math.Sin(radian) - (hh - currentPoint.Y - dy) * Math.Cos(radian) - dy + hh);