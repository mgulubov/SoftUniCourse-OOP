namespace Blobs.Core
{
    using Interfaces;

    /// <summary>
    /// Concrete implementation of IEngine. Requires four objects, in order to work properly:
    /// 1 - IHandler - Must be of generic class ICommandArguments. Used for handling the commands that are received from the input.
    /// 2 - ICommandArguments - The command arguments that will be passed to the IHandler object.
    /// 3 - IInputReader - Used for receiving the input data.
    /// 4 - IUpdateable - An object updated on every turn.
    /// </summary>
    public class Engine : IEngine
    {
        private readonly IHandler<ICommandArguments> commandHandler;
        private readonly ICommandArguments commandArguments;
        private readonly IInputReader inputReader;
        private readonly IUpdateable turnUpdater;
        private bool isRunning;

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class.
        /// </summary>
        /// <param name="commandHandler">IHandler object.</param>
        /// <param name="commandArguments">ICommandArguments object.</param>
        /// <param name="inputReader">IInputReader object.</param>
        /// <param name="turnUpdater">IUpdateable object.</param>
        public Engine(
            IHandler<ICommandArguments> commandHandler, 
            ICommandArguments commandArguments,
            IInputReader inputReader, 
            IUpdateable turnUpdater)
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
