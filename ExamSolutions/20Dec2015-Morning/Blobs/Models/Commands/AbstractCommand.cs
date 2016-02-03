namespace Blobs.Models.Commands
{
    using Interfaces;

    public abstract class AbstractCommand : ICommand
    {
        protected AbstractCommand(string commandName)
        {
            this.CommandName = commandName;
        }

        public string CommandName { get; private set; }

        public ICommandArguments CommandParams { protected get; set; }

        public abstract void Execute();
    }
}
