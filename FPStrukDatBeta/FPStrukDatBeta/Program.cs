using FPStrukDatBeta;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCLI;

 public class Program
{
    static void Main(string[] args)
    {
        FungsiBuku fungsi = new FungsiBuku();

        while (true)
        {
            fungsi.TampilkanMenu();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    fungsi.TambahkanBuku();
                    break;
                case "2":
                    fungsi.LihatDaftarBuku();
                    break;
                case "3":
                    fungsi.CariBuku();
                    break;
                case "4":
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi ini.");
                    return;
                default:
                    Console.WriteLine("Opsi tidak valid. Silakan coba lagi.");
                    break;
            }
        }
    }
}