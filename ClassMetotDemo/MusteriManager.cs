using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri Musteri)
        {
            Console.WriteLine("eklenen müsteri: "+ Musteri.Adi + " " + Musteri.Soyadi);
        }

        public void MusteriSil(Musteri Musteri) 
        {
            Console.WriteLine("Silinen müşteri: " + Musteri.Adi + " " + Musteri.Soyadi);
        }

    }
}
