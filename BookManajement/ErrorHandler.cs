using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookManajement
{
    public class ErrorHandler
    {



        public static string EHTitle(dynamic listBook)
        {
            Boolean titleCheck = true;
            string title;
            do
            {
                Console.Write("Title : ");
                title = Console.ReadLine();

                if (string.IsNullOrEmpty(title) || title.Any(Char.IsDigit) || title.Length < 2)
                {
                    Console.WriteLine("INPUTAN TIDAK FALID");

                }
                else
                {
                    titleCheck = EHRedudansiCheck(listBook, title);
                }



            } while (titleCheck);


            return title;
        }

        public static string EHAuthor(dynamic listBook)
        {
            Boolean authorCheck = true;
            string author;
            do
            {
                Console.Write("Author : ");
                author = Console.ReadLine();

                if (string.IsNullOrEmpty(author) || author.Any(Char.IsDigit) || author.Length < 2)
                {
                    Console.WriteLine("INPUTAN TIDAK FALID");

                }
                else
                {
                    authorCheck = false;
                }



            } while (authorCheck);


            return author;
        }

        public static int EHPublishYear(dynamic listBook)
        {
            Boolean publishYearCheck = true;
            String publishYearInput;
            int publishYear = 0;
            do
            {
                Console.Write("Publish Year : ");
                publishYearInput = Console.ReadLine();

                if (publishYearInput.Length < 4 ||
                    publishYearInput.Length > 4 ||
                    int.TryParse(publishYearInput, out publishYear) == false)
                {
                    Console.WriteLine("INPUTAN TIDAK FALID");

                }
                else
                {
                    publishYearCheck = false;
                }



            } while (publishYearCheck);


            return publishYear;

        }

        private static Boolean EHRedudansiCheck(dynamic listBook, String input)
        {
            Boolean redudansicheck = false;
            String keterangan = "";

            foreach (Book book in listBook)
            {

                if (book.Title == input)
                {
                    keterangan = "Title";
                    redudansicheck = true;
                }

            }
            if (redudansicheck == true)
            {
                Console.WriteLine(keterangan + " SUDAH DIGUNAKAN!!!");
                return true;
            }
            return false;

        }

        public static String EHBookDelete(dynamic listBook)
        {
            string input = "";
            if (listBook.Count == 0)
            {
                return "TIDAK ADA BUKU YANG BISA DIHAPUS \n DIKARENAKAN LIST BUKU KOSONG";
            }

            try
            {

                Console.Write("Masukan title/judul buku : ");
                input = Console.ReadLine();
                foreach (Book book in listBook)
                {
                    if (book.Title == input)
                    {
                        listBook.Remove(book);
                        return "BUKU BERJUDUL " + input + " BERHASIL DIHAPUS";
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return "BUKU BERJUDUL " + input + " TIDAK DITEMUKAN";

        }

        public static String EHSearchBook(dynamic listBook)
        {

            String books = "";
            int bookCount = 0;
            if (listBook.Count == 0)
            {
                return "TIDAK ADA BUKU YANG BISA DICARI \n DIKARENAKAN LIST BUKU KOSONG";
            }
            Console.Write("CARI JUDUL BUKU : ");
            string input = Console.ReadLine();
            foreach (Book book in listBook)
            {
                if (book.Title.Contains(input))
                {
                    books = books + book.ToString() + "\n";
                    bookCount++;
                }
            }
            if (bookCount < 1)
            {
                return "BUKU YANG DICARI TIDAK DITEMUKAN";
            }
            return books;
        }
    }
}
