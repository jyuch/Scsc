using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scsc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".assembly Temp {}");
            Console.WriteLine(".method public static int32 main()");
            Console.WriteLine("{");
            Console.WriteLine(".entrypoint");
            Console.WriteLine("ldc.i4 42");
            Console.WriteLine("ret");
            Console.WriteLine("}");
        }
    }
}
