using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27042020
{
    class Student : object
    {
        public Student(string name, string surname)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        //public string Fullname()
        //{
        //    //return Name + " " + Surname;
        //    return $"{Name} {Surname}";
        //}
        public static void DemoMethod()
        {
            
            Console.WriteLine("this a static method");
        }

        public int Id;

        public string Name;

        public string Surname;

        public static int _id = 0;

    }
}
