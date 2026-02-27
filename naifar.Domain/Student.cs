using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naifar.Domain
{
    public class Student
    {
        private static int IdGenerator = 0;

        public int ID { get; set; }

        private string? firstName;

        public string? FirstName
        {
            get { return firstName; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    firstName = "John";
                }
                else
                {
                    firstName = value;
                }
            }
        }

        private string? lastName;

        public string? LastName
        {
            get { return lastName; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    lastName = "Doe";
                }
                else
                {
                    lastName = value;
                }
            }
        }


        public Student()
        {
            IdGenerator++;
            ID = IdGenerator;
        }
        public Student(string firstName, string lastName) : this() {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
