namespace Blobs.Utils.Handlers
{
    using Interfaces;

    /// <summary>
    /// Concrete implementation of ICommandArguments.
    /// </summary>
    public class CommandArguments : ICommandArguments
    {
        /// <summary>
        /// COnstructor with 3 parameters.
        /// </summary>
        /// <param name="blobRepository">IRepository object of generic type IBlob.</param>
        /// <param name="outputWriter">IOutputWriter object.</param>
        /// <param name="parameters">Optional string array. Default value is null.</param>
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
