namespace Blobs.Utils.OutputWriter
{
    using System;
    using Interfaces;

    /// <summary>
    /// Concrete implementation of IOutputWriter.
    /// </summary>
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string output)
        {
            Console.Write(output);
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
