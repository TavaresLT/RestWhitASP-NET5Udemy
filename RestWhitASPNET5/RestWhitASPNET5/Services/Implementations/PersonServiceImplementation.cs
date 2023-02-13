using RestWhitASPNET5.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWhitASPNET5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++) 
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long Id)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "Milton",
                LastName = "Yama",
                Addres = "GM",
                Gender = "Indefinido"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Addres = "Some Addres"+ i,
                Gender = "Indefinido"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
