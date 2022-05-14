using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Commands;

namespace ClassLibrary.Commands_Pattern
{
    public class CommandManager
    {
        public event EventHandler? Notify;
        private readonly List<ICommand> _commands = new();
        private int _position = -1;
        public bool HasUndo { get { return _position > -1; } }
        public bool HasRedo { get { return _position < _commands.Count - 1; } }

        public void Execute(ICommand command)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));
            if (HasRedo)
            {
                _commands.RemoveRange(_position + 1, _commands.Count() - (_position + 1));
            }
            command.Execute();
            _commands.Add(command);
            _position++;
            Notify?.Invoke(this, EventArgs.Empty);
        }

        public void Undo()
        {
            if (!HasUndo) return;
            var command = _commands[_position];
            command.Undo();
            _position--;
            Notify?.Invoke(this, EventArgs.Empty);
        }

        public void Redo()
        {
            if (!HasRedo) return;
            var command = _commands[++_position];
            command.Redo();
            Notify?.Invoke(this, EventArgs.Empty);
        }

        public void Reset()
        {
            _commands.Clear();
            _position = -1;
        }
    }
}
