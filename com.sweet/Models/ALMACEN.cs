namespace com.sweet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALMACEN")]
    public partial class ALMACEN
    {
        [Key]
        [StringLength(3)]
        public string CODALMACEN { get; set; }

        [StringLength(30)]
        public string NOMBREALMACEN { get; set; }

        [StringLength(30)]
        public string POBLACION { get; set; }

        [StringLength(30)]
        public string PROVINCIA { get; set; }

        [Column(TypeName = "ntext")]
        public string NOTAS { get; set; }

        [Required]
        [StringLength(1)]
        public string N { get; set; }

        [StringLength(6)]
        public string CENTROCOSTE { get; set; }

        public double? STOCKMINIMO { get; set; }

        public double? STOCKMAXIMO { get; set; }

        public double? FACTOR { get; set; }

        [StringLength(30)]
        public string DIRECCION { get; set; }

        [StringLength(15)]
        public string TELEFONO { get; set; }

        [StringLength(15)]
        public string FAX { get; set; }

        [StringLength(4)]
        public string SERIETRASPASOS { get; set; }

        public int? CODEMPRESACONTABLE { get; set; }

        public int? VALORACIONTRASPASOS { get; set; }

        public int? PVPETIQUETAS { get; set; }

        public int? VALORACIONINVENTARIO { get; set; }
    }
}
