namespace lab_5_affine
{
    internal class Invoker
    {
        public event Action<bool>? UndoStatusChanged;
        public event Action<bool>? RedoStatusChanged;

        private Stack<ICommand> _undoHistory;
        private Stack<ICommand> _redoHistory;

        private bool _isUndoPossible;
        public bool IsUndoPossible
        {
            get => _isUndoPossible;
            private set
            {
                if (_isUndoPossible != value)
                {
                    _isUndoPossible = value;
                    UndoStatusChanged?.Invoke(value);
                    return;
                }
                _isUndoPossible = value;
            }
        }

        private bool _isRedoPossible;
        public bool IsRedoPossible
        {
            get => _isRedoPossible;
            private set
            {
                if (_isRedoPossible != value)
                {
                    _isRedoPossible = value;
                    RedoStatusChanged?.Invoke(value);
                    return;
                }
                _isRedoPossible = value;
            }
        }

        public Invoker()
        {
            _undoHistory = new();
            _redoHistory = new();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();

            _undoHistory.Push(command);
            IsUndoPossible = true;

            _redoHistory.Clear();
            IsRedoPossible = false;
        }

        public void UndoCommand()
        {
            if (_undoHistory.Count > 0)
            {
                ICommand command = _undoHistory.Pop();
                if (_undoHistory.Count == 0)
                {
                    IsUndoPossible = false;
                }

                command.Undo();

                _redoHistory.Push(command);
                IsRedoPossible = true;
            }
        }

        public void RedoCommand()
        {
            if (_redoHistory.Count > 0)
            {
                ICommand command = _redoHistory.Pop();
                if (_redoHistory.Count == 0)
                {
                    IsRedoPossible = false;
                }

                command.Execute();

                _undoHistory.Push(command);
                IsUndoPossible = true;
            }
        }
    }
}
