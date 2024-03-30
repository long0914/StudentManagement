using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);

        }

        // Method to get the list of students
        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
