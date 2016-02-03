namespace Blobs.Utils.Handlers
{
    using Interfaces;

    public class CommandArguments : ICommandArguments
    {
        public CommandArguments(IRepository<IBlob> blobRepository, IOutputWriter outputWriter, string[] parameters = null)
        {
            this.BlobRepository = blobRepository;
            this.OutputWriter = outputWriter;
            this.Params = parameters;
        }

        public IRepository<IBlob> BlobRepository { get; private set; }

        public IOutputWriter OutputWriter { get; private set; }

        public IStopable Stopable { get; set; }

        public string[] Params { get; set; }
    }
}
