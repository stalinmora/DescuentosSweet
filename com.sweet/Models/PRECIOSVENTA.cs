namespace com.sweet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRECIOSVENTA")]
    public partial class PRECIOSVENTA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODARTICULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODFORMATO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTARIFAV { get; set; }

        public double? VALOR { get; set; }

        public DateTime? DESDE2 { get; set; }

        public DateTime? HASTA2 { get; set; }

        public double? VALOR2 { get; set; }

        public bool? DESCATALOGADO { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VERSION { get; set; }

        public virtual ARTICULOS ARTICULOS { get; set; }
    }
}
