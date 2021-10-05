using System;
using System.Collections.Generic;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            DataParser parser = new DataParser(@"E:\LaboratorNET\Lab2\Weather\weather.dat");
            parser.ParseFile();
        }
    }
}
