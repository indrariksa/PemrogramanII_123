using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPertemuan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!!");
            Console.Write("Tes");
            Console.Write("Tes");*/

            //Console.WriteLine("Hello" + "ULBI");
            //Console.WriteLine("Hello" + 40);
            //Console.WriteLine(20 + 40);

            //string alamat;
            //int umur;
            //double beratBadan;
            //bool isMenikah;

            //alamat = "Jalan Sariasih No.54";
            //umur = 20;
            //beratBadan = 49.5;
            //isMenikah = false;

            //string nama = "ULBI";
            //int angkatan = 2022;
            //float nilaiAkademik = 3.84F;

            //Console.WriteLine("Alamatnya adalah : " + alamat);
            //Console.WriteLine("Umur adalah : " + umur);
            //Console.WriteLine("Berat badan adalah : " + beratBadan);

            //Console.WriteLine("Biodata : " + " " + alamat + " " + umur + " " + beratBadan);

            //var nama = "ULBI";
            //var umur = 18;
            //var nilai = 90.5;

            //Console.WriteLine(nama.GetType());

            //string text = "HELLO ULBI";
            //Console.WriteLine("Panjang variabel text adalah : " + text.Length);
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());

            //string firstName = "John";
            //string lastName = "Doe";
            //string name = firstName + lastName;
            //string fullname = string.Concat(firstName, lastName);
            //Console.WriteLine(name);
            //Console.WriteLine(fullname);

            //string nama = $"Nama lengkap saya adalah {firstName} {lastName}";
            //Console.WriteLine(nama);

            //string namaLengkap = string.Format("Nama saya {0} {1}", firstName, lastName);
            //Console.WriteLine(namaLengkap);
            //Console.WriteLine("Nama saya {0} {1}", firstName, lastName);

            //string input;
            //Console.WriteLine("=== PERCOBAAN SINTAKS INPUT ===");
            //Console.Write("Masukkan nama anda : ");
            //input = Console.ReadLine();
            //Console.WriteLine($"Hi, {input} selamat datang");
            //Console.WriteLine("Hi, {0} selamat datang", input);
            //Console.WriteLine("Hi, " + input + " selamat datang");

            //int myInt = 9;
            //double myDouble = myInt;

            //Console.WriteLine(myDouble);
            //Console.WriteLine(myDouble.GetType());

            //double myDouble2 = 74.3;
            //int myInt2 = (int) myDouble2;

            //Console.WriteLine(myDouble2);
            //Console.WriteLine(myInt2);

            Console.Write("Masukan angka: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Angka yang dimasukkan : {input}");
            Console.WriteLine(input.GetType());
        }
    }
}
