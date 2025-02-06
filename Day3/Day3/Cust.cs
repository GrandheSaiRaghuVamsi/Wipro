using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Cust
    {
        public int cid;
        public string cname;

        public void Display()
        {
            Console.WriteLine(cid + " " + cname);
        }
    }
}
