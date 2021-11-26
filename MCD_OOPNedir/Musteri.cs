using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Musteri
    {
        /*
         * TCKimlik Numarası
         * İsim
         * Soyisim
         * Cinsiyet
         * 
         */

        //Propery -Özellikler

        public string TCKimlikNumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; //717770001 : Bay - 717770002 : Bayan


        //Yapıcı Metot Constructor
        public Musteri()
        {
            //TCKimlikNumara = "1234567890";
        }

        public Musteri(string _tckimlikno)
        {
            TCKimlikNumara = _tckimlikno;
        }

        public Musteri(string _tckimlikno, string _isim)
        {
            TCKimlikNumara = _tckimlikno;
            isim = _isim;
        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCKimlikNumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;
        }

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCKimlikNumara);
            return kontrol;
        }

        private bool MusteriKontrolDatabase(string tckimlikNumarasi)
        {
            //database gidilir müşterinin tckimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır....
            return true;
        }



    }
}
