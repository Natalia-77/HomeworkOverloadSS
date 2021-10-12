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



            Animal[] animals =
            {
                new Dog("Reks", new DateTime(2018, 10, 09), 50, 22, "Ahmetov R."),
                new Dog("Palmyra", new DateTime(2017, 03, 09), 45, 21, "Ahmetov R."),
                new Dog("Kamaro", new DateTime(2020, 02, 09), 55, 23, "Poroshenko P."),
                new Cat("Barsik", new DateTime(2017, 12, 10), 17, 15, "Tretyak O."),
                new Dog("Petra", new DateTime(2021, 01, 01), 40, 24, "Ahmetov R."),
                new Cat("Myrchik", new DateTime(2019, 05, 11), 19, 14, "Tretyak O."),
                new Dog("Kaisa", new DateTime(2019, 11, 05), 56, 20, "Timoshenko Y."),
                new Carp("Semen", new DateTime(2017, 03, 05), 10, 111, "Tretyak O."),
                new Carp("Vasyl", new DateTime(2019, 08, 09), 10, 112, "Lyashko V.")
        };


            foreach (Animal el in animals)
            {
                el.Print();
                Console.WriteLine(el.Sound);
                Console.WriteLine("-------------------\n");
            }




            //Dog[] dog = new Dog[5];
            //dog[0] = new Dog("Reks", new DateTime(2018, 10, 09), 50, 22, "Ahmetov R.");
            //dog[1] = new Dog("Palmyra", new DateTime(2017, 03, 09), 45, 21, "Ahmetov R.");
            //dog[2] = new Dog("Kamaro", new DateTime(2020, 02, 09), 55, 23, "Poroshenko P.");
            //dog[3] = new Dog("Kaisa", new DateTime(2019, 11, 05), 56, 20, "Timoshenko Y.");
            //dog[4] = new Dog("Petra", new DateTime(2021, 01, 01), 40, 24, "Ahmetov R.");
            //dog[1].AddPuppy();


            //Cat[] cats = new Cat[2];
            //cats[0] = new Cat("Barsik", new DateTime(2017, 12, 10), 17, 15, "Tretyak O.");
            //cats[1] = new Cat("Myrchik", new DateTime(2019, 05, 11), 19, 14, "Tretyak O.");
            //cats[0].AddKitten();


            //Carp[] carps = new Carp[2];
            //carps[0] = new Carp("Semen", new DateTime(2017, 03, 05), 10, 111, "Tretyak O.");
            //carps[1] = new Carp("Vasyl", new DateTime(2019, 08, 09), 10, 112, "Lyashko V.");
            //carps[1].AddDangerTeeth();

            //Console.WriteLine("=========Dogs========\n");

            //foreach (var item in dog)
            //{
            //    item.FinalInfo();
            //    Console.WriteLine(item.Status);
            //    Console.WriteLine("------------------");
            //}

            //Console.WriteLine("=========Cats========\n");

            //foreach (var item in cats)
            //{
            //    item.FinalInfo();
            //    Console.WriteLine(item.Status);
            //    Console.WriteLine("------------------");
            //}

            //Console.WriteLine("=========Carps========\n");

            //foreach (var item in carps)
            //{
            //    item.FinalInfo();
            //    Console.WriteLine(item.DangerStatus);
            //    Console.WriteLine("------------------");
            //}







        }
    }
}
