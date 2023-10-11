namespace lab_5_affine
{
    internal class SetPivotCommand : ICommand
    {
        private Figure _figure;
        private int _prevPivotIndex;
        private int _currentPivotIndex;

        public SetPivotCommand(Figure figure, int pivotIndex)
        {
            _figure = figure;
            _prevPivotIndex = _figure.PivotIndex;
            _currentPivotIndex = pivotIndex;
        }

        public void Execute()
        {
            _figure.PivotIndex = _currentPivotIndex;
        }

        public void Undo()
        {
            _figure.PivotIndex = _prevPivotIndex;
        }
    }
}
