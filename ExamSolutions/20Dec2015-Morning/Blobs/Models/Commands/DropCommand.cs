namespace Blobs.Models.Commands
{
    using Enums;
    using Interfaces;

    /// <summary>
    /// Drop Command class. Extends AbstractCommand.
    /// </summary>
    public class DropCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Drop.ToString().ToLower();

        /// <summary>
        /// Initialises the base constructor with the value of the constant Name.
        /// </summary>
        public DropCommand()
            : base(Name)
        {
        }

        public override void Execute()
        {
            IStopable stopable = this.CommandParams.Stopable;
            stopable.Stop();
        }
    }
}
