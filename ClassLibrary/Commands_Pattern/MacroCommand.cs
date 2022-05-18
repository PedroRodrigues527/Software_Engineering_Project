using ClassLibrary.Commands;

namespace ClassLibrary.Commands_Pattern
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands = new();
        public void Add(ICommand command) => _commands.Add(command);
        public void Remove(ICommand command) => _commands.Remove(command);

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
        public void Redo()
        {
            foreach (var command in _commands)
            {
                command.Redo();
            }
        }
        public void Undo()
        {
            _commands.Reverse();
            foreach (var command in _commands)
            {
                command.Undo();
            }
            _commands.Reverse();
        }
    }
}
