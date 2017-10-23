namespace com.sweet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDEDORES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODVENDEDOR { get; set; }

        [StringLength(20)]
        public string PASSWORDENTRADA { get; set; }

        [StringLength(255)]
        public string NOMBREVENDEDOR { get; set; }

        [StringLength(10)]
        public string NOMBRECORTO { get; set; }

        public double? COMISION { get; set; }

        [Column(TypeName = "image")]
        public byte[] IMAGEN { get; set; }

        [StringLength(25)]
        public string MODULOZ { get; set; }

        [StringLength(25)]
        public string MODULOX { get; set; }

        [StringLength(1)]
        public string ACTIVO { get; set; }

        public int? TIPOEMPLEADO { get; set; }

        [StringLength(20)]
        public string PASSWORDREGISTRO { get; set; }

        public int? CODIGORF { get; set; }

        [StringLength(1)]
        public string DESCATALOGADO { get; set; }

        [Column(TypeName = "ntext")]
        public string OBSERVACIONES { get; set; }

        public double? COSTEHORA { get; set; }

        public double? COSTEHORAEXTRA { get; set; }

        [StringLength(255)]
        public string DIRECCION { get; set; }

        [StringLength(8)]
        public string CODPOSTAL { get; set; }

        [StringLength(100)]
        public string POBLACION { get; set; }

        [StringLength(18)]
        public string DNI { get; set; }

        [StringLength(15)]
        public string TELEFONO { get; set; }

        [StringLength(15)]
        public string MOBIL { get; set; }

        public DateTime? FECHAENTRADA { get; set; }

        public int? IDHOTEL { get; set; }

        [StringLength(40)]
        public string NEWPASSWORDENTRADA { get; set; }

        [StringLength(40)]
        public string NEWPASSWORDREGISTRO { get; set; }

        public int? NUMARTICULOSBORRADOS { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VERSION { get; set; }

        [StringLength(255)]
        public string EMAIL { get; set; }

        public double? COSTEHORAEXTRA2 { get; set; }

        [StringLength(40)]
        public string PASSWORDENTRADARFID { get; set; }

        [StringLength(40)]
        public string PASSWORDREGISTRORFID { get; set; }
    }
}
