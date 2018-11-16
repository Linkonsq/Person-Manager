using PMEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRepository
{
    public class PersonRepository
    {
        private PersonDBContext context = new PersonDBContext();

        public List<Person> GetAll()
        {
            return this.context.People.ToList();
            //return this.context.People.Where(p => p.Name.Contains("a") || p.Email.Contains("a")).ToList();
            //return new List<Person>();
        }

        public Person Get(int id)
        {
            //var result = from p in this.context.People
            //             where p.Id == id
            //             select p;
            //List<Person> plist = result.ToList();
            //return plist[0];

            return this.context.People.SingleOrDefault(p => p.Id == id);
        }

        public int Insert(Person person)
        {
            this.context.People.Add(person);
            return this.context.SaveChanges();
        }

        public int Update(Person person)
        {
            Person personToUpdate = this.Get(person.Id);
            personToUpdate.Name = person.Name;
            personToUpdate.Email = person.Email;
            personToUpdate.Age = person.Age;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Person personToDelete = this.Get(id);
            this.context.People.Remove(personToDelete);
            return this.context.SaveChanges();
        }
    }
}