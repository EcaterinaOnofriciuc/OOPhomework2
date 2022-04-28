using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhomework2.Part_3
{
    internal class Student:User
    {
        private int _scolarship;
        private int _course;
        public Student(int scolarship, int course)
        {
            _scolarship = scolarship;
            _course = course;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student's scolarhip: {_scolarship}");
            Console.WriteLine($"Student's course: {_course}");
        }
    }
}
