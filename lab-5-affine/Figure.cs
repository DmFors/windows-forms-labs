namespace lab_5_affine
{
    public class Figure
    {
        private int _formWidth;
        private int _formHeight;

        public List<FigurePoint> FigurePoints { get; protected set; }
        public int PivotIndex { get; set; } = 0;

        public Figure(List<FigurePoint> points, int formWidth = -1, int formHeight = -1)
        {
            FigurePoints = points;
            _formWidth = formWidth;
            _formHeight = formHeight;
        }

        // Рисует фигуру на холсте, соединяя точки
        public void Draw(Graphics graphics, Pen pen)
        {
            foreach (var figurePoint in FigurePoints)
            {
                foreach (var connectedFigurePoint in figurePoint.ConnectedPoints)
                {
                    graphics.DrawLine(pen, figurePoint.Point, connectedFigurePoint.Point);
                }
            }

            DrawPivotPoint(graphics, (int)pen.Width * 2);
        }

        // Рисует опорную точку
        private void DrawPivotPoint(Graphics graphics, int pointWidth)
        {
            Point pivotPoint = FigurePoints[PivotIndex].Point;
            graphics.FillRectangle(new SolidBrush(Color.Red), pivotPoint.X - pointWidth / 2, pivotPoint.Y - pointWidth / 2, pointWidth, pointWidth);
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

                currentPoint.X = dx * Math.Cos(radian) - dy * Math.Sin(radian) + pivotPoint.X;
                currentPoint.Y = dx * Math.Sin(radian) + dy * Math.Cos(radian) + pivotPoint.Y;

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

        // Создает и возвращает копию текущих точек фигуры, не затрагивая связи между ними (ConnectedPoints)
        private List<FigurePoint> MakeCopyOfPoints()
        {
            List<FigurePoint> newFigurePoints = new List<FigurePoint>();
            foreach (var point in FigurePoints)
            {
                newFigurePoints.Add(new FigurePoint(point.X, point.Y));
            }
            return newFigurePoints;
        }

        // Применяет переданную копию точек фигуры, не затрагивая связи между ними (ConnectedPoints)
        private void RestoreCopyOfPoints(List<FigurePoint> newFigurePoints)
        {
            for (int i = 0; i < newFigurePoints.Count; i++)
            {
                FigurePoints[i].X = newFigurePoints[i].X;
                FigurePoints[i].Y = newFigurePoints[i].Y;
            }
        }

        // Проверяет, находится ли точка в пределах формы
        private bool IsPointInsideForm(int x, int y)
        {
            if (_formWidth < 0 || _formHeight < 0)
            {
                return true;
            }
            return x >= 0 && x <= _formWidth && y >= 0 && y <= _formHeight;
        }

        private bool IsPointInsideForm(Point point) => IsPointInsideForm(point.X, point.Y);

        // Конвертирует градусы в радианы
        private double DegreeToRadian(double degree) => degree * Math.PI / 180;
    }
}