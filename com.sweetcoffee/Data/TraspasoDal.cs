using com.sweetcoffee.Model.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sweetcoffee.Data
{
    public class TraspasoDal
    {
        public List<TRASPALMACEN> getTraspasos()
        {
            List<TRASPALMACEN> result = new List<TRASPALMACEN>();
            using (var db = new DBFRESTEntities())
            {
                result = db.TRASPALMACEN.ToList();
            }
            return result;
        }
    }
}
