using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian
{
    internal class Exam
    {
        protected string subject;
        protected int result;
        protected string student;

        public Exam(string subject, int result, string student)
        {
            this.subject = subject;
            this.result = result;
            this.student = student;
        }
        private bool IsPassed(int result)
        {
            if (result >= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ShowData()
        {
            string passed;

            if (IsPassed(result))
            { 
                passed = "zaliczony"; 
            } 
            else 
            {
                passed = "niezaliczony";
            };

            return $"Przedmiot: {subject}, Wynik: {result}, Student: {student}, Egzamin: {passed}";
        }
    }
}
