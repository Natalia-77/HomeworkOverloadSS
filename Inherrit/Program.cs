using System;

namespace Inherrit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.AddPuppy();
            //Console.WriteLine(dog.Status);
            //dog.FinalInfo();

            //Animal[] animals = new Animal[2];
            //animals[0] = new LandAnimal();
            //animals[1] = new WaterAnimal();



            Dog[] dog = new Dog[5];
            dog[0] = new Dog("Reks", new DateTime(2018, 10, 09), 50, 22, "Ahmetov R.");
            dog[1] = new Dog("Palmyra", new DateTime(2017, 03, 09), 45, 21, "Ahmetov R.");
            dog[2] = new Dog("Kamaro", new DateTime(2020, 02, 09), 55, 23, "Poroshenko P.");
            dog[3] = new Dog("Kaisa", new DateTime(2019, 11, 05), 56, 20, "Timoshenko Y.");
            dog[4] = new Dog("Petra", new DateTime(2021, 01, 01), 40, 24, "Ahmetov R.");

            Cat[] cats = new Cat[2];
            cats[0] = new Cat("Barsik", new DateTime(2017, 12, 10), 17, 15, "Tretyak O.");
            cats[1] = new Cat("Myrchik", new DateTime(2019, 05, 11), 19, 14, "Tretyak O.");
            cats[0].AddKitten();


            foreach (var item in cats)
            {
                item.FinalInfo();
            }

            





        }
    }
}
