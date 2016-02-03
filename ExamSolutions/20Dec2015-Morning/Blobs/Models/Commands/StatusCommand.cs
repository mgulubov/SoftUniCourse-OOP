namespace Blobs.Models.Commands
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public class StatusCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Status.ToString().ToLower();

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
