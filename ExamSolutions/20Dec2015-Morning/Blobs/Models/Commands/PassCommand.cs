namespace Blobs.Models.Commands
{
    using Enums;

    /// <summary>
    /// Pass Command class. Extends AbstractCommand.
    /// </summary>
    public class PassCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Pass.ToString().ToLower();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassCommand"/> class.
        /// </summary>
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
