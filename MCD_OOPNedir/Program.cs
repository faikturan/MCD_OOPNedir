using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç Sınıfı İnceleme
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            //A1.Fiyat = Kapsülleme konusu
            A1.FiyatAta(31000);
            A1.Fiyat = 35000;
            Console.WriteLine(A1.Fiyat);
            A1.BilgileriGoruntule();

            #endregion


            //Musteri M1 = new Musteri();
            Musteri M1 = new Musteri("122544013254", "Murat");
            M1.TCKimlikNumara = "1225440152";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.cinsiyet = 717770001;

            Musteri M2 = M1;

            M2.isim = "Murat";
            M2.TCKimlikNumara = "12254401325";

            bool musteriKontrol = M2.MusteriKontrol();

            Console.WriteLine(musteriKontrol);

            M2 = null;
            M1 = null;

            string isim = M2.isim;

            //Customer M3 = new Customer();

            //Classlardan nesne bu şekilde new kelimesi ile türetilir.

            //So, a class is a template for objects, and an object is an instance of a class.

            Fruit meyve1 = new Fruit();
            meyve1.FruitName = "Bu bir Elmadır";
            meyve1.MeyveRengi = "kırmızı";
            meyve1.OlusturulmaTarihi = DateTime.Now;

            Console.WriteLine(meyve1.FruitName);
            Console.WriteLine(meyve1.MeyveRengi);

            Fruit meyve2 = new Fruit();
            meyve2.FruitName = "Bu bir Çilektir";
            meyve2.MeyveRengi = "kırmızı";
            meyve2.OlusturulmaTarihi = DateTime.Now;

            Console.WriteLine(meyve1.FruitName);
            Console.WriteLine(meyve1.MeyveRengi);


            Console.ReadLine();

        }
    }

    //class Customer
    //{

    //}
}
