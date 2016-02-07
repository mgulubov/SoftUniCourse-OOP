namespace Blobs.Models.Commands
{
    using Interfaces;

    /// <summary>
    /// Abstract class for ICommand objects.
    /// </summary>
    public abstract class AbstractCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCommand"/> class.
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
