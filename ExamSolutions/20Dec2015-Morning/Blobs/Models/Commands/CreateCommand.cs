namespace Blobs.Models.Commands
{
    using Enums;
    using Interfaces;
    using Utils.Factories;

    public class CreateCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Create.ToString().ToLower();
        private readonly IFactory<IBlob> blobFactory = BlobFactory.Instance;

        public CreateCommand()
            : base(Name)
        {
        }

        public override void Execute()
        {
            string blobName = this.CommandParams.Params[1];
            string blobHealth = this.CommandParams.Params[2];
            string blobDamage = this.CommandParams.Params[3];
            string blobBehavior = this.CommandParams.Params[4];
            string blobAttack = this.CommandParams.Params[5];
            IRepository<IBlob> blobRepo = this.CommandParams.BlobRepository;

            IBlob blob = this.blobFactory.Create(new[] {blobName, blobHealth, blobDamage, blobAttack, blobBehavior});
            blobRepo.Add(blob);
        }
    }
}
