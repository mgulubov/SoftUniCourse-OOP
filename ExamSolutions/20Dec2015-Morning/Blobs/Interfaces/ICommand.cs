namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Command objects.
    /// </summary>
    public interface ICommand : IExecutable
    {
        /// <summary>
        /// Command Name property.
        /// </summary>
        string CommandName { get; }

        /// <summary>
        /// Command parameters property.
        /// </summary>
        ICommandArguments CommandParams { set; }
    }
}
