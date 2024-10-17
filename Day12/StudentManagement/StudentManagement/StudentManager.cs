using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        // Add a new student
        public void Add(Student student)
        {
            foreach (var item in students)
            {
                if (item.RegNo == student.RegNo)
                {
                    Console.WriteLine("Student already exists");
                    return;
                }
            }

            students.Add(student);
            Console.WriteLine("Added successfully");
        }
        public void Search(string regNo)
        {
            foreach (var student in students)
            {
                if (student.RegNo == regNo)
                {
                    Console.WriteLine(student);
                    return;
                }
            }
            Console.WriteLine("Student not found");
        }
        public void Update(string regNo, string name, string className)
        {
            var student = GetStudentByRegNo(regNo);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            student.Name = name;
            student.Class = className;
            Console.WriteLine("Updated successfully.");
        }
        public void Delete(string regNo)
        {
            var student = GetStudentByRegNo(regNo);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            students.Remove(student);
            Console.WriteLine("Deleted successfully.");
        }
        private Student GetStudentByRegNo(string regNo)
        {
            foreach (var student in students)
            {
                if (student.RegNo == regNo)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
