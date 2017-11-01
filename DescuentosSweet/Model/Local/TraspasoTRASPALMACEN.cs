using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescuentosSweet.Model.Local
{
    public class TraspasoTRASPALMACEN : TRASPALMACEN
    {
        /*
        public string SERIE { get; set; }
        public int NUMERO { get; set; }
        public int LINEA { get; set; }
        public string CODALMORIG { get; set; }
        public string CODALMDEST { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<int> CODARTICULO { get; set; }
        public string REFERENCIA { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<double> UNIDADES { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<int> USUARIO { get; set; }
        public Nullable<int> CAJA { get; set; }
        public Nullable<int> Z { get; set; }
        public Nullable<double> STOCK { get; set; }
        public string DESCARGADO { get; set; }
        public Nullable<System.DateTime> FECHACREACION { get; set; }
        public Nullable<int> IMPRESIONES { get; set; }
        public Nullable<bool> ESRECUENTO { get; set; }
        public string OBSERVACIONES { get; set; }
        public Nullable<int> IDMOTIVO { get; set; }
        public string DESCMOTIVO { get; set; }
        */
        public double DESCUENTO
        {
            get
            {
                if (this.CODALMDEST == "T1") return 100.00;
                else return 50.00;
            }
        }

        public string NOMBREALMACENDESTINO
        {
            get;
            set;
        }

        public string NOMBREALMACENORIGEN
        {
            get;
            set;
        }

        public string NOMBRECORTO { get; set; }
        public String FECHACORTA
        {
            get
            {
                return this.FECHA.GetValueOrDefault().ToShortDateString();
            }
        }
        public String HORA
        {
            get
            {
                return this.FECHA.GetValueOrDefault().ToShortTimeString();
            }
        }

        public TraspasoTRASPALMACEN():base()
        {

        }
    }
}
