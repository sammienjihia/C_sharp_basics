using System;

namespace hello_world
{
    // Using a struct with a constructor method
    struct Students 
    {
        public int student_id;
        public string student_name;
        public DateTime date_birth;
        public int student_mobile;
        public Students (int studentId, string studentName, DateTime studentDob, int studentMobile) 
        {
            student_id = studentId;
            student_name = studentName;
            student_mobile = studentMobile;
            date_birth = studentDob;

        }

        

    }
    class Teacher
        {
            public int teacher_id;
            public string teacher_name;
            public int teacher_phone;
            
            public Teacher(int teacherId, string teacherName, int teacherPhone)
            {
                teacher_id = teacherId;
                teacher_name = teacherName;
                teacher_phone = teacherPhone;

            }

        }

    class  Uprogram
    {
        internal string program_name;
        internal string department_head;
        internal string dgree;
        internal string[] marks = {"pass", "fail"};
        public Uprogram(string p_name, string d_head, string degree)
        {
             program_name= p_name;
             department_head = d_head;
             dgree = degree;
        }
    }
}