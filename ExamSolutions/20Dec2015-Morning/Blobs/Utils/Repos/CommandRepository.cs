namespace Blobs.Utils.Repos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Factories;
    using Interfaces;

    /// <summary>
    /// Concrete implementation of IRepository with ICommand generic type. 
    /// Implements IUpdateable.
    /// </summary>
    public class CommandRepository : IRepository<ICommand>, IUpdateable
    {
        private static readonly IFactory<ICommand> DefaultCommandFactory = CommandFactory.Instance; 
        private readonly IDictionary<string, ICommand> commands;
        private readonly IFactory<ICommand> commandFactory; 

        /// <summary>
        /// Default constructor. Calls the constructor overload with a default command factory object.
        /// </summary>
        public CommandRepository()
            : this(DefaultCommandFactory)
        {
        }

        /// <summary>
        /// COnstructor with one parameter. Initialises the commands field and populates the commands list through the Update method.
        /// </summary>
        /// <param name="commandFactory">The command factory object to be used for creating the commands.</param>
        public CommandRepository(IFactory<ICommand> commandFactory)
        {
            this.commandFactory = commandFactory;
            this.commands = new Dictionary<string, ICommand>();
            this.Update();
        }

        public void Update()
        {
            this.commands.Clear();
            string[] enumValues = Enum.GetNames(typeof(CommandTypes)).ToArray();
            this.SeedCommands(enumValues);
        }

        public void Add(ICommand element)
        {
            if (!this.Contains(element))
            {
                this.commands.Add(element.CommandName, element);
            }
        }

        public void Remove(ICommand element)
        {
            if (this.Contains(element))
            {
                this.commands.Remove(element.CommandName);
            }
        }

        public bool Contains(ICommand element)
        {
            return this.commands.ContainsKey(element.CommandName);
        }

        public ICommand Get(string name)
        {
            return this.commands[name];
        }

        public IEnumerable<ICommand> GetAll()
        {
            return this.commands.Values;
        }

        private void SeedCommands(string[] commandClasses)
        {
            foreach (string commandClass in commandClasses)
            {
                ICommand command = this.commandFactory.Create(new[] { commandClass });
                this.commands.Add(command.CommandName, command);
            }
        }
    }
}
