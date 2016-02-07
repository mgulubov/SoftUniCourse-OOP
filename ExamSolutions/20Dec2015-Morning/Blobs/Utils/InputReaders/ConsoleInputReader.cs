namespace Blobs.Utils.InputReaders
{
    using System;
    using Interfaces;

    /// <summary>
    /// COncrete implementation of IInputReader.
    /// </summary>
    public class ConsoleInputReader : IInputReader
    {
        public string ReaderLine()
        {
            return Console.ReadLine();
        }
    }
}
