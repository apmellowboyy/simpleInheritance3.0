using Inheritance;
using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;


        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;

        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");

        }


    }

    // derived class of Animal 
    class Horse : Animal
    {
        public int speed;
        public int weight;
        public string name;

        public Horse()
        : base()
        {
            name= "";
            speed = 0;
            weight = 0;
        }
        public Horse(int speed, int weight, string name)
            : base()
        {
            this.speed=speed;
            this.weight=weight;
            this.name=name;
        }
        public void getName()
        {
            Console.WriteLine($"I am an animal, my name is {name}.");
        }
        public void getSpeed()
        {
            Console.WriteLine($"I can go up to {speed} miles per hour.");
        }
        public void getWeight()
        {
            Console.WriteLine($"I'm pretty huge, weighing at {weight}");

        }

    }
    class Capy : Animal
    {
        public int speed;
        public int weight;
        public string name;

        public Capy()
        : base()
        {
            name= "";
            speed = 0;
            weight = 0;
        }
        public Capy(int speed, int weight, string name)
            : base()
        {
            this.speed=speed;
            this.weight=weight;
            this.name=name;
        }
        public void getName()
        {
            Console.WriteLine($"I am an animal, my name is {name}.");
        }
        public void getSpeed()
        {
            Console.WriteLine($"I can go up to {speed} miles per hour.");
        }
        public void getWeight()
        {
            Console.WriteLine($"I'm pretty huge, weighing at {weight}");

        }

    }
}


class Program
{
    static void Main(string[] args)
    {
        // object of base class
        Animal myPet = new Animal();
        myPet.name = "Sparky";
        myPet.display();

        Console.WriteLine();

        // derived class object using default constructor//
        Horse horse = new Horse();
        horse.name = "stephan";
        horse.speed = 35;
        horse.weight = 200;
        horse.getName();
        horse.getSpeed();
        horse.getWeight();

        Console.WriteLine();

        Capy capybara = new Capy();
        capybara.name = "Reginald";
        capybara.speed = 20;
        capybara.weight = 80;
        capybara.getName();
        capybara.getSpeed();
        capybara.getWeight();

        Console.WriteLine();

        //derived class object using parameterized constructor
        Horse Blud = new Horse(40, 180, "Blud");
        Blud.getName();
        Blud.getSpeed();
        Blud.getWeight();

        Console.WriteLine();

        Capy Blake = new Capy(20, 80, "Blake");
        Blake.getName();
        Blake.getSpeed();
        Blake.getWeight();
    }
}
