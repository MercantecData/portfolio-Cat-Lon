using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Browse();
            Library.BorrowBook("The color from space");
            Library.BookCheck("1984");
            Library.ChangeBTime("the color from space");
        }
    }
}
