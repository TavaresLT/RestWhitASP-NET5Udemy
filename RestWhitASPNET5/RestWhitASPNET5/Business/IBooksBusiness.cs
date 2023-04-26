using RestWhitASPNET5.Models;
using System.Collections.Generic;

namespace RestWhitASPNET5.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books books);
        Books FindById(long Id);
        List<Books> FindAll();
        Books Update(Books books);
        void Delete(long Id);
    }
}
