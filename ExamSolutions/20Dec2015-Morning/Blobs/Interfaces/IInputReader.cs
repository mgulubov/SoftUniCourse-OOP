namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for InputReader objects.
    /// </summary>
    public interface IInputReader
    {
        /// <summary>
        /// Returns a single line from the input stream.
        /// </summary>
        /// <returns>A string representing the read line.</returns>
        string ReaderLine();
    }
}
