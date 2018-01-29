using IntoToOOPTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            /*set*/ firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);
            secondCat.Eat();
            secondCat.Meow();

            Dog firstDog = new Dog();
            Dog secondDog = new Dog();
            firstDog.runningSpeed = true;
            secondDog.runningSpeed = false;
            firstDog.Bark();
            firstDog.Run();
            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());
            

        }
    }
}