using System.Reflection;

namespace Blobs.Utils.Factories
{
    using System;
    using Interfaces;
    using Enums;

    public class AttackFactory : IFactory<IAttack>
    {
        private const string FullyQulifiedNamePattern = "Blobs.Models.Attack.{0}, {1}";
        private readonly string assemblyInfo = Assembly.GetExecutingAssembly().FullName;
        public static readonly IFactory<IAttack> Instance = new AttackFactory();

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

            Type classType = Type.GetType(string.Format(FullyQulifiedNamePattern, attackName + "Attack", assemblyInfo));
            IAttack attack = (IAttack)Activator.CreateInstance(classType);

            return attack;
        }

        private bool AttackIsNotSupported(string attackName)
        {
            return !Enum.IsDefined(typeof (AttackTypes), attackName);
        }
    }
}
