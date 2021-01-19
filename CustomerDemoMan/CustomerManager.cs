using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerDemoMan
{
    class CustomerManager
    {
        public void add(Customer musteri)
        {
            Console.WriteLine("Eklenen Kişi=" + musteri.Ad + musteri.Soyad);
        }

        public void silme(Customer musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + "silindi!!!");
        }

        public void yeniekleme(Customer musteri)
        {
            Console.WriteLine("yeni müşteri eklendi" + "-+-+-+-+-+");
        }

        public void listeleme(Customer[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id.ToString() + "--" + musteri.Ad);

            }
        }
    }
}
