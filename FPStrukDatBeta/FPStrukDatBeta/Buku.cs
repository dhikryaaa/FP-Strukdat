using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStrukDatBeta;

public class Buku
{
    public string ISBN { get; }
    public string Judul { get; }
    public string Penulis { get; }

    public Buku(string isbn, string judul, string penulis)
    {
        ISBN = isbn;
        Judul = judul;
        Penulis = penulis;
    }

    public string GetInfo()
    {
        return $"ISBN: {ISBN}, Judul: {Judul}, Penulis: {Penulis}";
    }

    public override string ToString()
    {
        return GetInfo();
    }
}

public class FungsiBuku
{
    private BST bukuBST = new BST();

    public void TampilkanMenu()
    {
        Console.WriteLine("=== Aplikasi Manajemen Buku Perpustakaan ===");
        Console.WriteLine("1. Tambah Buku");
        Console.WriteLine("2. Lihat Daftar Buku");
        Console.WriteLine("3. Cari Buku berdasarkan ISBN");
        Console.WriteLine("4. Keluar");
        Console.Write("Pilih opsi (1-4): ");
    }

    public void TambahkanBuku()
    {
        Console.Write("Masukkan ISBN: ");
        string isbn = Console.ReadLine();

        if (bukuBST.Search(isbn) != null)
        {
            Console.WriteLine("Buku dengan ISBN tersebut sudah ada.");
            return;
        }

        Console.Write("Masukkan Judul Buku: ");
        string judul = Console.ReadLine();

        Console.Write("Masukkan Penulis: ");
        string penulis = Console.ReadLine();

        Buku buku = new Buku(isbn, judul, penulis);
        bukuBST.Insert(buku);

        Console.WriteLine("Buku berhasil ditambahkan.");
        Console.WriteLine("");
    }

    public void LihatDaftarBuku()
    {
        Console.WriteLine("=== Daftar Buku ===");
        bukuBST.InOrderTraversal();
        Console.WriteLine("");
    }

    public void CariBuku()
    {
        Console.Write("Masukkan ISBN: ");
        string isbn = Console.ReadLine();

        Buku buku = bukuBST.Search(isbn);
        if (buku != null)
        {
            Console.WriteLine(buku);
        }
        else
        {
            Console.WriteLine("Buku dengan ISBN tersebut tidak ditemukan.");
        }

        Console.WriteLine("");
    }
}