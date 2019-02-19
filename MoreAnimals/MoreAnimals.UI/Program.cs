using System;
using MoreAnimals.Library;

namespace MoreAnimals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fido1 = new Dog();
            fido1.AnimalId = 0;
            fido1.name = "fido";
            fido1.Breed = "Doberman";

            var fido2 = new Dog
            {
                AnimalId = 1,
                name = "fido",
                Breed = "Doberman"
            };

            fido1.GoTo("park");
            fido1.MakeNoise();

            //upcasting is automatic
            //downcasting must be explicit, since it is not guaranteed to succeed
            int integer = (int)3.4;

            var animals = new IAnimal[2];
            animals[0] = fido1;
            animals[1] = new Eagle
            {
                AnimalId = 3,
                name = "Bill"
            };

            //hiding only works when variable is the type of the lower!
            //So it shouldn't be used

            foreach(IAnimal item in animals)
            {
                Console.WriteLine(item.name);
                item.MakeNoise();
            }

        }
    }
}
