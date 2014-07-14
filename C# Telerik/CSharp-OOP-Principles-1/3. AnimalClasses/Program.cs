using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            //Create arrays with animals of each kind
            Cat[] cats = { new Cat("Bella", 3, Sex.Female),
                         new Cat("Stella", 4, Sex.Female),
                         new Cat("Boncho", 6, Sex.Male),
                         new Cat("Toshko", 5, Sex.Male),
                         new Cat("Katq", 8, Sex.Female)};

            Dog[] dogs = { new Dog("Gari", 4, Sex.Male),
                         new Dog("Lori", 5, Sex.Female),
                         new Dog("Sara", 7, Sex.Female),
                         new Dog("Torn", 9, Sex.Male),
                         new Dog("Charli", 2, Sex.Male)};

            Kitten[] kittens = { new Kitten("Lili", 1),
                               new Kitten("Bella", 1),
                               new Kitten("Sara", 2),
                               new Kitten("Lori", 1),
                               new Kitten("Pipi", 2),};

            Tomcat[] tomcats = { new Tomcat("Toshko", 2),
                               new Tomcat("Torn", 2),
                               new Tomcat("Boncho", 2),
                               new Tomcat("Zevs", 2),
                               new Tomcat("Gari", 2),};

            Frog[] frogs = { new Frog("Jabco", 1, Sex.Male),
                           new Frog("Lon", 1, Sex.Male),
                           new Frog("Tom", 1, Sex.Male),
                           new Frog("Firio", 1, Sex.Male),
                           new Frog("Sila", 1, Sex.Female),};

            //Calculate average age of each kind of animal
            var CatsAvgAge = (from cat in cats
                              select cat.Age).Average();

            var DogsAvgAge = (from dog in dogs
                              select dog.Age).Average();

            var KittensAvgAge = (from kite in kittens
                                 select kite.Age).Average();

            var TomCatsAvgAge = (from TomCat in tomcats
                                 select TomCat.Age).Average();

            var FrogsAvgAge = (from frog in frogs
                               select frog.Age).Average();

            //Printing result to console
            Console.WriteLine("Cats average age: {0} years.", CatsAvgAge);
            Console.WriteLine("Dogs average age: {0} years.", DogsAvgAge);
            Console.WriteLine("Kittens average age: {0} years.", KittensAvgAge);
            Console.WriteLine("TomCats average age: {0} years.", TomCatsAvgAge);
            Console.WriteLine("Frogs average age: {0} years.", FrogsAvgAge);
        }
    }
}
