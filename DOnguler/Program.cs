
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOnguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //yapılan yanlış
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            //string kurs3 = "Java Kursu";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);


            //array:diziler (yapılması gereken dizi kullanmak) -DİNAMİK YAPI

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java Kursu", "Python", "C++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar) //foreach dizi temelli yapıları tek tek dolaşır (foreach dizilere uygulanır)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
            Console.ReadLine();
        }
    }
}
