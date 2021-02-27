using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Name = "Jack";
            musteri1.Surname = "Ma";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.Name = "Jeff";
            musteri2.Surname = "Bezos";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 789;
            musteri3.Name = "Elon";
            musteri3.Surname = "Musk";

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriArray = new Musteri[]{musteri1, musteri2, musteri3};

            foreach (Musteri musteri in musteriArray)
            {
                musteriManager.AddMusteri(musteri);
            }

            Console.WriteLine("******************************************************");

            foreach (Musteri musteri in musteriArray)
            {
                if (musteriManager.Validation(musteri) == true)
                {
                    musteriManager.GetMusteri(musteri);
                }
                else
                {
                    Console.WriteLine("Gecersiz Id");
                }
            }

            foreach (Musteri musteri in musteriArray)
            {
                musteriManager.DeleteMusteri(musteri);
            }
            
        }
    }
}
