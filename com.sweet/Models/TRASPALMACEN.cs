namespace com.sweet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRASPALMACEN")]
    public partial class TRASPALMACEN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string SERIE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMERO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINEA { get; set; }

        [StringLength(3)]
        public string CODALMORIG { get; set; }

        [StringLength(3)]
        public string CODALMDEST { get; set; }

        public DateTime? FECHA { get; set; }

        public int? CODARTICULO { get; set; }

        [StringLength(15)]
        public string REFERENCIA { get; set; }

        [StringLength(45)]
        public string DESCRIPCION { get; set; }

        public double? UNIDADES { get; set; }

        public double? PRECIO { get; set; }

        public int? USUARIO { get; set; }

        public int? CAJA { get; set; }

        public int? Z { get; set; }

        public double? STOCK { get; set; }

        [StringLength(1)]
        public string DESCARGADO { get; set; }

        public DateTime? FECHACREACION { get; set; }

        public int? IMPRESIONES { get; set; }

        public bool? ESRECUENTO { get; set; }

        [StringLength(100)]
        public string OBSERVACIONES { get; set; }

        public int? IDMOTIVO { get; set; }

        [StringLength(100)]
        public string DESCMOTIVO { get; set; }
    }
}
