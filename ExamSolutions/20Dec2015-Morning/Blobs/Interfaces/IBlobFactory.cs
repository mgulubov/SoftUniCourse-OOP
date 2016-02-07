namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for IBlobFactory objects.
    /// </summary>
    public interface IBlobFactory : IFactory<IBlob>
    {
        /// <summary>
        /// Sets the Behavior factory object.
        /// </summary>
        IFactory<IBehavior> BehaviorFactory { set; }

        /// <summary>
        /// Sets the Attack factory object.
        /// </summary>
        IFactory<IAttack> AttackFactory { set; } 
    }
}
