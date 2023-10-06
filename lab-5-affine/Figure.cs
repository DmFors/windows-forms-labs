namespace lab_5_affine
{
    public class Figure
    {
        public List<FigurePoint> FigurePoints { get; protected set; }
        public int PivotIndex { get; protected set; }

        public Figure(List<FigurePoint> points)
        {
            FigurePoints = points;
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
            Size pointSize = new Size((int)pen.Width, (int)pen.Width);
            Point pivotPoint = FigurePoints[PivotIndex].Point;
            graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(pivotPoint.X - pointSize.Width / 2, pivotPoint.Y - pointSize.Height / 2), pointSize));
        }

        public bool Shift(int dx = 0, int dy = 0)
        {
            for (int i = 0; i < FigurePoints.Count; i++)
            {
                Point currentPoint = FigurePoints[i].Point;

                int x = currentPoint.X + dx;
                int y = currentPoint.Y + dy;

                FigurePoints[i].Point = new Point(x, y);
            }
            return true;
        }

        public bool Rotate(double degree)
        {
            double radian = DegreeToRadian(degree);

            Point pivotPoint = FigurePoints[PivotIndex].Point;

            for (int i = 0; i < FigurePoints.Count; i++)
            {
                Point currentPoint = FigurePoints[i].Point;

                int dx = currentPoint.X - pivotPoint.X;
                int dy = currentPoint.Y - pivotPoint.Y;

                int x = (int)Math.Round(dx * Math.Cos(radian) - dy * Math.Sin(radian) + pivotPoint.X);
                int y = (int)Math.Round(dx * Math.Sin(radian) + dy * Math.Cos(radian) + pivotPoint.Y);

                FigurePoints[i].Point = new Point(x, y);
            }

            return true;
        }

        public void Scale(double kx, double ky)
        {
            Point pivotPoint = FigurePoints[PivotIndex].Point;

            for (int i = 0; i < FigurePoints.Count; i++)
            {
                Point currentPoint = FigurePoints[i].Point;

                int dx = currentPoint.X - pivotPoint.X;
                int dy = currentPoint.Y - pivotPoint.Y;

                int x = (int)Math.Round(dx / kx + pivotPoint.X);
                int y = (int)Math.Round(dy / ky + pivotPoint.Y);

                FigurePoints[i].Point = new Point(x, y);
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