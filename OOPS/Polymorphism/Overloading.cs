using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSOverload.OOPS
{
    class Overloading
    {

        public void Add(int a, int b)
        {
            int sum = a + b;
            //return sum;
            Console.WriteLine("Sum :" + sum);
        }

        public void Add(int a, int b, int c)
        {
            int sum = a + b + c;
            //return sum;
            Console.WriteLine("Sum :" + sum);
        }


    }
}
