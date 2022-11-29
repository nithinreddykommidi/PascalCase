using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Book
    {
        public string Name;
        public string Author;
        public int Pages;

        // The method with the Name of the class is constructor and we can create many constructors for same class
        // creating constructor

        public Book(string aName, string aAuthor, int aPages)
        {
            Name = aName;
            Author = aAuthor;
            Pages = aPages;
        }

        // distructor is represented with ~ symbol 
        // eg ~Book()
        public bool LargeBook()
        {
            if(Pages>=101)
            {
                return true;
            }
            return false;
        }
    }
}
