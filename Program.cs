using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
        Mahasiswa Mhs = new Mahasiswa();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();


                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.Write("Pilih Menu Aplikasi");
            Console.Write("\n");
            Console.Write("\n1. Tambah Mahasiswa");
            Console.Write("\n2. Tampilkan Mahasiswa");
            Console.Write("\n3. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa Mhs = new Mahasiswa();

            Console.Write("Tambah Mahasiswa");
            Console.Write("\n\nNIM     : ");
            Mhs.nim =Console.ReadLine();

            Console.Write("Nama    : ");
            Mhs.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P] : ");
            Mhs.jk = Console.ReadLine();
            if (Mhs.jk == "L")
            {
                Mhs.jk = "Laki-Laki";
            }
            else if (Mhs.jk == "P")
            {
                Mhs.jk = "Perempuan";
            }

            Console.Write("IPK     : ");
            Mhs.ipk = Console.ReadLine();
            daftarMahasiswa.Add(Mhs);

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
        }


        static void TampilMahasiswa()
        {

            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;
            foreach (Mahasiswa Mhs in daftarMahasiswa)
            {

                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, Mhs.nim, Mhs.Nama, Mhs.jk, Mhs.ipk);
                no++;
            }
            Console.WriteLine();
            Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
