using MVCWebAPI.Repository;
using System.Collections.Generic;
using System.Web.Http;

namespace MVCWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        LibraryRepository library;
        //Constructor
        public ValuesController()
        {
            library = new LibraryRepository();
        }
        // GET api/values
        public IEnumerable<Models.Book> Get()
        {
            return library.GetAll();
        }

        // GET api/values/5
        public Models.Book Get(int id)
        {
            return library.GetBook(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        public void Edit(Models.Book book)
        {
            library.Edit(book);
        }
        public void Create(Models.Book book)
        {
            library.Add(book);
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
            library.Delete(id);
        }
    }
}
