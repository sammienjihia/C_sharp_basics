using System;
using hello_world;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            hello_world.newClass exClass = new newClass();

            exClass.firstname = "Tony";
            exClass.middlename = "velvet";
            exClass.lastname = "Wright";
            exClass.age = 20;
            exClass.city = "Jinja";
            exClass.country = "Uganda";
            exClass.street = "17th street, Brookside Drive";
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, my names are {0} {1} {2}", exClass.firstname, exClass.middlename
            , exClass.lastname );
        }
    }
}
