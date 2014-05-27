using System;
using System.Linq;

namespace GenericMethodProblem
{
    public class StringWorks
    {
        public static string CleanTag(string col)
        {
            string newCol = col;
            if (newCol.IndexOf("<", StringComparison.Ordinal) > -1)
            {
                newCol = newCol.Substring(0, newCol.IndexOf("<", StringComparison.Ordinal));
            }
            return newCol;
        }

        public static string[] GetColumns(string row)
        {
            string newrow = row.Replace("<td>", "~");
            string[] cols = newrow.Split('~');

            return cols.Select(CleanTag).ToArray();
        }
    }
}
