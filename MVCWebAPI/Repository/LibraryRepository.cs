using MVCWebAPI.DataAccess;
using MVCWebAPI.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MVCWebAPI.Repository
{
    public class LibraryRepository
    {
        private LibraryContext db;

        public LibraryRepository()
        {
            db = new LibraryContext();
        }
        public void Add(Book b)
        {
            if(b!=null)
            {
                bool exists=false;
                bool checking = true;
                int index = 1;
                foreach(var book in Sort())
                {
                    if(book.ISBN==b.ISBN)
                    {
                        exists=true;
                        break;
                    }
                    if (index != book.ISBN && checking == true)
                    {
                        b.ISBN = index;
                        checking = false;
                    }
                    index++;
                }
                if(exists==false) 
                {
                    if (b.ISBN == 0) { b.ISBN = index; }
                    db.Books.Add(b);
                    db.SaveChanges();
                }
            }
        }
        public void Edit(Book book)
        {
            //Edits the element without removing and inserting it
            db.Entry(book).State = EntityState.Modified;
            //Saves the new Data in the Database
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Book bookToRemove = db.Books.Where(book=>book.ISBN==id).SingleOrDefault();
            if(bookToRemove!=null)
            {
                db.Books.Remove(bookToRemove);
                bookToRemove = null;
                db.SaveChanges();
            }
        }
        public Book GetBook(int id)
        {
            return db.Books.Where(book=>book.ISBN==id).FirstOrDefault();
        }
        public IEnumerable<Book> GetAll()
        {
            return db.Books;
        }
        public IEnumerable<Book>Sort()
        {
            return db.Books.OrderBy(book=>book.ISBN);
        }
    }
}