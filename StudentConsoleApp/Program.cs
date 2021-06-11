using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Student {
        public String rollno, fname, lnam;
    }
    class Marks : Student {
        float eng, mar, hin, maths, sst, sci;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Marks m = new Marks();
            Console.Write("Enter Roll no. : ");
            m.rollno = Console.ReadLine();
            Console.WriteLine(m.rollno);
            Console.ReadKey();

        }
    }
}
