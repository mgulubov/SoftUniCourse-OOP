using System.Reflection;

namespace Blobs.Utils.Factories
{
    using System;
    using Interfaces;
    using Enums;

    public class BehaviorFactory : IFactory<IBehavior>
    {
        private const string FullyQulifiedNamePattern = "Blobs.Models.Behavior.{0}, {1}";
        private readonly string assemblyInfo = Assembly.GetExecutingAssembly().FullName;
        public static readonly IFactory<IBehavior> Instance = new BehaviorFactory();

        private BehaviorFactory()
        {
        }

        public IBehavior Create(string[] parameters)
        {
            string behaviorName = parameters[0];
            if (this.BehaviorIsNotSupported(behaviorName))
            {
                throw new ArgumentOutOfRangeException(behaviorName, ErrorMessages.BehaviorNotSupported);
            }

            Type classType = Type.GetType(string.Format(FullyQulifiedNamePattern, behaviorName + "Behavior", assemblyInfo));
            IBehavior behavior = (IBehavior)Activator.CreateInstance(classType);

            return behavior;
        }

        private bool BehaviorIsNotSupported(string behaviorName)
        {
            return !Enum.IsDefined(typeof(BehaviorTypes), behaviorName);
        }
    }
}
