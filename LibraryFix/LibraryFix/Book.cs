using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFix
{
    class Book
    {
        public string title;
        public bool borrowed;
        public int borrowTime;
        public Book(string title, bool borrowed, int borrowTime)
        {
            this.title = title;
            this.borrowed = borrowed;
            this.borrowTime = borrowTime;
        }
    }
}
