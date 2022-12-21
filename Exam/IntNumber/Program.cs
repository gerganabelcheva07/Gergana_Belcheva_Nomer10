using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n1 = 12345678912345678923;
            byte n2 = 204;
            double n3 = 8923.1234857;
            double n4 = 134.567839023;
            sbyte n5 = -105;
            char symbol = 'R';
            Console.WriteLine($"{n1}, {n2}, {n3}, {n4}, {n5}, {symbol}");
        }
    }
}
