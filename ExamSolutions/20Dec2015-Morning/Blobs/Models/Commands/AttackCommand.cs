namespace Blobs.Models.Commands
{
    using Enums;
    using Interfaces;

    public class AttackCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Attack.ToString().ToLower();

        public AttackCommand()
            : base(Name)
        {
        }

        public override void Execute()
        {
            string attackerName = (string) this.CommandParams.Params[1];
            string targetName = (string) this.CommandParams.Params[2];
            IRepository<IBlob> repo = this.CommandParams.BlobRepository;

            IBlob attacker = repo.Get(attackerName);
            IBlob target = repo.Get(targetName);

            attacker.Attack(target);
        }
    }
}
