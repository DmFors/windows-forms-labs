namespace lab_5_affine
{
    internal class ShiftCommand : ICommand
    {
        private Figure _figure;
        private int dx;
        private int dy;

        public ShiftCommand(Figure figure, int dx, int dy)
        {
            _figure = figure;
            this.dx = dx;
            this.dy = dy;
        }

        public void Execute()
        {
            _figure.Shift(dx, dy);
        }

        public void Undo()
        {
            _figure.Shift(-dx, -dy);
        }
    }
}
