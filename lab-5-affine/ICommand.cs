namespace lab_5_affine
{
    internal interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
