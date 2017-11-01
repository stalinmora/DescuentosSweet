using DescuentosSweet.Model.Local;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;

namespace DescuentosSweet.Data
{
    public class VendedoresDal
    {
        public VENDEDORES getVendedor(int codigo)
        {
            VENDEDORES vendedor = new VENDEDORES();
            try
            {
                using (DBFRESTEntities db = new DBFRESTEntities())
                {
                    vendedor = db.VENDEDORES.Where(x => x.CODVENDEDOR == codigo).Select(x => x).FirstOrDefault();
                }
            }
            catch (EntityException ex)
            {
                throw new ConnectionFailedException(ex);
            }
            return vendedor;
        }
    }
}
