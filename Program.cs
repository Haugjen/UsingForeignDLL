using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathDLLTurorial;

namespace UsingForeignDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMachine mm = new MathMachine();
            Console.WriteLine("Adding 2 and 3");
            Console.WriteLine(mm.Add(2,3));
            Console.WriteLine();
            Console.WriteLine("Dividing 2 by 0!! :(");
            Console.WriteLine(mm.Divide(2,0));
            Console.WriteLine();
            Console.WriteLine("Multiplying 2 by 3");
            Console.WriteLine(mm.Multiply(2,3));
            Console.WriteLine();
            Console.WriteLine("subtracting 3 from 2");
            Console.WriteLine(mm.Subract(2,3));
            Console.ReadLine();
        }
    }
}
