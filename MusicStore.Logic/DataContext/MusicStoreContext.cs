using MusicStore.Logic.Contracts;

namespace MusicStore.Logic.DataContext
{
    /// <summary>
    /// Represents the data context for the Music Store application.
    /// </summary>
    public sealed class MusicStoreContext : IContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicStoreContext"/> class.
        /// </summary>
        public MusicStoreContext()
        {
        }

        #region methods
        /// <summary>
        /// Saves changes to the data context.
        /// </summary>
        /// <returns>Returns the count of saved items.</returns>
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion methods
    }
}
