﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Scsc
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(args[0]);

            Console.WriteLine(".assembly extern mscorlib { .publickeytoken = (B7 7A 5C 56 19 34 E0 89 ) .ver 4:0:0:0 }");
            Console.WriteLine(".assembly Temp {}");
            Console.WriteLine(".method public static int32 main()");
            Console.WriteLine("{");
            Console.WriteLine(".entrypoint");
            Console.WriteLine("ldc.i4 {0}", n);
            Console.WriteLine("ret");
            Console.WriteLine("}");
        }
    }
}
