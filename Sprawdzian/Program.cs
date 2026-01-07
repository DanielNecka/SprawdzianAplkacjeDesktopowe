using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "exam.txt";

            string[] data = File.ReadAllLines(file);

            foreach (string line in data) 
            {
                string[] split = line.Split(';');

                if (!line.StartsWith("#"))
                {
                    Student student = new Student(int.Parse(split[0]), split[1], split[2], split[3]);
                    Exam exam = new Exam(split[4], int.Parse(split[5]), $"{split[1]} {split[2]}");

                    Console.WriteLine($"{exam.ShowData()}\n");
                }
            }
        }
    }
}
