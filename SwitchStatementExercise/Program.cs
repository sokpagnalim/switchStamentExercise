using System;

namespace SwitchStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            String subject = Console.ReadLine();
            switch (subject)
            {
                case "math":
                    Console.WriteLine("I love math!");
                    break;
                case "physic":
                    Console.WriteLine("physis is difficult :(");
                    break;
                case "pe":
                    Console.WriteLine("PE is interesting.");
                    break;
                case "english":
                    Console.WriteLine("English is useful.");
                    break;
                case "science":
                    Console.WriteLine("Sciene is fun!");
                    break;
                default:
                    Console.WriteLine("never heard of the subject.");
                    break;

            }
        }
    }
}
