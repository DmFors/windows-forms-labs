namespace lab_5_affine
{
    internal class Invoker
    {
        public event Action<bool>? UndoStatusChanged;
        private Stack<ICommand> _commandHistory;

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

        public Invoker()
        {
            _commandHistory = new();
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);

            IsUndoPossible = true;
        }

        public bool UndoCommand()
        {
            if (_commandHistory.Count > 0)
            {
                ICommand command = _commandHistory.Pop();
                command.Undo();
                if (_commandHistory.Count == 0)
                {
                    IsUndoPossible = false;
                }
                return true;
            }
            return false;
        }
    }
}
