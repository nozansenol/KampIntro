using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety: tip güvenliği
            //do not repeat yourself: kendini tekrarlama
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi=32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun=7.35;
            double dolarBugun=7.45;

            if (dolarDun>dolarBugun)
	        {
                Console.WriteLine("Azaliş Butonu Göster");
	        }
            else if (dolarDun<dolarBugun)
	        {
		        Console.WriteLine("Artiş Butonu Göster");
	        }
            else
	        {
                Console.WriteLine("Değişmedi Butonu");    
	        }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
