using System;
using System.Collections.Generic;
using System.Text;

namespace PipesAndFilters
{
    public class LineComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y);
        }
    }
}


