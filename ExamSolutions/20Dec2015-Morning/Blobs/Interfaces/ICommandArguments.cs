namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for command argument objects. Adds properties required for ICommand objects.
    /// </summary>
    public interface ICommandArguments : IArguments
    {
        /// <summary>
        /// Gets the Blob Repository object.
        /// </summary>
        IRepository<IBlob> BlobRepository { get; }

        /// <summary>
        /// Gets the Output Writer object.
        /// </summary>
        IOutputWriter OutputWriter { get; }

        /// <summary>
        /// Gets or sets the IStopable object.
        /// </summary>
        IStopable Stopable { get; set; }
    }
}
