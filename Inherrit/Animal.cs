using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherrit
{
    class Animal
    {
        public string  Name { get; set; }
        public string Sound { get; set; }
        public DateTime DateBirth { get; }
        public Animal()
        {
                
        }

        public Animal(string name,DateTime date)
        {
            Name = name;            
            DateBirth = date;
        }

        public void Print()
        {
            Console.WriteLine($"Animal name:{Name} has sound:{Sound}||" +
                $" Date of birth:{DateBirth.ToShortDateString()}");
        }
    }
}
