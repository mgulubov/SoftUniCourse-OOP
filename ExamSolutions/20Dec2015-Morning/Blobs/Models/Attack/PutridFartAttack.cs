namespace Blobs.Models.Attack
{
    using Interfaces;

    public class PutridFartAttack : AbstractAttack
    {
        public override void SetOwner(IBlob newOwner)
        {
            base.SetOwner(newOwner);
            this.Damage = newOwner.Damage;
        }
    }
}
