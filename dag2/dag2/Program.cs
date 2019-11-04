using System;

namespace dag2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hole();
            Console.WriteLine(ReturnSum(30, 12));
            Console.WriteLine(Caps("jeg råber ikke"));
            Console.WriteLine(Connect("En masse ord. ", "endu flere ord!"));
            Console.WriteLine(Power(5));
            Console.WriteLine(BackToSender(4, 1, 3, 2, 5));
        }
        static void Hole()
        {
            Console.WriteLine("Nothing to see here");
        }
        static int ReturnSum(int num1, int num2)
        {
            return num1 + num2;
        }
        static string Caps(string text)
        {
            return text.ToUpper();
        }
        static string Connect(string text, string text2)
        {
            return string.Join(text, text2);
        }
        static double Power(double num)
        {
            return Math.Pow(num, 2);
        }
        static int BackToSender(int num1, int num2, int num3, int num4, int num5)
        {
            if (num1 == 1)
            {
                return num1;
            }
            else if (num1 == 2)
            {
                return num2;
            }
            else if (num1 == 3)
            {
                return num3;
            }
            else if (num1 == 4)
            {
                return num4;
            }
            else if (num1 == 5)
            {
                return num5;
            }
            else
            {
                return 0;
            }
        }
    }
}
