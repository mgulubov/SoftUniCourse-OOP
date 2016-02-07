namespace Blobs.Utils.Handlers
{
    using Interfaces;

    /// <summary>
    /// Concrete implementation of IHandler with ICommandArguments generic type.
    /// </summary>
    public class CommandHandler : IHandler<ICommandArguments>
    {
        private readonly IRepository<ICommand> commandRepository;
 
        /// <summary>
        /// COnstructor with 1 parameter.
        /// </summary>
        /// <param name="commandRepository">IRepository object of ICommand generic type.</param>
        public CommandHandler(IRepository<ICommand> commandRepository)
        {
            this.commandRepository = commandRepository;
        }

        public void Handle(ICommandArguments inputParams)
        {
            string commandName = inputParams.Params[0];
            ICommand command = this.commandRepository.Get(commandName);
            command.CommandParams = inputParams;
            command.Execute();
        }
    }
}
