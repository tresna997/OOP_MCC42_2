using System;

namespace OOP_MCC42_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Angka 1 : ");
            string ans1 = Console.ReadLine();
            Console.Write("Masukkan Angka 2 : ");
            string ans2 = Console.ReadLine();

            int angka1 = int.Parse(ans1);
            int angka2 = int.Parse(ans2);
            Console.WriteLine();

            Persegi p = new Persegi();
            Console.WriteLine("Luas Persegi = "+ p.Luas(angka1));

            PersegiPanjang pp = new PersegiPanjang();
            Console.WriteLine("Luas Persegi Panjang = " + pp.LuasBangunan(angka1, angka2));

            Lingkaran l = new Lingkaran();
            Console.WriteLine("Luas Lingkaran = " + l.Luas(angka1));

            Segitiga s = new Segitiga();
            Console.WriteLine("Luas Segitiga = " + s.LuasBangunan(angka1, angka2));

            LayangLayang ll = new LayangLayang();
            Console.WriteLine("Luas Layang Layang = " + ll.LuasBangunan(angka1, angka2));
        }
    }
}
