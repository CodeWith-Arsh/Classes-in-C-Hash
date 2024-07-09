using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
    //Classes Derived and Base Classes
    /*class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }*/

    //Polymorphism and Overriding Methods
    /*class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("This Animal Makes a Sound");
        }
        class Pigeon : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("this is Pigeon sound:Koo KOO");
            }
            class Dog : Animal
            {
                public override void animalSound()
                {
                    Console.WriteLine("This is Dog Sound Boo BOo");
                }
                class Program
                {
                    static void Main(string[] args)
                    {
                        Animal myAnimal = new Animal();
                        Animal myPigeon = new Animal();
                        Animal myDog = new Animal();
                        myAnimal.animalSound();
                        myPigeon.animalSound();
                        myDog.animalSound();
                        Console.WriteLine("These are the examples of the Polymorphism");

                    }
                }
            }
        }
    }*/

    /*    class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();
            }

        }*/

    //Abstract Class
    /*abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzzzzz");
        }

        class Hen : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The hen says Koo Koo");
            }
        }

        class Dog : Animal
        {
            public override void animalSound()
            {
                {
                    Console.WriteLine("The Dog says woo woo");
                }
            }
            class Program
            {
                static void Main(string[] args)
                {
                    Hen myHen = new Hen();
                    myHen.animalSound();
                    myHen.sleep();
                }

            }
        }
    }*/

    //Interfaces
    /* interface IFirstInterface
    {
        void myMethod(); //Interface Method
    }
    interface ISecondInterface 
    {
        void myOtherMethod();
    }
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod() { Console.WriteLine("Some text...."); }
        public void myOtherMethod() { Console.WriteLine("More text"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass();
            demo.myMethod();
            demo.myOtherMethod();
        }
    }*/

    //Enums -Group of constants
    /*enum level
        {
            Low,
            Medium, 
            High

        }
        class Program
        {
            static void Main(string[] args)
            {
                level myVar = level.Low;
                level myVar2 = level.Medium;
                level myVar3 = level.High;
                Console.WriteLine("This is "+myVar +" "+ myVar2 + "    "+ myVar3);
            }
        }*/

    //C # Files

    /*class Program
    {
        static void Main(string[] args) 
        { 
            string writeText = Console.ReadLine();
            File.WriteAllText("ABC.txt",writeText);
            string readText = File.ReadAllText("ABC.txt");
            Console.WriteLine(readText);


        }

    }*/

    //Exceptions

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                Console.WriteLine(myNumbers[5]);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }

        }
    }
}