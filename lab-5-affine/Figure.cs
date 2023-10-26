namespace lab_5_affine
{
    public class Figure
    {
        private int _formWidth;
        private int _formHeight;

        public List<FigurePoint> FigurePoints { get; protected set; }
        public int PivotIndex { get; set; }

        public Figure(List<FigurePoint> points, int formWidth = -1, int formHeight = -1)
        {
            FigurePoints = points;
            _formWidth = formWidth;
            _formHeight = formHeight;
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
            List<FigurePoint> tempPoints = MakeCopyOfPoints();

            for (int i = 0; i < tempPoints.Count; i++)
            {
                FigurePoint currentPoint = tempPoints[i];

                currentPoint.X = currentPoint.X + dx;
                currentPoint.Y = currentPoint.Y + dy;

                if (!IsPointInsideForm(currentPoint.Point))
                {
                    throw new Exception("Фигура выходит за пределы формы.");
                }
            }

            RestoreCopyOfPoints(tempPoints);
        }

        public void Rotate(double degree)
        {
            List<FigurePoint> tempPoints = MakeCopyOfPoints();

            FigurePoint pivotPoint = FigurePoints[PivotIndex];
            double radian = DegreeToRadian(degree);
            for (int i = 0; i < tempPoints.Count; i++)
            {
                FigurePoint currentPoint = tempPoints[i];

                double dx = currentPoint.X - pivotPoint.X;
                double dy = currentPoint.Y - pivotPoint.Y;

                currentPoint.X = dx * Math.Cos(radian) + dy * Math.Sin(radian) + pivotPoint.X;
                currentPoint.Y = -dx * Math.Sin(radian) + dy * Math.Cos(radian) + pivotPoint.Y;

                if (!IsPointInsideForm(currentPoint.Point))
                {
                    throw new Exception("Фигура выходит за пределы формы.");
                }
            }

            RestoreCopyOfPoints(tempPoints);
        }

        public void Scale(double kx, double ky)
        {
            List<FigurePoint> tempPoints = MakeCopyOfPoints();

            FigurePoint pivotPoint = FigurePoints[PivotIndex];
            for (int i = 0; i < tempPoints.Count; i++)
            {
                FigurePoint currentPoint = tempPoints[i];

                double dx = currentPoint.X - pivotPoint.X;
                double dy = currentPoint.Y - pivotPoint.Y;

                currentPoint.X = dx / kx + pivotPoint.X;
                currentPoint.Y = dy / ky + pivotPoint.Y;

                if (!IsPointInsideForm(currentPoint.Point))
                {
                    throw new Exception("Фигура выходит за пределы формы.");
                }
            }

            RestoreCopyOfPoints(tempPoints);
        }

        private List<FigurePoint> MakeCopyOfPoints()
        {
            List<FigurePoint> newFigurePoints = new List<FigurePoint>();
            foreach (var point in FigurePoints)
            {
                newFigurePoints.Add(new FigurePoint(point.X, point.Y));
            }
            return newFigurePoints;
        }

        private void RestoreCopyOfPoints(List<FigurePoint> tempPoints)
        {
            for (int i = 0; i < tempPoints.Count; i++)
            {
                FigurePoints[i].X = tempPoints[i].X;
                FigurePoints[i].Y = tempPoints[i].Y;
            }
        }

        private bool IsPointInsideForm(int x, int y)
        {
            if (_formWidth < 0 || _formHeight < 0)
            {
                return true;
            }
            return x >= 0 && x <= _formWidth && y >= 0 && y <= _formHeight;
        }

        private bool IsPointInsideForm(Point point) => IsPointInsideForm(point.X, point.Y);

        private double DegreeToRadian(double degree) => degree * Math.PI / 180;
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

//private Point ScreenToDecart(Point point, int screenWidth, int screenHeight) => new Point(point.X, screenHeight - point.Y);