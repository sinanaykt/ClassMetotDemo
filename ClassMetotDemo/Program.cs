namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("---------BANKAMIZA HOŞGELDİNİZ---------\n ");
            



            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Yılmaz";
            musteri1.TcNo = 1475322691;
            musteri1.TelNo = 555777458;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Beyza";
            musteri2.Soyadi = "Kaya";
            musteri2.TcNo = 1234567892;
            musteri2.TelNo = 532987475;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ali";
            musteri3.Soyadi = "Yavaş";
            musteri3.TcNo = 987654321;
            musteri3.TelNo = 553985479;

            Console.WriteLine("----------MÜŞTERİ EKLEME----------\n");

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.MusteriEkle(musteri1);
            musteriEkle.MusteriEkle(musteri2);
            musteriEkle.MusteriEkle(musteri3);

            Console.WriteLine("\n---------------------------------------\n");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("\n MÜŞTERİ BİLGİLERİ \n");

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine("müşterinin adı - soyadı : " + Musteri.Adi + " " + Musteri.Soyadi);
                Console.WriteLine("müşterinin TC kimlik numarası: " + Musteri.TcNo);
                Console.WriteLine("müşterinin telefon numarası: " + Musteri.TelNo);
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n SİLİNEN MÜŞTERİLER\n");

            MusteriManager musteriSil = new MusteriManager();
            musteriSil.MusteriSil(musteri1);

          
                



        }
    }
}
