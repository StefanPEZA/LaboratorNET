using System;
using System.Collections.Generic;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            DataParser parser = new DataParser(@"D:\LaboratorNET\Lab2\Weather\weather.dat");
            Table table = parser.ParseFile(3);
            Console.WriteLine( table.getMin(0, 1, 2)); 
        }
    }
}
