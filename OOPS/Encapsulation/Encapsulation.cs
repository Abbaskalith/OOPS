using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSenc.OOPS
{
    class Encapsulation
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string age;

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

    }
}
