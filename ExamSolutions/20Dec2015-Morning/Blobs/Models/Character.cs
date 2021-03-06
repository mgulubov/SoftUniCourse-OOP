﻿namespace Blobs.Models
{
    using System;
    using Interfaces;
    using Utils;

    /// <summary>
    /// Abstract implementation of IChracter.
    /// </summary>
    public abstract class Character : ICharacter
    {
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="name">The character Name.</param>
        protected Character(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

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
