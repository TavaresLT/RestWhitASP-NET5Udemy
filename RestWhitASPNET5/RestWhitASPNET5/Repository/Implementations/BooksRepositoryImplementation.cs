using RestWhitASPNET5.Models;
using RestWhitASPNET5.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWhitASPNET5.Repository.Implementations
{
    public class BooksRepositoryImplementation : IBooksRepository
    {
        private MySQLContext context;

        public BooksRepositoryImplementation(MySQLContext context)
        {
            this.context = context;
        }

        public List<Books> FindAll() 
        {
            return context.Books.ToList();
        }

        public Books FindById(long id) 
        {
            return context.Books.SingleOrDefault(b => b.Id.Equals((int)id)); ;

        }

        public Books Create(Books books) 
        {
            try 
            {
                context.Add(books);
                context.SaveChanges();
            } 
            catch (Exception)
            {
                throw;
            }
            return books;
        }

        public Books Update(Books books)
        {
            if (!Exists(books.Id)) return null;

            var result = FindById(books.Id);

            if (result != null) 
            {
                try
                {
                    context.Entry(result).CurrentValues.SetValues(books);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return books;
        }

        public void Delete(long id)
        {
            var result = FindById(id);

            if (result != null)
            {
                try
                {
                    context.Books.Remove(result);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return context.Books.Any(b => b.Id == id);
        }
    }
}
