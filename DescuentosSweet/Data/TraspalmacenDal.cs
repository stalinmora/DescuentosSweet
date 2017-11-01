using DescuentosSweet.Model.Local;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;

namespace DescuentosSweet.Data
{
    public class TraspalmacenDal
    {
        private DBFRESTEntities db = new DBFRESTEntities();

        private AlmacenDal alm = new AlmacenDal();
        private VendedoresDal ven = new VendedoresDal();

        /*
        public List<TRASPALMACEN> getTraspalmacen()
        {
            List<TRASPALMACEN> result = new List<TRASPALMACEN>();
            using (db)
            {
                return db.TRASPALMACEN.ToList();
            }
        }
        */

        public List<TRASPALMACEN> getTraspalmacenDistint()
        {
            List<TRASPALMACEN> result = new List<TRASPALMACEN>();
            try
            {
                using (DBFRESTEntities db = new DBFRESTEntities())
                {
                    var almacen = new string[] { "T5", "T1" };
                    result = db.TRASPALMACEN.
                        Where(x => almacen.Contains(x.CODALMDEST)).
                        GroupBy(z => z.NUMERO).
                        Select(z => z.FirstOrDefault()).OrderBy(x => x.FECHA).ToList();
                }
            }
            catch (EntityException ex)
            {
                throw new EntityException(ex.Message);
            }
            return result;
        }


        public List<TraspasoTRASPALMACEN> GetTraspasoTRASPALMACEN(DateTime start, DateTime end)
        {
            List<TRASPALMACEN> a = new List<TRASPALMACEN>();
            foreach (var b in getTraspalmacenDistint().Where(x => x.FECHA >= start && x.FECHA <= end))
            {
                a.Add(new
                    TraspasoTRASPALMACEN
                {
                    NUMERO = b.NUMERO,
                    CODALMDEST = b.CODALMDEST,
                    NOMBREALMACENORIGEN = alm.getNameAlmacen(b.CODALMORIG),
                    NOMBREALMACENDESTINO = alm.getNameAlmacen(b.CODALMDEST),
                    NOMBRECORTO = ven.getVendedor(b.USUARIO.GetValueOrDefault()).NOMBRECORTO,
                    FECHA = b.FECHA
                    }
                );
            }

            //var obj = db.TRASPALMACEN.Join(db.ALMACEN, x => x.CODALMDEST, y => y.CODALMACEN, (x, y) => new { x.CODALMDEST, y.NOMBREALMACEN }).ToList();

            List<TraspasoTRASPALMACEN> c = new List<TraspasoTRASPALMACEN>(a.OfType<TraspasoTRASPALMACEN>());
            return c;
        }
    }
}
