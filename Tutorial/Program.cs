using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            a a1 = null;
            if(a1 != null)
            {
                Console.WriteLine(a1.value);
            }

        }
    }

    class a
    {
        public int value;
        public a(int _value)
        {
            value = _value;
        }
    }
}
