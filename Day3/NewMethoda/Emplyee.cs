using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethoda
{
    internal class Emplyee
    {
        //attributes/pops/data membs
        public int EmpId { get; set; }
        public string Empname { get; set; }
        public string Dept { get; set; }
        public decimal sal {  get; set; }

        //constructor
        public Emplyee(int EmpId, string Empname, string Dept, decimal sal)
        {
            this.EmpId = EmpId;
            this.Empname = Empname;
            this.Dept = Dept;
            this.sal = sal;
        }

        //methods
        public void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"EmplyeeId:{EmpId} EmplyeeName:{Empname} Dept:{Dept} Salary:{sal}");
        }
    }
}
