namespace Blobs.Utils.Factories
{
    using System;
    using Interfaces;
    using Models;

    public class BlobFactory : IFactory<IBlob>
    {
        public static readonly IFactory<IBlob> Instance = new BlobFactory();
        private readonly IFactory<IBehavior> behaviorFactory;
        private readonly IFactory<IAttack> attackFactory; 

        private BlobFactory()
        {
            this.behaviorFactory = BehaviorFactory.Instance;
            this.attackFactory = AttackFactory.Instance; 
        }

        public IBlob Create(string[] parameters)
        {
            string blobName = parameters[0];
            int blobHealth = this.TryParseToInt(parameters[1], ErrorMessages.HealthValueIsInvalid);
            int blobDamage = this.TryParseToInt(parameters[2], ErrorMessages.DamageValueIsInvalid);
            IAttack attack = this.attackFactory.Create(new[] { parameters[3] });
            IBehavior behavior = this.behaviorFactory.Create(new []{parameters[4]});

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
