using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            bool status = true;
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            

            while (status == true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan(daftarPenjualan);
                        break;

                    case 2:
                        HapusPenjualan(daftarPenjualan);
                        break;

                    case 3:
                        TampilPenjualan(daftarPenjualan);
                        Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                        Console.ReadKey();
                        break;

                    case 4:

                        Console.WriteLine("Good Bye.");
                        Thread.Sleep(500);
                        status = false;
                        break;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Menu Utama : ");
            Console.WriteLine("[1]. Tambah Penjualan\n[2]. Hapus penjualan \n[3]. Tampilkan Penjualan \n[4]. Keluar\n");
        }

        static void TambahPenjualan(List<Penjualan> daftarPenjualan)
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.Clear();

            Penjualan penjualan = new Penjualan();

            Console.WriteLine("Tambah Data Penjualan\n");

            Console.Write("Nota \t\t: ");
            penjualan.Nota = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal\t\t: ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Customer \t: ");
            penjualan.Nama = Console.ReadLine();

            Console.Write("Jenis [T/K] \t: ");
            penjualan.Tipe = Console.ReadLine();

            Console.Write("Total Nota \t: ");
            penjualan.Total = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan(List<Penjualan> daftarPenjualan)
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            bool Ditemukan = true;
            TampilPenjualan(daftarPenjualan);

            Console.Write("\nMasukkan Nota Penjualan Yang Ingin Di Hapus: ");
            int Nota = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (daftarPenjualan[i].Nota == Nota)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    Ditemukan = true;
                    break;
                }
                else
                {
                    Ditemukan = false;
                }
            }

            switch (Ditemukan)
            {
                case true:
                    Console.WriteLine("\nData dengan NOTA = \"{0}\" berhasil dihapus", Nota);
                    break;
                case false:
                    Console.WriteLine("\nData dengan NOTA = \"{0}\" Tidak Ditemukan", Nota);
                    break;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan(List<Penjualan> daftarPenjualan)
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("=========== DATA CUSTOMER ===========");

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if(daftarPenjualan[i].Tipe == "T")
                    Console.WriteLine(String.Format("| {0,-3} | {1, -15} | {2,-15} | {3, -6} | {4,-3} {5,-17} ",daftarPenjualan[i].Nota, daftarPenjualan[i].Nama, daftarPenjualan[i].Tanggal, "Tunai", "Rp.", daftarPenjualan[i].Total));
                else
                Console.WriteLine(String.Format("| {0,-3} | {1, -15} | {2,-15} | {3, -6} | {4,-3} {5,-17} ", daftarPenjualan[i].Nota, daftarPenjualan[i].Nama, daftarPenjualan[i].Tanggal, "Kredit", "Rp.", daftarPenjualan[i].Total));
            }
        }
    }
}
