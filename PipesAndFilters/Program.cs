using System;

/*
Leer articulo: https://dzone.com/articles/pipes-and-filters-pattern-net
Explicación de KWIC: http://www.lcc.uma.es/~jmmb/lto/Practica6.pdf
https://github.com/keyvan/PipesAndFilters4DotNet
*/

namespace PipesAndFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            KwicPipeline pipeline = new KwicPipeline();
            pipeline.Execute();
        }
    }
}