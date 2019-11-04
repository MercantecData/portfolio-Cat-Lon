using System;

namespace _10var
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast dit navn: ");
            string name = Console.ReadLine();
            Console.Write("Indtast et andet navn: ");
            string name2 = Console.ReadLine();
            Console.Write("indtast din matematik karakter: ");
            int mGrade = int.Parse(Console.ReadLine());
            Console.Write("indtast " + name2 + "'s matematik karakter: ");
            int mGrade2 = int.Parse(Console.ReadLine());
            Console.Write("indtast din engelsk karakter: ");
            int eGrade = int.Parse(Console.ReadLine());
            Console.Write("indtast " + name2 + "'s engelsk karakter: ");
            int eGrade2 = int.Parse(Console.ReadLine());
            //all variabler er blevet indtastet
            BedreEnd("matematik", mGrade, mGrade2, name, name2);
            BedreEnd("engelsk", eGrade, eGrade2, name, name2);

        }
        static void BedreEnd(string fag, int karakter, int karakter2, string name, string name2)
        {
            if (karakter > karakter2)
            {
                Console.WriteLine(name + "'s " + fag + " karakter er bedre end " + name2 + "'s karakter");
            }
            else if (karakter < karakter2)
            {
                Console.WriteLine(name2 + "'s " + fag + " karakter er bedre end " + name + "'s karakter");
            }
            else
            {
                Console.WriteLine("i har den samme " + fag + " karakter!");
            }
        }
        }
    }