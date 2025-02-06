using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Employee
    {
        public int Empid {  get; set; }
        public string Empname { get; set; }

        public Employee(int empid, string empname) 
        {
            Empid = empid;
            Empname = empname;
        }

        public virtual void Display()
        {
            //Console.WriteLine("Enter value for Empid and Empname : ");
            //Empid = Convert.ToInt32(Console.ReadLine());
            //Empname = Console.ReadLine();
            Console.WriteLine(Empid + " " + Empname+" in Emp cls");
            
        }
    }
}
