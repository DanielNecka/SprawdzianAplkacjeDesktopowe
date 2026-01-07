using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    internal class Person
    {
        protected int id;
        protected string name;
        protected string surname;
        public Person(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
        public virtual string SchowData()
        {
            return $"id: {id}, Imię: {name}, Nazwisko: {surname}";
        }
    }
}
