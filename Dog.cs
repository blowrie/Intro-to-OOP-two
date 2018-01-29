using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToOOPTwo
{
    class Dog
    {
        private string hairLength;
        private string height;
        public bool runningSpeed = true;
        private int weight;

        public Dog()
        {

        }

        public Dog(string hairLength, string height, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.weight = weight;
        }

        public void Run()
        {
            if (runningSpeed)
            {
                Console.WriteLine("Your dog is fast");
            }
            Console.WriteLine("Your dog is slow");
        }
        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {

        }

        public void Cuddle()
        {

        }
    }
}
