using DescuentosSweet.Model.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Core;
using System.Data.Entity;

namespace DescuentosSweet.Data
{
    public class AlmacenDal
    {
        public string getNameAlmacen(string obj)
        {
            string b;
            try
            {
                using (DBFRESTEntities db = new DBFRESTEntities())
                {
                    b = db.ALMACEN.Where(x => obj.Contains(x.CODALMACEN)).
                        Select(x => x.NOMBREALMACEN).FirstOrDefault();
                }
            }
            catch (EntityException ex)
            {
                throw new EntityException (ex.Message);
            }
            return b.ToString();
        }
    }
}
