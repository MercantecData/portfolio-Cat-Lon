using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Menu());
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    { 
                        string[] titleArray = Library.Browse();
                        foreach(string element in titleArray)
                        {
                            Console.WriteLine(element);
                        }
                        break;
                    }
                case "2":
                    {
                        Console.Write("Type in the name of the book you want to borrow: ");
                        string bookname = Console.ReadLine();
                        int bReturn = Library.BorrowBook(bookname);
                        switch (bReturn)
                        {
                            case 1:
                                Console.WriteLine($"You have borrowed {bookname}");
                                break;
                            case 2:
                                Console.WriteLine("That book is already lent out");
                                break;
                            case 3:
                                Console.WriteLine("There is no book by that name");
                                break;
                            case 4:
                                Console.WriteLine("This code is unreachable if you see this be very scared");
                                break;
                        }
                        break;
                    }
                case "3":
                    {
                        Console.Write("Type in the name of the book you'd like to check: ");
                        int num = Library.BookCheck(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                {
                                    Console.WriteLine("That book has not been taken out");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("That book has not been taken out");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("There is no book by that name");
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("CRY IN FEAR THIS CANT HAPPEN");
                                    break;
                                }
                        }
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Type in the name of the book you'd like to extend or subtract time from. and then how much you'd like to subtract or extend by (days)");
                        string checkB = Console.ReadLine();
                        Library.ChangeBTime(checkB, int.Parse(Console.ReadLine()));
                        break;
                    }
            }
        }
        static string Menu()
        {
            string menu = "Menu:\nPick one of the following:\n1: Browse the book selection.\n2: Borrow a book\n3: Check if a book is already borrowed\n3: Change how long a book can be borrowed for";
            return menu;
        }
    }
}
