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
}