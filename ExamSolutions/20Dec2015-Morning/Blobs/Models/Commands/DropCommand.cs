namespace Blobs.Models.Commands
{
    using Enums;
    using Interfaces;

    public class DropCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Drop.ToString().ToLower();

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
