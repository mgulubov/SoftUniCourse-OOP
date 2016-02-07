namespace Blobs.Utils.Factories
{
    using System;
    using System.Reflection;
    using Enums;
    using Interfaces;

    /// <summary>
    /// Concrete implementation of IFactory. Has an IBehavior generic type.
    /// Implements the Singleton pattern - Singleton [GOF].
    /// </summary>
    public class BehaviorFactory : IFactory<IBehavior>
    {
        /// <summary>
        /// Public constant which is the singleton object for this class.
        /// </summary>
        public static readonly IFactory<IBehavior> Instance = new BehaviorFactory();
        private const string FullyQulifiedNamePattern = "Blobs.Models.Behavior.{0}, {1}";
        private readonly string assemblyInfo = Assembly.GetExecutingAssembly().FullName;

        /// <summary>
        /// Prevents a default instance of the <see cref="BehaviorFactory"/> class from being created.
        /// </summary>
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

            Type classType = Type.GetType(string.Format(FullyQulifiedNamePattern, behaviorName + "Behavior", this.assemblyInfo));
            IBehavior behavior = (IBehavior)Activator.CreateInstance(classType);

            return behavior;
        }

        private bool BehaviorIsNotSupported(string behaviorName)
        {
            return !Enum.IsDefined(typeof(BehaviorTypes), behaviorName);
        }
    }
}
