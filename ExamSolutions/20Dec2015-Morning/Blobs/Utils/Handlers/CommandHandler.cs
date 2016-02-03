namespace Blobs.Utils.Handlers
{
    using Interfaces;

    public class CommandHandler : IHandler<ICommandArguments>
    {
        private readonly IRepository<ICommand> commandRepository;
 
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
