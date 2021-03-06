﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipesAndFilters
{
    public class Sorter : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            LineComparer lineComparer = new LineComparer();
            input.ToList<string>().Sort(lineComparer);
            return input;
        }
    }
}



