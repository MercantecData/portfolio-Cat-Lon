﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Library
    {
        public string traffic = "busy";//gør ikke noget endnu tilføjer det senere
        public static Book[] books = new Book[] { new Book("The color from space", false, 14), new Book("1984", true, 14), new Book("samplebook", false, 14) };

        public static void BorrowBook(string name)
        {
            string tName = name.ToLower().Trim();
            int i = 0;
            bool isrunning = true;
            while (isrunning)
            {
                if (tName == books[i].title.ToLower().Trim())
                {
                    if (books[i].borrowed != true)
                    {
                        Console.WriteLine($"You have borrowed {books[i].title}");
                        books[i].borrowed = true;
                        isrunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Book is already borrowed");
                        isrunning = false;
                    }
                }
                i++;
            }
        }
        public static void BookCheck(string name)
        {
            string tName = name.Trim().ToLower();
            int i = 0;
            bool isRunning = true;
            while (isRunning)
            {
                if (tName == books[i].title.Trim().ToLower())
                {
                    if (books[i].borrowed)
                    {
                        Console.WriteLine("Book is already borrowed");
                        isRunning = false;
                    }
                    else if (books[i].borrowed != true)
                    {
                        Console.WriteLine("That book has not been taken out");
                        isRunning = false;
                    }
                }
                else if (i > books.Length)
                {
                    Console.WriteLine("There is no book by that name");

                }
                i++;
            }
        }
        public static void ChangeBTime(string name)
        {
            string tName = name.Trim().ToLower();
            int i = 0;
            Console.WriteLine("how many days do you want to subtract/extend from the borrow time?");
            int time = int.Parse(Console.ReadLine());
            foreach (Book element in books)
            {
                if (tName == books[i].title.Trim().ToLower())
                {
                    books[i].borrowTime += time;
                }
            }
        }
        public static void Browse()
        {
            int i = 0;
            foreach (Book element in books)
            {
                Console.WriteLine(books[i].title);
                i++;
            }
        }
    }
}
