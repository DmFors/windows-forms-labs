namespace lab_5_affine
{
    internal class RotateCommand : ICommand
    {
        private Figure _figure;
        private double _degree;

        public RotateCommand(Figure figure, double degree)
        {
            _figure = figure;
            _degree = degree;
        }

        public void Execute()
        {
            _figure.Rotate(_degree);
        }

        public void Undo()
        {
            _figure.Rotate(-_degree);
        }
    }
}
