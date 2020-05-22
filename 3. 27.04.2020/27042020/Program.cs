using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27042020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student fuad = new Student("Fuad", "Refizade");
            //Student shebnem = new Student("Şəbnəm", "Həsənli");
            Student ziba = new Student("Ziba", "Qasımova");

            Console.WriteLine(ziba);

            //Console.WriteLine(fuad.Fullname());

            Student.DemoMethod();

            //Person person = new Person();
            //Person person1 = new Person();
            Person.Test();
        }
    }

    class Person
    {
        static Person()
        {
            Console.WriteLine("This is a static constructor");
        }
        public static string Name { get; set; }

        public static void Test()
        {
            Console.WriteLine("testing method");
        }
    }


}
