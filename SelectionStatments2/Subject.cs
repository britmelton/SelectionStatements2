using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatments2
{
    public class Subject
    {
        public static void GetSchoolSubject()
        {
            Console.WriteLine("what is your favorite subject in school?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("\nmath is evil");
                    break;
                case "literature":
                    Console.WriteLine("\nreading is fun");
                    break;
                case "science":
                    Console.WriteLine("\nscience can change the world");
                    break;
                case "social studies":
                    Console.WriteLine("\nhistory is important");
                    break;
                case "physical education":
                    Console.WriteLine("\nphysical education helps you stay active!");
                    break;
                default:
                    Console.WriteLine("\nknowledge is valuable");
                    break;
            }
           
        }

    }
}
