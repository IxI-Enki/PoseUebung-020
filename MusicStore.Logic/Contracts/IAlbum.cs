namespace MusicStore.Logic.Contracts
{
    /// <summary>
    /// Represents an album in the music store.
    /// </summary>
    public interface IAlbum : IIdentifiable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the artist ID.
        /// </summary>
        int ArtistId { get; set; }

        /// <summary>
        /// Gets or sets the title of the album.
        /// </summary>
        string Title { get; set; }
        #endregion Properties
    }
}
