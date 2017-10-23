
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.sweetcoffee.Data;

namespace PruebasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new TraspasoDal();
            obj.getTraspasos();
        }
    }
}
