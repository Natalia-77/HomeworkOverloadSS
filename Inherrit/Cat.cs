using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class Cat : LandAnimal
    {
        protected bool hasKitten;

        private int kitten;
        public int Kitten { get => kitten; set => kitten = value; }

        public string Status => hasKitten ? "Has kitten" : "Not yet";

        public int SectorNumber { get; set; }

        public string Curator { get; set; }

        public Cat(string name, DateTime datebirth, double width, int sector, string curator)
            : base(name, datebirth)
        {
            SectorNumber = sector;
            Curator = curator;
            Sound = "Meow";

        }

        public void AddKitten()
        {
            Kitten++;
            hasKitten = true;
        }
        public new void FinalInfo()
        {
            PrintInfo();
            Console.WriteLine($"Sector:{SectorNumber}\n" +
                $"Curator: {Curator}\nCount of kitten:{Kitten}");
           
        }

    }
}
