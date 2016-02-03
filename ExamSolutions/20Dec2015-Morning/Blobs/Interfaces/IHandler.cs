namespace Blobs.Interfaces
{
    public interface IHandler<in T> where T : IArguments
    {
        void Handle(T inputParams);
    }
}
