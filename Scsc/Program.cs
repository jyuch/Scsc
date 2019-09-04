using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Scsc
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args[0].Length < 1)
            {
                Console.WriteLine("Invalid input");
                return -1;
            }

            var input = args[0];

            Console.WriteLine(".assembly extern mscorlib { .publickeytoken = (B7 7A 5C 56 19 34 E0 89) .ver 4:0:0:0 }");
            Console.WriteLine(".assembly Temp {}");
            Console.WriteLine(".method public static int32 main()");
            Console.WriteLine("{");
            Console.WriteLine(".entrypoint");
            Console.WriteLine(".maxstack 2");

            {
                var a = ParseInt(input);
                input = a.Remain;
                Console.WriteLine("ldc.i4 {0}", a.Value);
            }

            while (input.Length != 0)
            {
                if (input[0] == '+')
                {
                    input = input.Substring(1);
                    var a = ParseInt(input);
                    input = a.Remain;
                    Console.WriteLine("ldc.i4 {0}", a.Value);
                    Console.WriteLine("add");
                }
                else if (input[0] == '-')
                {
                    var a = ParseInt(input.Substring(1));
                    input = a.Remain;
                    Console.WriteLine("ldc.i4 {0}", a.Value);
                    Console.WriteLine("sub");
                }
                else
                {
                    Console.Error.WriteLine("Invalid char: '{0}'", input[0]);
                    return -1;
                }
            }

            Console.WriteLine("ret");
            Console.WriteLine("}");
            return 0;
        }

        static Result ParseInt(string input)
        {
            var buffer = new StringBuilder();
            int remain = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var c = input[i];

                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' ||
                    c == '8' || c == '9')
                {
                    buffer.Append(c);
                    remain += 1;
                }
                else
                {
                    break;
                }
            }

            return new Result() { Value = int.Parse(buffer.ToString()), Remain = input.Substring(remain) };
        }
    }

    struct Result
    {
        public int Value;
        public string Remain;
    }
}
