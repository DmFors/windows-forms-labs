namespace lab_5_affine
{
    public class FigurePoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point Point => new Point((int)Math.Round(X), (int)Math.Round(Y)); // для UI

        public List<FigurePoint> ConnectedPoints { get; protected set; } = new();

        public FigurePoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void ConnectTo(FigurePoint point)
        {
            ConnectedPoints.Add(point);
        }
    }
}
