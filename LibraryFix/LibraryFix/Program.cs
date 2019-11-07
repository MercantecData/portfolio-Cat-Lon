<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace LibraryFix
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(new List<Book> { new Book("The color from space", false, 14), new Book("1984", true, 14), new Book("sample book", false, 14) });
            User user1 = new User("Wilk", new List<Book>());
            User user2 = new User("Dinker", new List<Book>());
            User user3 = new User("Bunk", new List<Book>());
            User[] users = { user1, user2, user3 };
            bool isRunning = true;
            Console.Write("Indtast dit BrugerNavn: ");
            string useName = Console.ReadLine();
            if (useName == user1.userID || useName == user2.userID || useName == user3.userID)
            {
                int tNum = UserCheck(useName);
                User mainUser = users[tNum];
                while (isRunning)
                {
                    Menu();
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            {
                                string[] titleArray = library.Browse();
                                foreach (string element in titleArray)
                                {
                                    Console.WriteLine(element);
                                }
                                break;
                            }
                        case "2":
                            {
                                Console.Write("Type in the name of the book you want to borrow: ");
                                string bookname = Console.ReadLine();
                                int bReturn = library.BorrowBook(bookname, mainUser);
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
                                Console.Write("Type in the name of the book you'd like to return: ");
                                string returnBook = Console.ReadLine();
                                int returnNumber = library.ReturnBook(returnBook, mainUser);
                                switch (returnNumber)
                                {
                                    case 1:
                                        Console.WriteLine($"You have returned {returnBook}");
                                        break;
                                    case 2:
                                        Console.WriteLine("You have no book by that name");
                                        break;
                                    case 3:
                                        Console.WriteLine("Hi it's me: unreachable code just wanted to pop by and say hello");
                                        break;
                                }
                                break;
                            }

                        case "4":
                            {
                                Console.Write("Type in the name of the book you'd like to check: ");
                                int num = library.BookCheck(Console.ReadLine());
                                switch (num)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("That book has been taken out");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("That book has not been taken out");
                                            break;
                                        }
                                    case 3:
                                            Console.WriteLine("There is no book by that name");
                                            break;
                                    case 4:
                                            Console.WriteLine("CRY IN FEAR THIS LITERALLY CANT HAPPEN");
                                            break;
                                }
                                break;
                            }
                        case "5":
                            
                                Console.WriteLine("Type in the name of the book you'd like to extend or subtract time from. and then how much you'd like to subtract or extend by (days)");
                                string checkB = Console.ReadLine();
                                library.ChangeBTime(checkB, int.Parse(Console.ReadLine()));
                                break;
                        case "6":
                            isRunning = false;
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("forkert BrugerNavn");
            }
        }
        static int UserCheck(string name)
        {
            switch (name)
            {
                case "Wilk":
                    return 0;
                case "Dinker":
                    return 1;
                case "Bunk":
                    return 2;
                default:
                    break;
            }
            Console.WriteLine("Hello i'm unreachable code, you killed the program, prepare to die.");
            return 3;
        }
        static void Menu()
        {
            Console.WriteLine("Menu:\nPick one of the following:\n1: Browse the book selection.\n2: Borrow a book\n3: Return a book\n4: Check if a book is already lent out\n5: Change the amount of time you're allowed to borrow a book for \n6: Exit the program");
        }
    }
}
=======
﻿using System;
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
>>>>>>> master
