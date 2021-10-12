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

        private int width;
        public int Width { get => width; set => width = value; }       
       
        public string Status => hasPuppies ? "Has puppies" : "Not yet";     

        public int SectorNumber { get; set; }

        public string Curator { get; set; }

        public Dog(string name, DateTime datebirth, int width,int sector,string curator)
            :base(name,datebirth)
        {
            SectorNumber = sector;
            Curator = curator;
            Sound = "Woof";
            Width = width;

        }

        public void AddPuppy()
        {
            Puppy++;
            hasPuppies=true;
        }
        public override void Print()
        {            
            Console.WriteLine($"Sector:{SectorNumber}\n" +
                $"Curator: {Curator}\nWidth:{Width} ");            
        }



    }
}
