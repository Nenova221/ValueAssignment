using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAssignment
{
    public class ValueAssignment
    {
        static void Main(string[] args)
        {
            int n = 35, p = 5, v = 0;
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n);
        }
    }
}
