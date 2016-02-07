namespace Blobs.Models.Commands
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    /// <summary>
    /// Status command class. Extends AbstractCommand.
    /// </summary>
    public class StatusCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Status.ToString().ToLower();

        /// <summary>
        /// Initialises the base constructor with the value of the Name constant.
        /// </summary>
        public StatusCommand()
            : base(Name)
        {
        }

        public override void Execute()
        {
            IEnumerable<IBlob> blobs = this.CommandParams.BlobRepository.GetAll();
            IOutputWriter writer = this.CommandParams.OutputWriter;
            foreach (IBlob blob in blobs)
            {
                writer.WriteLine(blob.ToString());
            }
        }
    }
}
