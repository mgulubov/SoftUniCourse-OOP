namespace Blobs.Utils.Factories
{
    using System;
    using Interfaces;
    using Models;

    /// <summary>
    /// Concrete implementation of IBlobFactory.
    /// Implements the Singleton pattern - Singleton [GOF].
    /// </summary>
    public class BlobFactory : IBlobFactory
    {
        /// <summary>
        /// Public constant which is the singleton object for this class.
        /// </summary>
        public static readonly IBlobFactory Instance = new BlobFactory();

        /// <summary>
        /// Private default constructor.
        /// </summary>
        private BlobFactory()
        {
            this.BehaviorFactory = Factories.BehaviorFactory.Instance;
            this.AttackFactory = Factories.AttackFactory.Instance; 
        }

        public IFactory<IBehavior> BehaviorFactory { private get; set; }

        public IFactory<IAttack> AttackFactory { private get; set; }

        public IBlob Create(string[] parameters)
        {
            string blobName = parameters[0];
            int blobHealth = this.TryParseToInt(parameters[1], ErrorMessages.HealthValueIsInvalid);
            int blobDamage = this.TryParseToInt(parameters[2], ErrorMessages.DamageValueIsInvalid);
            IAttack attack = this.AttackFactory.Create(new[] { parameters[3] });
            IBehavior behavior = this.BehaviorFactory.Create(new[] { parameters[4] });

            return new Blob(blobName, blobHealth, blobDamage, attack, behavior);
        }

        private int TryParseToInt(string value, string errorMessage)
        {
            int result;
            bool tryParse = int.TryParse(value, out result);
            if (!tryParse)
            {
                throw new ArgumentOutOfRangeException(value, errorMessage);
            }

            return result;
        }
    }
}
