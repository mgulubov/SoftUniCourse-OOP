namespace Blobs.Models.Commands
{
    using Interfaces;

    /// <summary>
    /// Abstract class for ICommand objects.
    /// </summary>
    public abstract class AbstractCommand : ICommand
    {
        /// <summary>
        /// Constructor with one argument.
        /// </summary>
        /// <param name="commandName">The command name.</param>
        protected AbstractCommand(string commandName)
        {
            this.CommandName = commandName;
        }

        public string CommandName { get; private set; }

        public ICommandArguments CommandParams { protected get; set; }

        public abstract void Execute();
    }
}
