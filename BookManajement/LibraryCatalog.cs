using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManajement
{
    public class LibraryCatalog
    {
        private static List<Book> books = new List<Book>();

        public static void ShowBooks()
        {

            Console.WriteLine("===============DAFTAR BUKU=================");
            String listBook = "";
            if (books.Count == 0)
            {
                Console.WriteLine("LIST BUKU KOSONG");

            }

            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString() + "\n");
            }

        }


        public static void AddBook()
        {

            Console.WriteLine("===============TAMBAH BUKU=================");
            string title = ErrorHandler.EHTitle(books);
            string author = ErrorHandler.EHAuthor(books);
            int publicationYear = ErrorHandler.EHPublishYear(books);

            Book book = new Book(title, author, publicationYear);
            books.Add(book);
            Console.WriteLine("Buku berhasil ditambahkan");
        }

        public static void DeleteBook()
        {

            Console.WriteLine("===============HAPUS BUKU=================");

            Console.WriteLine(ErrorHandler.EHBookDelete(books));

        }

        public static void SearchBook()
        {
            Console.WriteLine("===============CARI BUKU=================");
            String result = ErrorHandler.EHSearchBook(books);
            Console.WriteLine(result);
        }
    }


}
