using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.WebAPI.Controllers;

using TGenre = Models.ModelGenre;
using Factory = Logic.DataContext.Factory;

[Route( "api/[controller]" )]
[ApiController]
public class GenresController : ControllerBase
{
        public const int MaxCount = 500;

        // GET: api/<GenresController>
        [HttpGet]
        public IEnumerable<TGenre> Get( )
        {
                using var context = Factory.CreateContext( );

                return [ .. context.GenreSet.Take( MaxCount ).AsNoTracking( ).Select( g => TGenre.Create( g ) ) ];
        }

        // GET api/<GenresController>/5
        [HttpGet( "{id}" )]
        public TGenre? Get( int id )
        {
                using var context = Factory.CreateContext( );

                var result = context.GenreSet.FirstOrDefault( e => e.Id == id );

                return result != null ? TGenre.Create( result ) : null;
        }

        // POST api/<GenresController>
        [HttpPost]
        public void Post( [FromBody] TGenre genre )
        {
                using var context = Factory.CreateContext( );

                var result = new Logic.Entities.Genre( );

                if(genre != null)
                {
                        result.CopyProperties( genre );

                        context.GenreSet.Add( result );

                        context.SaveChanges( );
                }
        }

        // PUT api/<GenresController>/5
        [HttpPut( "{id}" )]
        public void Put( int id , [FromBody] TGenre genre )
        {
                using var context = Factory.CreateContext( );

                var result = context.GenreSet.FirstOrDefault( e => e.Id == id );

                if(result != null)
                {
                        result.CopyProperties( genre );

                        context.SaveChanges( );
                }
        }

        // DELETE api/<GenresController>/5
        [HttpDelete( "{id}" )]
        public void Delete( int id )
        {
                using var context = Factory.CreateContext( );

                var result = context.GenreSet.FirstOrDefault( e => e.Id == id );

                if(result != null)
                {
                        context.GenreSet.Remove( result! );

                        context.SaveChanges( );
                }
        }
}
