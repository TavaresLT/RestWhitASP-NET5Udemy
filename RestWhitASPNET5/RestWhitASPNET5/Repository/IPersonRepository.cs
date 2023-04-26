using RestWhitASPNET5.Models;
using System.Collections.Generic;

namespace RestWhitASPNET5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
        bool Exists(long id);
    }
}
