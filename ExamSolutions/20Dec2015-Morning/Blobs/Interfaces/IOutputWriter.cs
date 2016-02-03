namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Output Writer objects.
    /// </summary>
    public interface IOutputWriter
    {
        /// <summary>
        /// Method for writing a string to the output stream.
        /// </summary>
        /// <param name="output">The string to be written.</param>
        void Write(string output);

        /// <summary>
        /// Method for writing a string to the output stream. Inserts a new line after the string has been written.
        /// </summary>
        /// <param name="output">The string to be written.</param>
        void WriteLine(string output);
    }
}
