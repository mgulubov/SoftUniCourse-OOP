using System.Reflection;

namespace Blobs.Utils.Repos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Interfaces;

    public class CommandRepository : IRepository<ICommand>
    {
        private const string FullyQulifiedNamePattern = "Blobs.Models.Commands.{0}, {1}";
        private readonly string assemblyInfo = Assembly.GetExecutingAssembly().FullName;
        private readonly IDictionary<string, ICommand> commands;

        public CommandRepository()
        {
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
                Type type = Type.GetType(string.Format(FullyQulifiedNamePattern, commandClass + "Command", assemblyInfo));
                ICommand commandObject = (ICommand) Activator.CreateInstance(type);
                
                this.commands.Add(commandObject.CommandName, commandObject);
            }
        }
    }
}
