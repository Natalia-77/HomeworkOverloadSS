using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class Carp:WaterAnimal
    {     

        private int width;
        public int Width { get => width; set => width = value; }       

        public int SectorNumber { get; set; }

        public string Curator { get; set; }

        public Carp(string name, DateTime datebirth, int width, int sector, string curator)
            : base(name, datebirth)
        {
            SectorNumber = sector;
            Curator = curator;
            Sound = "Woof";
            Width = width;

        }

        public void AddPuppy()
        {
            Puppy++;
            hasPuppies = true;
        }
        public new void FinalInfo()
        {
            PrintInfo();
            Console.WriteLine($"Sector:{SectorNumber}\n" +
                $"Curator: {Curator}\nWidth:{Width} ");
            Console.WriteLine("-------------------------------\n");
        }



    }
}
