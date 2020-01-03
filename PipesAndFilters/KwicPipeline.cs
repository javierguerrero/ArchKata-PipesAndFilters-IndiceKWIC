using System;
using System.Collections.Generic;
using System.Text;

namespace PipesAndFilters
{
    public class KwicPipeline : Pipeline<string>
    {
        public KwicPipeline()
        {
            Register(new Reader());
            Register(new Shifter());
            Register(new Sorter());
            Register(new Writer());
        }
    }
}

