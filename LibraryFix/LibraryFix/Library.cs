using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Library
    {
        public static Book[] books = new Book[] { new Book("The color from space", false, 14), new Book("1984", true, 14), new Book("samplebook", false, 14) };

        public static int BorrowBook(string name)
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
                        books[i].borrowed = true;
                        isrunning = false;
                        return 1;
                    }
                    else if (books[i].borrowed)
                    {
                        isrunning = false;
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
                i++;
            }
            return 4;
        }
        public static int BookCheck(string name)
        {
            string tName = name.Trim().ToLower();
            int i = 0;
            bool isRunning = true;
            while(isRunning)
            {
                if (tName == books[i].title.Trim().ToLower())
                {
                    if (books[i].borrowed)
                    {
                        isRunning = false;
                        return 1;
                    }
                    else if (books[i].borrowed != true)
                    {
                        isRunning = false;
                        return 2;
                    }
                }
                else if (i > books.Length)
                {
                    isRunning = false;
                    return 3;
                }

                i++;
            }
            return 4;
        }
        public static void ChangeBTime(string name, int time)
        {
            string tName = name.Trim().ToLower();
            int i = 0;
            foreach (Book book in books)
            {
                if (tName == books[i].title.Trim().ToLower())
                {
                    books[i].borrowTime += time;
                }
            }
        }
        public static string[] Browse()
        {
            string[] array = new string[books.Length];
            int i = 0;
            foreach (Book element in books)
            {
                array[i] = books[i].title;
                i++;
            }
            return array;
        }
    }
}
