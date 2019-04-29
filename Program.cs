using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Example {
    class Program {
        static void Main() {
            Console.WriteLine("Logical Operator Examples:\n");
            LogicalOperators.Run();

            Console.WriteLine();

            Console.WriteLine("Bitwise Operator Examples:\n");
            BitwiseOperators.Run();
            Console.ReadKey();
        }
    }
}
