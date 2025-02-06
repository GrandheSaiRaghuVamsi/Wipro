using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Product
    {
        int Proid ;
        string Proname ;

        public Product(int id,string name)
        {
            Proid = id;
            Proname = name;
        }

        private void SampleMthd()
        {
            Console.WriteLine("Private Method");
        }

        public void PublicMthd()
        {
            //private instance
            Console.WriteLine("Public Method"+Proid+" "+Proname);
            SampleMthd();
        }
    }
}
