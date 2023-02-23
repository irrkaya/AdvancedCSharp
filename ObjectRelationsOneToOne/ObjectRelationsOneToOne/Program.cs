using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College;

namespace ObjectRelationsOneToOne
{
    internal class Program
    {
        static void Main()
        {
            //Student classes object
            Student student = new Student();
            student.RollNo = 123;
            student.StudentName = "Mila";
            student.Email = "mila@gmail.com";

            //Branch classes object
            Branch br = new Branch();
            br.BranchName = "Computer Science Engineering";
            br.NoOfSemesters = 8;

            //one-to-one relation
            student.branch = br;

            //display
            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemesters);
        }
    }
}
