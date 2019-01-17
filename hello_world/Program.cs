using System;
using hello_world;

namespace hello_world
{
    class ToBeInherited
    {
        protected string name_ofstring = "This string is protected in class ToBeInherited()"; 
    }
    class Program:ToBeInherited
    {
        static void Main(string[] args)
        {
            hello_world.My_for_loops for_loop = new My_for_loops();
            hello_world.newClass exClass = new newClass();

            hello_world.Students student_data1 = new Students(1, "Njesh", new DateTime(1993,6,10),
            7123145);
            // when referencing a class or a struct, {namespace.classname} {variable name} = new {class_object} 
            hello_world.Students student2_data = new Students(2, "Mwangi", new DateTime(1992,5,10),
            712312);

            // working with classes with contructor
            hello_world.Teacher teacher1 = new Teacher(21, "Alliance Weru", 71890);

            exClass.firstname = "Tony";
            exClass.middlename = "velvet";
            exClass.lastname = "Wright";
            exClass.age = 20;
            exClass.city = "Jinja";
            exClass.country = "Uganda";
            exClass.street = "17th street, Brookside Drive";
            exClass.date_of_birth = new DateTime(1963, 3, 4);
            
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, my names are {0} {1} {2}", exClass.firstname, exClass.middlename
            , exClass.lastname );
            Console.WriteLine("Student data ID {0} Name {1} Date of Birth {2} Phone Number {3}", student_data1.student_id, student_data1.student_name,
            student_data1.date_birth, student_data1.student_mobile);
            Console.WriteLine("Teacher data, id {0} name {1} Phone number{2}", teacher1.teacher_id,
            teacher1.teacher_name, teacher1.teacher_phone);
            Console.WriteLine(for_loop.exponentialG());

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("\n");
            }
            Access_modifiers message = new Access_modifiers();
            Console.WriteLine(message.my_message);
            Console.WriteLine(message.print_message());
            Console.WriteLine(message.new_string2);

            // how to access a protected type from an inherited class
            Program p = new Program();
            
            Console.WriteLine(p.name_ofstring);

            
        


        }
    }

    


    // class Access_modifiers inherits from class ToBeInherited
    class Access_modifiers : ToBeInherited
    {
        internal string my_message = "This is a string variable";
        /* 
        using a private acess identifier:
        below defined types can only be accessed by the containing 
        type i.e can only be accessed by the code in this same class or struct 
        
        */ 
        private string new_string = "private string";

        public string print_message()
        {
            return new_string;

        }

        public string new_string2 = "This is a public string";

    }

}
