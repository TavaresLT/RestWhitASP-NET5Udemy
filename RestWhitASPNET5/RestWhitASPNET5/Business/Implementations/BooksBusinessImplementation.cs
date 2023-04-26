using RestWhitASPNET5.Models;
using RestWhitASPNET5.Repository;
using System.Collections.Generic;

namespace RestWhitASPNET5.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;

        public BooksBusinessImplementation(IBooksRepository repository)
        {
            _repository = repository;
        }

        public List<Books> FindAll()
        {
            return _repository.FindAll();
        }

        public Books FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Books Create(Books person)
        {
            return _repository.Create(person);
        }

        public Books Update(Books person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
