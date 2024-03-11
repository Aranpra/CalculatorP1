using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pilihan;
            int a, b;

            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilihan Menu Calculator :\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("\nInput Nomor Menu : ");
            Pilihan = int.Parse(Console.ReadLine());

            switch (Pilihan)
            {
                case 1:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Hasil Penambahan {0} + {1} = {2}",a,b, Penambahan(a, b));
                    break;

                case 2:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Hasil Pengurangan {0} + {1} = {2}", a, b, Pengurangan(a, b));
                    break;

                case 3:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Hasil Perkalian {0} + {1} = {2}", a, b, Perkalian(a, b));
                    break;

                case 4:
                    Console.Write("Inputkan Nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Inputkan Nilai b = ");
                    b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Hasil Pembagian {0} + {1} = {2}", a, b, Pembagian(a, b));
                    break;

                default: Console.WriteLine("Menu Tidak Tersedia");
                    break;
            }

            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadLine();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return (a - b);
        }

        static int Perkalian(int a, int b)
        {
            return (a * b);
        }

        static int Pembagian(int a, int b)
        {
            return (a / b);
        }
    }
}
