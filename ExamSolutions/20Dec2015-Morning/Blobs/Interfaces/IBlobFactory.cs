namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for IBlobFactory objects.
    /// </summary>
    public interface IBlobFactory : IFactory<IBlob>
    {
        /// <summary>
        /// Property allowing the customization of the IBehavior factory object.
        /// </summary>
        IFactory<IBehavior> BehaviorFactory { set; }

        /// <summary>
        /// Property allowing the customization of the IAttack factory object.
        /// </summary>
        IFactory<IAttack> AttackFactory { set; } 
    }
}
