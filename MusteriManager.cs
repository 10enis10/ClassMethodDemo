using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void GetMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.Surname);
        }

        public void AddMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Eklendi.");
        }

        public void DeleteMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Silindi.");
        }

        public bool Validation(Musteri musteri)
        {
            if (musteri.Id / 100 <= 9 && musteri.Id / 100 >= 1) //Validation number must be 3 digits.
            {
                return true;
            }
            return false;
        }
    }
}
