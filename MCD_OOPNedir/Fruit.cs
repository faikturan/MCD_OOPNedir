using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPNedir
{
    class Fruit
    {
        /*Class: sınıf demektir. Nesneyi ifade eder. Cshapta classlar bir namespace içinde olmalıdır. Herhangi bir erişim belirleyicisi almazsa class default olarak INTERNAL seviyededir.
         * private: özel
         * public: genel
         * Internal: sadece bulunduğu projede yani bulunduğu namespace ulaşılabilir.
         * classlar içinde metotlar barındırabilir.
         * classlar içinde özellikler barındırabilir.
         * 
         * Özellik Property --> ingiliz anahtarı
         * Property nasıl yazılır?
         * Erişim belirleyicisi tip Propertyadı {get; set;}
         */
        public string FruitName { get; set; }
        public string MeyveRengi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;

        //private string fruitName;
        //private string meyveRengi;
        //private DateTime olusturulmaTarihi;

        //public string FruitName { get => fruitName; set => fruitName = value; }
        //public string MeyveRengi { get => meyveRengi; set => meyveRengi = value; }
        //public DateTime OlusturulmaTarihi { get => olusturulmaTarihi; set => olusturulmaTarihi = value; }
    }
}
