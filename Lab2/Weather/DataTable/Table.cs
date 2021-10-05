using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Table
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


        //public double getMin(int headerIndex, int firstIndex, int secondIndex);
    }
}
