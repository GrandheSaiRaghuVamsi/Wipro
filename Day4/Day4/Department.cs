using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Department : Employee //Inheritance Child cls : Base cls
    {
        public string Depn { get; set; }
        public int sal {  get; set; }

        public Department(int empid, string empname, string deptname, int sal) : base( empid,  empname)
        {
            Depn = deptname;
            this.sal = sal;
        }

        public override void Display()
        {
            base.Display(); // control goes to base class employee
            //Console.WriteLine("Enter value for Depname and sal : ");
            //Depn = Console.ReadLine();
            //sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Depn + " " + sal + " in Dep cls");
        }
    }
}
