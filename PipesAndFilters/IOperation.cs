using System;
using System.Collections.Generic;
using System.Text;

namespace PipesAndFilters
{
    public interface IOperation<T>
    {
        IEnumerable<T> Execute(IEnumerable<T> input);
    }
}