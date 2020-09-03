using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    class Animal
   {
       public string Name { get; set; }
       public Animal(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Dog :  Animal
    {
        private float speed;
       public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;
            Console.WriteLine("Speed: " + speed);
          
        }
    }
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            Dog tom = new Dog(12.23f, "Tom" );
            Console.WriteLine(tom.Name);

            Dog jerry = new Dog(23.25f, "Jerry");
            jerry.Name = "Jerry";
           
            Console.WriteLine();
            Console.WriteLine(jerry.Name);
            jerry.Print();
        }
    }


}