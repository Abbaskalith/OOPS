using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSoverride.OOPS
{
    class Dog
    {
        public virtual void Sound()
        {
            Console.WriteLine("Barking");
        }
    }

    class Puppy: Dog
    {
        public virtual void Sound()
        {
            Console.WriteLine("Weeping");
        }
    }
}
