using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManajement
{
    class Book
    {
        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }


        public override String ToString()
        {
            return "Title : "+Title +
                    "\nAuthor : "+Author +
                    "\nPublication Year : "+PublicationYear;
        }


    }
}
