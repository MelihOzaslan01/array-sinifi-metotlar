using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sort Kullanımı
            int[] sayiDizisi = { 4, 5, 8, 15, 78, 65, 125, 16 };
            Console.WriteLine("***** Sırasız Sayı Dizisi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);

            }
            Console.WriteLine("***** Sıralı Sayı Dizisi *****");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear
            Console.WriteLine("***** Array Clear *****");
            // dizinin elemanlarını kullanarak belirtilen indexten itibaren değerleri 0'lar
            Array.Clear(sayiDizisi, 3, 3);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Reverse 
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // İndex Of 
            Console.WriteLine("***** Array İnedx Of*****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,78));

            // Resize 
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 654;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }







        }
    }
}
