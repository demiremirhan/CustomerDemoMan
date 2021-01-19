using System;

namespace CustomerDemoMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new Customer();

            musteri1.Ad = "çigu ";
            musteri1.Soyad = "vera";
            musteri1.Bakiye = 154.5;
            musteri1.Id = 001;

            Customer musteri2 = new Customer();

            musteri2.Ad = "Melo ";
            musteri2.Soyad = "delo";
            musteri2.Bakiye = 53;
            musteri2.Id = 002;

            Customer musteri3 = new Customer();

            musteri3.Ad = "Kend  ";
            musteri3.Soyad = "huz";
            musteri3.Bakiye = 18645;
            musteri3.Id = 003;

            Customer[] musteriler = new Customer[] { musteri1, musteri2, musteri3 };

            CustomerManager musteriManager1 = new CustomerManager();

            musteriManager1.add(musteri1);
            musteriManager1.add(musteri2);
            musteriManager1.add(musteri3);
            Console.WriteLine("++++-+-+-+-+-+-+");

            Console.WriteLine("listelenen kişiler");
            musteriManager1.listeleme(musteriler);
            Console.WriteLine("++++-+-+-+-+-+-+");

            musteriManager1.silme(musteri1);
            musteriManager1.silme(musteri2);
            musteriManager1.silme(musteri3);



        }
    }
}
