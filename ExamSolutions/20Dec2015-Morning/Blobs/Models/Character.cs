namespace Blobs.Models
{
    using System;
    using Interfaces;
    using Utils;

    public abstract class Character : ICharacter
    {
        private string name;

        protected Character(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException(value, ErrorMessages.InvalidCharacterName);
                }
                this.name = value;
            }
        }
    }
}
