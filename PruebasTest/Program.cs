using com.sweet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar = new TraspasoRepository();
            foreach(var a in ar.Listar())
            {
                Console.WriteLine(string.Format("El articulo {0}",
                    a.CODARTICULO)
                    );
            }

        }
    }
}
