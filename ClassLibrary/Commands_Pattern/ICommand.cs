namespace ClassLibrary.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
