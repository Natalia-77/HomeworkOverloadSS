using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class Carp:WaterAnimal
    {
        protected bool hasTeeth;

        private int weight;
        public int Weight { get => weight; set => weight = value; }

        public string DangerStatus => hasTeeth ? "Danger!" : "Don't danger!Yet...";

        public int SectorNumber { get; set; }

        public string Curator { get; set; }

        public Carp(string name, DateTime datebirth, int weight, int sector, string curator)
            : base(name, datebirth)
        {
            SectorNumber = sector;
            Curator = curator;
            Sound = "Woof";
            Weight = weight;

        }

        public void AddDangerTeeth()
        {
            hasTeeth = true;
        }
      
        public new void FinalInfo()
        {
            PrintInfo();
            Console.WriteLine($"Sector:{SectorNumber}\n" +
                $"Curator: {Curator}\nWeight:{Weight}\nDanger status:{DangerStatus} ");
            
        }



    }
}
