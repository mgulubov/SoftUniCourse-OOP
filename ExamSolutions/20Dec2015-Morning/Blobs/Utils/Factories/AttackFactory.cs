namespace Blobs.Utils.Factories
{
    using System;
    using System.Reflection;
    using Enums;
    using Interfaces;

    /// <summary>
    /// Concrete implementation of IFactory. Has an IAttack generic type.
    /// Implements the Singleton pattern - Singleton [GOF].
    /// </summary>
    public class AttackFactory : IFactory<IAttack>
    {
        /// <summary>
        /// Public constant which is the singleton object for this class.
        /// </summary>
        public static readonly IFactory<IAttack> Instance = new AttackFactory();
        private const string FullyQulifiedNamePattern = "Blobs.Models.Attack.{0}, {1}";
        private readonly string assemblyInfo = Assembly.GetExecutingAssembly().FullName;

        /// <summary>
        /// Prevents a default instance of the <see cref="AttackFactory"/> class from being created.
        /// </summary>
        private AttackFactory()
        {
        }

        public IAttack Create(string[] parameters)
        {
            string attackName = parameters[0];
            if (this.AttackIsNotSupported(attackName))
            {
                throw new ArgumentOutOfRangeException(attackName, ErrorMessages.AttackIsNotSupported);
            }

            Type classType = Type.GetType(string.Format(FullyQulifiedNamePattern, attackName + "Attack", this.assemblyInfo));
            IAttack attack = (IAttack)Activator.CreateInstance(classType);

            return attack;
        }

        private bool AttackIsNotSupported(string attackName)
        {
            return !Enum.IsDefined(typeof(AttackTypes), attackName);
        }
    }
}
