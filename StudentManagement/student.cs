using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {

        private string Name;
        private int Sem;
        private string address;
        private string phoneNumber;


    /*    public string Name { get; set; }
        public int Sem { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } */

        public Student(string name, int sem, string address, string phoneNumber)
        {
            Name = name;
            Sem = sem;
            this.address = address;
            this.phoneNumber = phoneNumber;

        }

        public string Name1 { get => Name; set => Name = value; }
        public int Sem1 { get => Sem; set => Sem = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        // ToString method to display student details
        public override string ToString()
        {
            return $"Name: {Name}, Semester: {Sem}, Address: {Address}, Phone: {PhoneNumber}";
        }

    }
}
