namespace Blobs.Utils.Factories
{
    using System;
    using System.Reflection;
    using Interfaces;

    /// <summary>
    /// IFactory class for creating ICommand objects.
    /// </summary>
    public class CommandFactory : IFactory<ICommand>
    {
        /// <summary>
        /// Singleton object - Singleton [GOF]
        /// </summary>
        public static readonly IFactory<ICommand> Instance = new CommandFactory();
        private const string FullyQulifiedNamePattern = "Blobs.Models.Commands.{0}, {1}";
        private readonly string assemblyInfo = Assembly.GetExecutingAssembly().FullName;

        private CommandFactory()
        {
        }

        public ICommand Create(string[] parameters)
        {
            string className = parameters[0];
            string fullyQualifiedClassName = this.GetFullyQualifiedClassName(className);
            Type classType = this.GetClassType(fullyQualifiedClassName);
            ICommand command = this.CreateCommandObject(classType);

            return command;
        }

        private string GetFullyQualifiedClassName(string className)
        {
            string fullyQualifiedClassName = string.Format(FullyQulifiedNamePattern, className + "Command", this.assemblyInfo);
            return fullyQualifiedClassName;
        }

        private Type GetClassType(string fullyQualifiedClassName)
        {
            Type classType = Type.GetType(fullyQualifiedClassName);
            return classType;
        }

        private ICommand CreateCommandObject(Type classType)
        {
            ICommand commandObject = (ICommand)Activator.CreateInstance(classType);
            return commandObject;
        }
    }
}
