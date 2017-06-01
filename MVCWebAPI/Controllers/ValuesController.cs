using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web;

namespace MVCWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        static List<Models.Book> Books;

        //Constructor
        public ValuesController()
        {
            Books = new List<Models.Book>(){

            new Models.Book
            {
                ISBN = 1,
                Title = "Lorem Ipsum",
                Author = "Nobody",
                Description = "Nothing is impossible",
                PublishedYear = 1997
            },
            new Models.Book
            {
                ISBN = 2,
                Title = "Lorem Ipsum2",
                Author = "Anyone",
                Description = "Anyone can do it",
                PublishedYear = 2000
            },
            new Models.Book
            {
                ISBN = 3,
                Title = "Lorem Ipsum3",
                Author = "Someone",
                Description = "Someone is Coding",
                PublishedYear = 1959
            }
            };
        }
        // GET api/values
        public IEnumerable<Models.Book> Get()
        {
            return Books;
        }

        // GET api/values/5
        public Models.Book Get(int id)
        {
            return Books.Where(book=>book.ISBN==id).FirstOrDefault();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        public void Create(Models.Book book)
        {
            Books.Add(book);
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
            Models.Book rBook = Get(id);
            if(rBook!=null)
            {
                Books.Remove(rBook);
            }
        }
    }
}
