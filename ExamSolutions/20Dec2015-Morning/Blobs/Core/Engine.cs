namespace Blobs.Core
{
    using Interfaces;

    public class Engine : IEngine
    {
        private readonly IHandler<ICommandArguments> commandHandler;
        private readonly ICommandArguments commandArguments;
        private readonly IInputReader inputReader;
        private readonly IUpdateable turnUpdater;
        private bool isRunning;

        public Engine(IHandler<ICommandArguments> commandHandler, ICommandArguments commandArguments,
            IInputReader inputReader, IUpdateable turnUpdater)
        {
            this.commandHandler = commandHandler;
            this.commandArguments = commandArguments;
            this.inputReader = inputReader;
            this.turnUpdater = turnUpdater;
            this.isRunning = false;
        }

        public void Run()
        {
            this.isRunning = true;
            while (this.isRunning)
            {
                string[] inputParameters = this.GetInputParameters();
                this.commandArguments.Params = inputParameters;
                this.commandHandler.Handle(this.commandArguments);
                this.turnUpdater.Update();
            }
        }

        public void Stop()
        {
            this.isRunning = false;
        }

        private string[] GetInputParameters()
        {
            string[] inputParameters = this.inputReader.ReaderLine().Trim().Split(' ');
            return inputParameters;
        }
    }
}
