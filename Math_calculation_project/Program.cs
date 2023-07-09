using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_calculation_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan işleme göre hesaplama yapma

            Console.Write("Lütfen isminizi giriniz : ");          
            string isim = Console.ReadLine();

            Console.WriteLine();   // aradaki boşluk

            Console.WriteLine("Merhaba  " + isim);

            Console.WriteLine();

            Console.Write("Lütfen birinci sayıyı girer misin : ");    // burada kullanıcıdan değer alıyorum.
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Güzel, Lütfen ikinci sayyı girer misin: ");    // aynı şekilde burda da kullanıcıdan değer aldım.
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            char toplama = '+';
            char cıkarma = '-';
            char carpma = '*';
            char bolme = '/';

            Console.WriteLine();
            

            Console.WriteLine("Şimdi de yapmak istediğin işlemi seç lütfen : " + toplama  + "," + cıkarma + "," + carpma  + "," + bolme);

            Console.WriteLine();

            char islem = Convert.ToChar(Console.ReadLine());
           
            Console.WriteLine("seçilen işlem : " + islem);

            Console.WriteLine();

            if (islem == '+')
            {
                Console.WriteLine("Toplama işleminin sonucu : " + (sayi1 + sayi2));
            }
            else if (islem == '-')
            {
                Console.WriteLine("Çıkarma işleminin sonucu : " + (sayi1 - sayi2));
            }
            else if (islem == '*')
            {
                Console.WriteLine("Çarpma işleminin sonucu : " + (sayi1 * sayi2));
            }
            else
            {
                Console.WriteLine("Bölme işleminin sonucu : " + (sayi1 / sayi2));
            }


            Console.ReadLine();

        }
    }
}
