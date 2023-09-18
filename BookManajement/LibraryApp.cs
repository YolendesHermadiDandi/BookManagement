

namespace BookManajement
{
    public class LibraryApp
    {
        private static String output;
        public static void Main(string[] args)
        {

            MainMenu();

        }

        public static void MainMenu()
        {
            Boolean menuBook = true;
            do
            {
                Console.Clear();
                Console.WriteLine("============MANAJEMENT BUKU============");
                Console.WriteLine("1. TAMBAH BUKU");
                Console.WriteLine("2. HAPUS BUKU");
                Console.WriteLine("3. CARI BUKU");
                Console.WriteLine("4. CETAK SEMUA BUKU");
                Console.WriteLine("5. KELUAR APLIKASI");
                Console.Write("Pilih Menu : ");
                string menuSelect = Console.ReadLine();
                switch (menuSelect)
                {
                    case "1":
                        Console.Clear();
                        LibraryCatalog.AddBook();

                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        LibraryCatalog.ShowBooks();
                        LibraryCatalog.DeleteBook();

                        Console.ReadKey();

                        break;
                    case "3":
                        Console.Clear();
                        LibraryCatalog.ShowBooks();
                        LibraryCatalog.SearchBook();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        LibraryCatalog.ShowBooks();
                        Console.ReadKey();
                        break;
                    case "5":
                        menuBook = false;
                        break;
                    default:
                        Console.WriteLine("INPUTAN TIDAK FALID");
                        break;
                }
            } while (menuBook);
        }
    }
}