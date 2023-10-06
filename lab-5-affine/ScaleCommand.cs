namespace lab_5_affine
{
    internal class ScaleCommand : ICommand
    {
        private Figure _figure;
        private double _kx;
        private double _ky;

        public ScaleCommand(Figure figure, double kx, double ky)
        {
            _figure = figure;
            _kx = kx;
            _ky = ky;
        }

        public void Execute()
        {
            _figure.Scale(_kx, _ky);
        }

        public void Undo()
        {
            _figure.Scale(1 / _kx, 1 / -_ky);
        }
    }
}
