using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    public class BaseKisi
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine("FirstName: " + FirstName);
            Console.WriteLine("LastName: " + LastName);
        }
    }

    public class Student : BaseKisi
    {
        public string StudentNumber { get; set; }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Student Number: " + StudentNumber + "\n");
        }
    }

    public class Teacher : BaseKisi
    {
        public int TeacherSalary { get; set; }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Teacher Salary: " + TeacherSalary + "\n");
        }
    }
}
