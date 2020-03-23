using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_23_Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dışarıdan girilen bir ifadeyi bir char dizide tutunuz. Dizinin boyutunu gelen ifadenin uzunluğuna göre yeniden boyutlandırıp tüm elemanlarını bir ListBox’a yazdırınız.

            char[] Karakter = new char[1];
            string Kelime;
            int x;
            Console.WriteLine("Kelimeyi Giriniz:");
            Kelime = Console.ReadLine();

            Array.Resize(ref Karakter, Kelime.Length);

            for (int i = 0; i < Karakter.Length; i++)
            {
                Karakter[i] = Kelime[i];
            }

            for (int i = 0; i < Karakter.Length; i++)
            {
                Console.Write(Karakter[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Kaçıncı Elemanı Görmek İstiyorsunuz");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Karakter[x]);

            Console.ReadKey();
        }
    }
}
