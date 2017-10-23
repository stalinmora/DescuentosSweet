namespace com.sweet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ARTICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULOS()
        {
            KITS = new HashSet<KITS>();
            PRECIOSVENTA = new HashSet<PRECIOSVENTA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODARTICULO { get; set; }

        [StringLength(15)]
        public string REFERENCIA { get; set; }

        [StringLength(8)]
        public string REFTECLADO { get; set; }

        [StringLength(45)]
        public string DESCRIPCION { get; set; }

        [StringLength(30)]
        public string DESCRIPADICIONAL { get; set; }

        [Column(TypeName = "image")]
        public byte[] IMAGEN { get; set; }

        public int? DPTO { get; set; }

        public int? SECCION { get; set; }

        public double? UNIDADES { get; set; }

        public short? CODTASA1 { get; set; }

        public short? CODTASA2 { get; set; }

        [StringLength(1)]
        public string SUSPENDIDO { get; set; }

        public DateTime? FECHAMODIFICADO { get; set; }

        [StringLength(1)]
        public string ESKIT { get; set; }

        [StringLength(1)]
        public string PORDOSIS { get; set; }

        [StringLength(1)]
        public string SECOMPRA { get; set; }

        [StringLength(1)]
        public string SEVENDE { get; set; }

        public int? ORDEN { get; set; }

        public double? STOCKMINIMO { get; set; }

        [StringLength(10)]
        public string UNIDADMEDIDA { get; set; }

        [StringLength(1)]
        public string NOCOMBINAR { get; set; }

        [StringLength(1)]
        public string MENU { get; set; }

        [StringLength(1)]
        public string PORPESO { get; set; }

        [StringLength(1)]
        public string PRECIOLIBRE { get; set; }

        public double? PRECIOMAX { get; set; }

        public double? PRECIOMIN { get; set; }

        public double? UDSELABORACION { get; set; }

        public double? COSTEMEDIO { get; set; }

        public double? COSTESTOCK { get; set; }

        public double? ULTIMOCOSTE { get; set; }

        [StringLength(1)]
        public string USASTOCKS { get; set; }

        public DateTime? FECHAULTCOMPRA { get; set; }

        public double? UDSCOMPRADAS { get; set; }

        public int? CODTASA1C { get; set; }

        public int? CODTASA2C { get; set; }

        public int? CODMONEDA { get; set; }

        public double? PRECIOULTCOMPRA { get; set; }

        public double? ULTDESCCOMERCIAL { get; set; }

        public int? COLORFONDO { get; set; }

        public int? COLORTEXTO { get; set; }

        public double? UNID1C { get; set; }

        public double? UNID2C { get; set; }

        public double? UNID3C { get; set; }

        public double? UNID4C { get; set; }

        public double? ULTDTOCOMERCIAL { get; set; }

        public double? PRECIOCOMPRAREAL { get; set; }

        public double? UDSTRASPASO { get; set; }

        public DateTime? FACTPORHORA { get; set; }

        public int? CONSUMADIC { get; set; }

        [StringLength(1)]
        public string TIPOARTICULO { get; set; }

        public int? NUMCONSUMICIONES { get; set; }

        [StringLength(1)]
        public string NODISPONIBLE { get; set; }

        public double? RENDIMIENTO { get; set; }

        [StringLength(1)]
        public string DESCATALOGADO { get; set; }

        [StringLength(1)]
        public string SELECCIONABLEALLTURNOS { get; set; }

        public int? MARCA { get; set; }

        public short? LINEA { get; set; }

        public double? TARA { get; set; }

        public int? IDTALONARIO { get; set; }

        [StringLength(10)]
        public string MEDIDA2 { get; set; }

        public bool? NODTOAPLICABLE { get; set; }

        [StringLength(100)]
        public string AVISOVENTA { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] VERSION { get; set; }

        [StringLength(1)]
        public string ESOFERTA { get; set; }

        [StringLength(20)]
        public string CODCUPON { get; set; }

        public int? KCAL { get; set; }

        public bool? FACTPORFRANJA { get; set; }

        public bool? FORZARUDSENTERASVENTA { get; set; }

        [StringLength(50)]
        public string ALERGENOS { get; set; }

        public bool? VALIDOPRIMERUSO { get; set; }

        public bool? COMPLETARPLATOSMENU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KITS> KITS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRECIOSVENTA> PRECIOSVENTA { get; set; }
    }
}
