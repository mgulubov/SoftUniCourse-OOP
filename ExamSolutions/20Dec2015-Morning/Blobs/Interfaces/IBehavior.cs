﻿namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Behavior objects
    /// </summary>
    public interface IBehavior : IUpdateable, IOwned
    {
        /// <summary>
        /// Gets a value indicating whether the Behavior is currently activated.
        /// </summary>
        bool IsActivated { get; }

        /// <summary>
        /// Gets a value indicating whether the Behavior was already used before.
        /// </summary>
        bool WasAlreadyUsed { get; }

        /// <summary>
        /// Method for activating the behavior. Has no effect if IsActivated, or WasAlreadyUsed returns TRUE.
        /// When the behavior is activated, the initial effect is applied.
        /// </summary>
        void Activate();
    }
}
