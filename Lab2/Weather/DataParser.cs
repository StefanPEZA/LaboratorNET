using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Weather
{
    class DataParser
    {
        private string filePath;

        public DataParser(string filePath)
        {
            this.filePath = filePath;
        }

        public Table ParseFile()
        {
            Table table = new Table();
            string[] rows = File.ReadAllLines(filePath);
            string header = rows[0];

            for (int index = 1; index < rows.Length; index++)
            {
                string row = rows[index];
                if (row.Trim() == "")
                    continue;
                Console.WriteLine(row);
            }

            return table;
        }
    }
}
