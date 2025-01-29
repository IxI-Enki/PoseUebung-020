namespace MusicStore.Logic.Contracts
{
    public interface IContext : IDisposable
    {
        int SaveChanges();
    }
}