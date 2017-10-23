using DescuentosSweet.Model.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescuentosSweet.Data
{
    public class TraspalmacenDal
    {
        public List<TRASPALMACEN> getTraspalmacen()
        {
            List<TRASPALMACEN> result = new List<TRASPALMACEN>();
            using (var db = new DBFRESTEntities())
            {
                return db.TRASPALMACEN.ToList();
            }
        }
    }
}
