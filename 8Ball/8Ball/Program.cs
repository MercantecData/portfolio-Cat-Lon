using System;

namespace _8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] answer = { "Yes", "No", "Maybe", "Go Away", "42" };
            Console.Write("Ask the 8Ball any one question and it shall answer!: ");
            string question = Console.ReadLine();
            int ballNum = rnd.Next(0, 4);
            Console.WriteLine(question + "\n" + answer[ballNum]);
        }
    }
}
