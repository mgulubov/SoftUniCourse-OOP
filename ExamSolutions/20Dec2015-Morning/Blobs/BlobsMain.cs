using System;
using System.Reflection;
using Blobs.Core;
using Blobs.Models.Attack;
using Blobs.Utils.Handlers;
using Blobs.Utils.InputReaders;
using Blobs.Utils.OutputWriter;
using Blobs.Utils.Repos;

namespace Blobs
{
    using Interfaces;

    class BlobsMain
    {
        static void Main(string[] args)
        {
            IRepository<ICommand> commandRepository = new CommandRepository();
            IHandler<ICommandArguments> commandHandler = new CommandHandler(commandRepository);
            IInputReader inputReader = new ConsoleInputReader();
            IOutputWriter outputWriter = new ConsoleOutputWriter();
            IRepository<IBlob> blobRepository = new BlobRepository();
            ICommandArguments commandArguments = new CommandArguments(blobRepository, outputWriter);
            IEngine gameEngine = new Engine(commandHandler, commandArguments, inputReader, blobRepository);
            commandArguments.Stopable = gameEngine;

            gameEngine.Run();
        }
    }
}
