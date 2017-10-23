using com.sweet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweet.Repository
{
    public class TraspasoRepository
    {
        public List<TRASPALMACEN> Listar()
        {
            using (var ctx = new LocalContext())
            {
                return ctx.TRASPALMACEN.ToList();
            }
        }
    }
}
