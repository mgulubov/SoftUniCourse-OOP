namespace Blobs.Utils.InputReaders
{
    using System;
    using Interfaces;

    public class ConsoleInputReader : IInputReader
    {
        public string ReaderLine()
        {
            return Console.ReadLine();
        }
    }
}
