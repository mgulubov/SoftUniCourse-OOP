namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Handler objects.
    /// </summary>
    /// <typeparam name="T">Arguments required by the Handle method.</typeparam>
    public interface IHandler<in T> where T : IArguments
    {
        /// <summary>
        /// Method for handling the passed parameters.
        /// </summary>
        /// <param name="inputParams">Parameters to be handled, passed as an IArguments object.</param>
        void Handle(T inputParams);
    }
}
