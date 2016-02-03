namespace Blobs.Models.Commands
{
    using Enums;

    public class PassCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Pass.ToString().ToLower();

        public PassCommand()
            : base(Name)
        {
        }

        public override void Execute()
        {
            return;
        }
    }
}
