using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_HW
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Person: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Person: {Name}, Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return (Name + Age).GetHashCode();
        }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
        public Teacher Advisor { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Student: {Name}, Age: {Age}, Student ID: {StudentId}");
        }
    }

    public class Teacher : Person
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public override void Print()
        {
            Console.WriteLine($"Teacher: {Name}, Age: {Age}, Students: {Students.Count}");
        }
    }

}
