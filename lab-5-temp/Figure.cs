namespace lab_5_temp
{
    public class Figure
    {
        private Form _canvas;

        public List<FigurePoint> FigurePoints { get; protected set; }

        public Figure(List<FigurePoint> figurePoints, Form canvas)
        {
            _canvas = canvas;
            FigurePoints = figurePoints;
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
        }

        public void Scale(double kx, double ky)
        {
            List<FigurePoint> tempPoints = MakeCopyOfPoints();

            FigurePoint pivotPoint = FigurePoints[0];

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

            RestoreCopyOfPoint(tempPoints);
        }
        public void Shift(int dx, int dy)
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

            RestoreCopyOfPoint(tempPoints);
        }

        private void RestoreCopyOfPoint(List<FigurePoint> tempPoints)
        {
            for (int i = 0; i < tempPoints.Count; i++)
            {
                FigurePoints[i].X = tempPoints[i].X;
                FigurePoints[i].Y = tempPoints[i].Y;
            }
        }

        private List<FigurePoint> MakeCopyOfPoints()
        {
            List<FigurePoint> newFigurePoints = new();
            foreach (var point in FigurePoints)
            {
                newFigurePoints.Add(new FigurePoint(point.X, point.Y));
            }
            return newFigurePoints;
        }

        private bool IsPointInsideForm(Point point) => IsPointInsideForm(point.X, point.Y);

        private bool IsPointInsideForm(int x, int y)
        {
            if (_canvas.ClientSize.Width < 0 || _canvas.ClientSize.Height < 0)
            {
                return true;
            }

            return x >= 0 && x <= _canvas.ClientSize.Width && y >= 0 && y <= _canvas.ClientSize.Height;
        }
    }
}
