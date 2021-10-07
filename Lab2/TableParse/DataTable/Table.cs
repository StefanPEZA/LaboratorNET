using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableParse
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


        public string getMin(int headerIndex, int firstIndex, int secondIndex) 
        {
            double minDif = Math.Abs(Convert.ToDouble(tableRows[0].Get(firstIndex)) - Convert.ToDouble(tableRows[0].Get(secondIndex)));
            string minVal = tableRows[0].Get(headerIndex);
            foreach (TableRow row in tableRows)
            {
                double currentDif = Math.Abs(Convert.ToDouble(row.Get(firstIndex)) - Convert.ToDouble(row.Get(secondIndex)));
                if (currentDif < minDif)
                {
                    minDif = currentDif;
                    minVal = row.Get(headerIndex);
                }
            }
            return minVal;
        }
    }
}
