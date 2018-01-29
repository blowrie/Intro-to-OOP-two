﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToOOPTwo
{
    class Cat
    {
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength;


    public string Name
        {
            get { return this.name; }
            set { this.name = value; } //value is a key word 
        }

        public string HairLength
        {
            get { return this.hairLength;  }
            set { this.hairLength = value; }
        }

        public Cat()
        {

        }

        // OverLoad Constructor
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
    
         }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("/a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + " had a hairball");
            }
            else
            {
                return (this.name + " is nicely groomed.");
            }
        }

    }
}

