using IntroAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class ArtistController : ApiController
    {
        public ApplicationDbContext dbContext = new ApplicationDbContext();

        [System.Web.Http.HttpGet]
        public IEnumerable Get()
        {
            var products = dbContext.Artist;
            return products;
        }

        // GET: api/Artist/5
        public Artist Get(int id)
        {
            var artist = dbContext.Artist.Find(id);
            return artist;
        }

        // POST: api/Artist
        [System.Web.Http.HttpPost]
        public HttpResponseMessage Post(Artist a)
        {
            if (a == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            dbContext.Artist.Add(a);
            dbContext.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        // DELETE: api/Artist/5
        public void Delete(int id)
        {

            var artist = dbContext.Artist.Find(id);

            if (artist.ArtistId != 0)
            {
                Artist artistToDelete = dbContext.Artist.Find(id);

                dbContext.Artist.Remove(artist);
                dbContext.SaveChanges();
            }

        }

        [System.Web.Http.HttpPut]
        public HttpResponseMessage Put(int id, Artist a)
        {
            var artist = dbContext.Artist.Find(id);

            if (artist == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            artist.Name = a.Name;
            dbContext.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.OK);

        }
    }
}
