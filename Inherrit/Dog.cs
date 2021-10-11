using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class Dog : LandAnimal
    {
        protected bool hasPuppies;

        private int puppy;
        public int Puppy { get => puppy; set => puppy = value; }

        public string Status => hasPuppies ? "Has puppies" : "Not yet";

        public int SectorNumber { get; set; }

        public string Curator { get; set; }

        public Dog(string name, DateTime datebirth, double width,int sector,string curator)
            :base(name,datebirth,width)
        {
            SectorNumber = sector;
            Curator = curator;
            Sound = "Woof";

        }

        public void AddPuppy()
        {
            Puppy++;
            hasPuppies=true;
        }
        public new void FinalInfo()
        {
            PrintInfo();
            Console.WriteLine($"Sector:{SectorNumber}\n" +
                $"Curator: {Curator}");
        }



    }
}
