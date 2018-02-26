using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using static System.Convert;
using static System.Console;

namespace ConsoleApp2
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3, 
        west = 4,
    }
    class Program
    {
        static void Main(string[] args)
        {

            ushort destinationVar;
            char sourceVar = 'a';
            destinationVar = sourceVar;
            WriteLine($"sourceVar val: {sourceVar}");
            WriteLine($"destinationVar val: {destinationVar}");


        }


    }

   
}
