using RestWhitASPNET5.Models;
using System.Collections.Generic;

namespace RestWhitASPNET5.Repository
{
    public interface IBooksRepository
    {
        Books Create(Books books);
        Books FindById(long Id);
        List<Books> FindAll();
        Books Update(Books books);
        void Delete(long Id);
        bool Exists(long id);
    }
}
