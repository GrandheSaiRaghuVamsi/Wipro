using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4;

namespace Day4_OOPS
{
    internal class Manager : Department
    {
        public string Managername { get; set; }

        public Manager(int empid, string empname, string deptname, int sal, string mn) : base(empid,  empname,  deptname,  sal)
        {
            Managername = mn;
        }


        public override void Display()
        {
            base.Display();
            //Console.WriteLine("Enter value for Managername : ");
            //Managername = Console.ReadLine();
            Console.WriteLine(Managername + " in Manager cls");
        }
    }
}
