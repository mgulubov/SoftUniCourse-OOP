namespace Blobs
{
    using Core;
    using Interfaces;
    using Utils.Handlers;
    using Utils.InputReaders;
    using Utils.OutputWriter;
    using Utils.Repos;

    /// <summary>
    /// Class contaioning the project's Main method.
    /// </summary>
    public static class BlobsMain
    {
        /// <summary>
        /// The Main method of the project.
        /// </summary>
        /// <param name="args">Arguments passed to the Main method.</param>
        public static void Main(string[] args)
        {
            IRepository<ICommand> commandRepository = new CommandRepository();
            IHandler<ICommandArguments> commandHandler = new CommandHandler(commandRepository);
            IInputReader inputReader = new ConsoleInputReader();
            IOutputWriter outputWriter = new ConsoleOutputWriter();
            IRepository<IBlob> blobRepository = new BlobRepository();
            ICommandArguments commandArguments = new CommandArguments(blobRepository, outputWriter);
            IEngine gameEngine = new Engine(commandHandler, commandArguments, inputReader, (IUpdateable)blobRepository);
            commandArguments.Stopable = gameEngine;

            gameEngine.Run();
        }
    }
}
