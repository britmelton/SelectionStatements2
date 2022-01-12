using System;

namespace SelectionStatments2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case exercise 

            Console.WriteLine("what is your favorite subject in school?");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("math is evil");
                    break;
                case "literature":
                    Console.WriteLine("reading is fun");
                    break;
                case "science":
                    Console.WriteLine("science can change the world");
                    break;
                case "social studies":
                    Console.WriteLine("history is important");
                    break;
                case "physical education":
                    Console.WriteLine("physical education helps you stay active!");
                    break;
                default:
                    Console.WriteLine("knowledge is valuable");
                    break;
            }
        }
    }
}
