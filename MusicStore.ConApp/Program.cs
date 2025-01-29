namespace MusicStore.ConApp
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(/*string[] args*/)
        {
            string input = string.Empty;
            Logic.Contracts.IContext context = Logic.DataContext.Factory.CreateContext();

            while (!input.Equals("x", StringComparison.CurrentCultureIgnoreCase))
            {
                int index = 1;
                Console.Clear();
                Console.WriteLine("MusicStore");
                Console.WriteLine("==========================================");

                Console.WriteLine($"{nameof(PrintGenres),-25}....{index++}");
                Console.WriteLine($"{nameof(QueryGenres),-25}....{index++}");
                Console.WriteLine($"{nameof(AddGenre),-25}....{index++}");
                Console.WriteLine($"{nameof(DeleteGenre),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintArtists),-25}....{index++}");
                Console.WriteLine($"{nameof(QueryArtists),-25}....{index++}");
                Console.WriteLine($"{nameof(AddArtist),-25}....{index++}");
                Console.WriteLine($"{nameof(DeleteArtist),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintAlbums),-25}....{index++}");
                Console.WriteLine($"{nameof(QueryAlbums),-25}....{index++}");
                Console.WriteLine($"{nameof(AddAlbum),-25}....{index++}");
                Console.WriteLine($"{nameof(DeleteAlbum),-25}....{index++}");
                Console.WriteLine($"{nameof(PrintTracks),-25}....{index++}");
                Console.WriteLine($"{nameof(QueryTracks),-25}....{index++}");
                Console.WriteLine($"{nameof(AddTrack),-25}....{index++}");
                Console.WriteLine($"{nameof(DeleteTrack),-25}....{index++}");

                Console.WriteLine();
                Console.WriteLine($"Exit...............x");
                Console.Write("Your choice: ");

                input = Console.ReadLine()!;
                if (Int32.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            PrintGenres(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 2:
                            QueryGenres(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 3:
                            AddGenre(context);
                            break;
                        case 4:
                            DeleteGenre(context);
                            break;
                        case 5:
                            PrintArtists(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 6:
                            QueryArtists(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 7:
                            AddArtist(context);
                            break;
                        case 8:
                            DeleteArtist(context);
                            break;
                        case 9:
                            PrintAlbums(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 10:
                            QueryAlbums(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 11:
                            AddAlbum(context);
                            break;
                        case 12:
                            DeleteAlbum(context);
                            break;
                        case 13:
                            PrintTracks(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 14:
                            QueryTracks(context);
                            Console.WriteLine();
                            Console.Write("Continue with Enter...");
                            Console.ReadLine();
                            break;
                        case 15:
                            AddTrack(context);
                            break;
                        case 16:
                            DeleteTrack(context);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Prints all genres in the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void PrintGenres(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries genres based on a user-provided condition.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void QueryGenres(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new genre to the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void AddGenre(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a genre from the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void DeleteGenre(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints all artists in the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void PrintArtists(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries artists based on a user-provided condition.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void QueryArtists(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new artist to the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void AddArtist(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an artist from the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void DeleteArtist(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints all albums in the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void PrintAlbums(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries albums based on a user-provided condition.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void QueryAlbums(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new album to the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void AddAlbum(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an album from the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void DeleteAlbum(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints all tracks in the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void PrintTracks(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Queries tracks based on a user-provided condition.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void QueryTracks(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new track to the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void AddTrack(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a track from the context.
        /// </summary>
        /// <param name="context">The music store context.</param>
        private static void DeleteTrack(Logic.Contracts.IContext context)
        {
            throw new NotImplementedException();
        }
    }
}
