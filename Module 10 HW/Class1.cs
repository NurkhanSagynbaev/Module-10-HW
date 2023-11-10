using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_HW
{
    class Program
    {
        static void Main()
        {
            
            Person person = new Person { Name = "John", Age = 30 };
            Student student = new Student { Name = "Alice", Age = 20, StudentId = 123, Advisor = new Teacher { Name = "Mr. Smith", Age = 40 } };
            Teacher teacher = new Teacher { Name = "Mrs. Johnson", Age = 35, Students = new List<Student> { new Student { Name = "Bob", Age = 25, StudentId = 456 } } };

            
            person.Print();
            student.Print();
            teacher.Print();

            SimpleCalculator simpleCalculator = new SimpleCalculator();
            AdvancedCalculator advancedCalculator = new AdvancedCalculator();

            double resultAdd = advancedCalculator.Add(5, 3);
            double resultPower = advancedCalculator.Power(2, 3);

            simpleCalculator.PrintResult(resultAdd);
            simpleCalculator.PrintResult(resultPower);
        }
    }

}
