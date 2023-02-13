using RestWhitASPNET5.Models;
using System.Collections.Generic;

namespace RestWhitASPNET5.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);     
        void Delete(long Id);
    }
}
