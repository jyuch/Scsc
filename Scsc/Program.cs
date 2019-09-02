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
            Console.WriteLine(".method public static void main()");
            Console.WriteLine("{");
            Console.WriteLine(".entrypoint");
            Console.WriteLine("ret");
            Console.WriteLine("}");
        }
    }
}
