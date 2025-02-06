using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethoda
{
    internal class EmpCRUDops
    {
        private const int s = 5;
        //create an array for 5 emps
        Emplyee[] emps = new Emplyee[s];
        private int empcount = 0;

        //methods to perform CRUD
        public void Addemp(int EmpId, string Empname, string Dept, decimal sal)
        {
            emps[empcount] = new Emplyee(EmpId, Empname, Dept, sal);
            empcount++;
            Console.WriteLine("EMP added Successfully");
        }

        public void Listemp()
        {
            for (int i = 0; i < empcount; i++)
            {
                emps[i].Display();
            }
        }

        public void Updateemp()
        {

        }

        public void Deleteemp()
        {

        }

    }
}
