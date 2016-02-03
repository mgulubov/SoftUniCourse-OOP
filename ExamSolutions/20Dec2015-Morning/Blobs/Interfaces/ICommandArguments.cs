namespace Blobs.Interfaces
{
    public interface ICommandArguments : IArguments
    {
        IRepository<IBlob> BlobRepository { get; }

        IOutputWriter OutputWriter { get; }

        IStopable Stopable { get; set; }
    }
}
