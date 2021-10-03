using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar //tekrar tekrar kullabilirliği sağlayan kod bloklarıdır
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("-----------Metotlar--------------");

            SepetManager sepetManege = new SepetManager();
            sepetManege.Ekle(urun1);
            sepetManege.Ekle(urun2);

            sepetManege.Ekle2("Armut","Yeşil armut",12);
            sepetManege.Ekle2("Elma", "Yeşil elma", 12);
            sepetManege.Ekle2("Karpuz", "Büyük Karpuz", 12);
            Console.ReadLine();
        }
    }
}
