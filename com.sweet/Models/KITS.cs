namespace com.sweet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KITS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODARTICULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string TALLA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string COLOR { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LINEAKIT { get; set; }

        public int CODARTKIT { get; set; }

        [Required]
        [StringLength(10)]
        public string TALLAKIT { get; set; }

        [Required]
        [StringLength(10)]
        public string COLORKIT { get; set; }

        [StringLength(15)]
        public string REFERENCIA { get; set; }

        [StringLength(40)]
        public string DESCRIPCIOKIT { get; set; }

        [StringLength(15)]
        public string REFERENCIAKIT { get; set; }

        public double? UNIDADES { get; set; }

        public double? PRECIOUNIDAD { get; set; }

        public double? TOTALLINEA { get; set; }

        [StringLength(1)]
        public string IMPRIMIRLINEA { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VERSION { get; set; }

        public virtual ARTICULOS ARTICULOS { get; set; }
    }
}
