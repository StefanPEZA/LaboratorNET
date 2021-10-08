using System;
using TableParse.DataTable;
using TableParse;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            DataParser data = new DataParser(@"E:\LaboratorNET\Lab2\Football\football.dat");
            Table table = data.ParseFile(9);
            Console.WriteLine(table.GetMin(1, 6, 8));
        }
    }
}
