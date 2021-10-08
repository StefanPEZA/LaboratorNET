using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TableParse.DataTable;

namespace TableParse
{
    public class DataParser
    {
        private string filePath;

        public DataParser(string filePath)
        {
            this.filePath = filePath;
        }

        private static bool isDigitOrDot(char c)
        {
            if (char.IsDigit(c) || c == '.' || c == ',')
            {
                return true;
            }
            return false;
        }

        public static double ToDouble(string number)
        {
            double result;
            string aux = String.Join("", number.Where(isDigitOrDot));
            result = Double.Parse(aux);
            return result;
        }

        public Table ParseFile(int numberOfColumns)
        {
            Table table = new Table();
            string[] rows = File.ReadAllLines(filePath);
            
            for (int index = 1; index < rows.Length; index++)
            {
                string row = rows[index];
                if (row.Replace("-", "").Trim() == "")
                    continue;
                string[] columns = row.Trim().Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);

                if (numberOfColumns >= 0)
                {
                    columns = columns.Take<string>(numberOfColumns).ToArray();
                }

                table.AddRow(columns.ToList());
            }
            return table;
        }
    }
}
