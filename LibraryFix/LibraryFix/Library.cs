using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFix
{
    class Library
    {
        public List<Book> books;
        public Library(List<Book> books)
        {
            this.books = books;
        }

        public int BorrowBook(string name, User user)
        {
            string tName = name.ToLower().Trim();
            int i = 0;
            bool isrunning = true;
            while (isrunning)
            {
                if (tName == books[i].title.ToLower())
                {
                    if (books[i].borrowed != true)
                    {
                        books[i].borrowed = true;
                        user.userBooks.Add(books[i]);
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
                        isrunning = false;
                        return 3;
                    }
                }
                if(i >= user.userBooks.Count)
                {
                    return 3;
                }
                i++;
            }
            return 4;
        }
        public int ReturnBook(string name, User user)
        {
            int i = 0;
            
            foreach(Book book in user.userBooks)
            { 
                if (i >= user.userBooks.Count)
                {
                    return 2;
                }
                if(name == user.userBooks[i].title.ToLower()) 
                {
                    user.userBooks.RemoveAt(i);
                    books[i].borrowed = false;
                    return 1;
                }
                i++;
            }
            return 2;
        }
        public int BookCheck(string name)
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
                        return 1;
                    }
                    else if (books[i].borrowed != true)
                    {
                        return 2;
                    }
                }
                else if (i > books.Count)
                {
                    return 3;
                }

                i++;
            }
            return 4;
        }
        public void ChangeBTime(string name, int time)
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
        public string[] Browse()
        {
            string[] array = new string[books.Count];
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
