using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program76
{
    internal class Program
    {
        static void Main()
        {
            bool result = (true || false) && (false || true) ^ (true && !false);
            Console.WriteLine(result); // False
        }
    }
}

