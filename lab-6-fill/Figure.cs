namespace lab_6_fill
{
    public class Figure
    {
        public List<FigurePoint> FigurePoints { get; protected set; }
        public int PivotIndex { get; set; }

        public Figure(List<FigurePoint> points)
        {
            FigurePoints = points;
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

        public void Shift(int dx = 0, int dy = 0)
        {
            for (int i = 0; i < FigurePoints.Count; i++)
            {
                FigurePoint currentPoint = FigurePoints[i];

                currentPoint.X = currentPoint.X + dx;
                currentPoint.Y = currentPoint.Y + dy;
            }
        }
    }
}