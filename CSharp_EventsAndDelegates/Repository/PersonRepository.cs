using CSharp_EventsAndDelegates.Models;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_EventsAndDelegates.Repository
{
    public class PersonRepository : IEnumerable
    {
        Dictionary<int, Person> people;

        public PersonRepository()
        {
            people = new Dictionary<int, Person>();
            CreatePeople();
        }

        private void CreatePeople()
        {
            people.Add(1, new Person { Id = 1, Name = "Peter" });
            people.Add(2, new Person { Id = 2, Name = "Mary" });
            people.Add(3, new Person { Id = 3, Name = "John" });
            people.Add(4, new Person { Id = 4, Name = "Tracey" });
        }

        public Person this[int personid]
        {
            get { return people[personid]; }
            set { people[value.Id] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return people.GetEnumerator();
        }
    }
}
