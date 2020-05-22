using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20042020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Man man = new Man("man");
            //Woman woman = new Woman("woman");
            //man.Eat();
            //woman.Eat();

            //Person meherrem = new Person("Meherrem", 23);
            //Person cabbar = new Person("Cabbar", 20);
            //Console.WriteLine(meherrem < cabbar);

            int x = 5;
            //object y = x; integeri objecte UP cast eledik
            Shark sh = new Shark();
            string text = "sldkdf";
            //upcasting
            Eagle eagle = new Eagle();
            object shark = new Shark();

            //Animal eagle1 = eagle; also called implicit casting


            //downcasting ==>> which is dangerous
            Bird b = new Eagle();
            Eagle e1 = (Eagle)b; /*also called explicit casting*/

            object[] animals = { eagle, sh, x, text };

            foreach (var animal in animals)
            {
                if(animal is Animal)
                {
                    Console.WriteLine("this index contains a animal type");
                }
                else
                {
                    Console.WriteLine("this indexes does not contain animal type object");
                }
            }

            //secure downcasting - 1 >>> cevire bilirse ozunu bilmirse null qaytaracaq

            if (e1 as Eagle != null)
            {
                Console.WriteLine("that's an eagle");
            }
            else
            {
                Console.WriteLine("that's an eagle");
            }
            Console.WriteLine(e1 is Eagle);

            // secure casting - 2 >>> yalniz true false qaytarir
            if (e1 is Eagle)
            {
                Console.WriteLine("that's an eagle");
            }
            else
            {
                Console.WriteLine("that's an eagle");
            }
        }

        #region Abstract class and method
        abstract class Human
        {
            public Human(string text)
            {
                Console.WriteLine();
            }

            public string Name;

            public string Surname;

            public bool Gender;

            public abstract void Eat();

        }

        class Man : Human
        {
            // abstract classin constructorunda deyer isteyirikse o deyeri  
            // miras almish classlarin constructorunda gondermeliyik
            public Man(string word) : base(word)
            {

            }

            public override void Eat()
            {
                Console.WriteLine("Men have an ability to eat"); ;
            }

        }

        class Woman : Human
        {
            public Woman(string word) : base(word)
            {

            }

            public override void Eat()
            {
                Console.WriteLine("Women have an ability to eat"); ;
            }
        }
        #endregion


        #region Custom type operators
        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }

            public int Age { get; set; }

            public static bool operator > (Person p1, Person p2)
            {
                return p1.Name.Length > p2.Name.Length;
            }
            public static bool operator < (Person p1, Person p2)
            {
                return p1.Name.Length < p2.Name.Length;
            }
        }
        #endregion


        #region Polymorphism, Casting

        abstract class Animal
        {
            public abstract void Eat();
        }

        abstract class Fish : Animal
        {
            public abstract void Swim();
        }

        abstract class Bird : Animal
        {
            public abstract void Fly();
        }

        class Shark : Fish
        {
            public int SwimmingSpeed { get; set; }

            public int Weight { get; set; }

            public override void Eat()
            {
                Console.WriteLine("fish can eat");
            }

            public override void Swim()
            {
                Console.WriteLine("fish can swim");
            }
        }

        class Eagle : Bird
        {
            public int FlyingSpeed { get; set; }

            public override void Eat()
            {
                Console.WriteLine("bird can eat");
            }

            public override void Fly()
            {
                Console.WriteLine("bird can fly");
            }
        }

        class Duck : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("bird can eat");
            }

            public override void Fly()
            {
                Console.WriteLine("bird can fly");
            }
        }
        #endregion

    }
}
