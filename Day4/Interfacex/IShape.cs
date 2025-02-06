using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacex
{
    internal interface IShape
    {
        void calarea();

        void defaultSquare(int x)
        {
            Console.WriteLine($"Area of Square : {x*x}");
        }
    }

    class Circle : IShape
    {
        public int radius { get; set; }
        public void calarea()
        {
            Console.WriteLine($"Area of Circle : {Math.PI * Math.Pow(radius , 2)}"); 
        }
    }

    class Rect : IShape
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public void calarea()
        {
            Console.WriteLine($"Area of Rect : {length*breadth}");
        }
    }
}
