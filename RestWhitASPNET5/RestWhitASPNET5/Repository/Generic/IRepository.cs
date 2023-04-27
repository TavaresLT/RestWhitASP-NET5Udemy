using RestWhitASPNET5.Models;
using RestWhitASPNET5.Models.Base;
using System.Collections.Generic;

namespace RestWhitASPNET5.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long Id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long Id);
        bool Exists(long id);
    }
}
