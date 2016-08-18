using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCode.Generators.CSharp.Tool
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Any())
            {
                Console.WriteLine("Hello " + args[0]);
            }
            else
            {
                Console.WriteLine("Hello there!");
            }
            return 1;
        }
    }
}
