namespace Blobs.Models.Commands
{
    using Enums;
    using Interfaces;

    /// <summary>
    /// Attack command class. Extends AbstractCommand.
    /// </summary>
    public class AttackCommand : AbstractCommand
    {
        private static readonly string Name = CommandTypes.Attack.ToString().ToLower();

        /// <summary>
        /// Initialises the base constructor with the value of the constant Name.
        /// </summary>
        public AttackCommand()
            : base(Name)
        {
        }

        public override void Execute()
        {
            string attackerName = (string)this.CommandParams.Params[1];
            string targetName = (string)this.CommandParams.Params[2];
            IRepository<IBlob> repo = this.CommandParams.BlobRepository;

            IBlob attacker = repo.Get(attackerName);
            IBlob target = repo.Get(targetName);

            attacker.Attack(target);
        }
    }
}
