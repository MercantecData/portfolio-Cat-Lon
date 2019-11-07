using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFix
{
    class User
    {
        public string userID;
        public List<Book> userBooks;
        public User(string userID, List<Book> userBooks)
        {
            this.userID = userID;
            this.userBooks = userBooks;
        }
    }
}
