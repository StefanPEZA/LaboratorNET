using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableParse.DataTable
{
    public class TableRow
    {
        public int Count { get; private set; }
        List<string> rowCells = new List<string>();

        public TableRow(int count)
        {
            Count = count;
        }

        public TableRow(List<string> row)
        {
            Count = row.Count;
            rowCells = new List<string>(row);
        }

        public string Get(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                return null;
            }
            return rowCells.ElementAt<string>(index);
        }

        public List<string> Cells()
        {
            return rowCells;
        }

        public override string ToString()
        {
            String str = String.Empty;
            foreach (string cell in this.rowCells)
            {
                str += cell + " / ";
            }
            str += "\n";

            return str.ToString();
        }
    }
}
