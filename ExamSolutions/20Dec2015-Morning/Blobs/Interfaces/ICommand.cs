namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Command objects.
    /// </summary>
    public interface ICommand : IExecutable
    {
        /// <summary>
        /// Gets the Command Name value.
        /// </summary>
        string CommandName { get; }

        /// <summary>
        /// Sets the Command parameters value.
        /// </summary>
        ICommandArguments CommandParams { set; }
    }
}
