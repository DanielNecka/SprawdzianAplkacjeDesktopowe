using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sprawdzian
{
    //*********************************************************************
    //klasa: Student
    //opis: klasa przedstawia ucznia, dziedziczy po klasie Person
    //pola: <id - indexer osoby>
    //      <name - imię osoby> 
    //      <surname - nazwisko osoby>
    //      <clas - klasa ucznia>
    //autor: Daniel Nęcka
    //*********************************************************************
    internal class Student : Person
    {
        private string clas;

        public Student(int id, string name, string surname, string clas) : base(id, name, surname)
        {
            this.clas = clas;
        }

        public override string SchowData()
        {
            return $"id: {id}, Imię: {name}, Nazwisko: {surname}, Klasa: {clas}";
        }
    }
}
