using System;
using System.Collections.Generic;
using System.Linq;

namespace TableParse.DataTable
{
    public class Table
    {
        private List<TableRow> tableRows = new List<TableRow>();

        public bool AddRow(TableRow row)
        {
            if (row == null)
                return false;

            this.tableRows.Add(row);
            return true;
        }

        public bool AddRow(List<String> row)
        {
            if (row == null)
                return false;

            this.tableRows.Add(new TableRow(row));
            return true;
        }

        public List<TableRow> Rows()
        {
            return tableRows;
        }


        public string GetMin(int headerIndex, int firstIndex, int secondIndex) 
        {
            double minDif = 9999;
            string minVal = tableRows.ElementAt(0).Get(headerIndex);
            foreach (TableRow row in tableRows)
            {
                double currentDif = Math.Abs(DataParser.ToDouble(row.Get(firstIndex)) - DataParser.ToDouble(row.Get(secondIndex)));
                if (currentDif < minDif)
                {
                    minDif = currentDif;
                    minVal = row.Get(headerIndex);
                }
            }
            return minVal;
        }

        public override string ToString()
        {
            String str = String.Empty;

            foreach (TableRow line in this.tableRows)
            {
                str += line.ToString() + "\n";
            }

            return str.ToString();
        }
    }
}
