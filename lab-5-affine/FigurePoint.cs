namespace lab_5_affine
{
    public class FigurePoint
    {
        public Point Point { get; set; }
        public List<FigurePoint> ConnectedPoints { get; protected set; }

        public FigurePoint(Point point)
        {
            Point = point;
            ConnectedPoints = new();
        }

        public FigurePoint(int x, int y) : this(new Point(x, y)) { }

        public void ConnectTo(FigurePoint point)
        {
            ConnectedPoints.Add(point);
        }
    }
}
