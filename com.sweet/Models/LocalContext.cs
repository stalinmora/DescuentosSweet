namespace com.sweet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LocalContext : DbContext
    {
        public LocalContext()
            : base("name=LocalContext")
        {
        }

        public virtual DbSet<ALMACEN> ALMACEN { get; set; }
        public virtual DbSet<ARTICULOS> ARTICULOS { get; set; }
        public virtual DbSet<KITS> KITS { get; set; }
        public virtual DbSet<PRECIOSVENTA> PRECIOSVENTA { get; set; }
        public virtual DbSet<TRASPALMACEN> TRASPALMACEN { get; set; }
        public virtual DbSet<VENDEDORES> VENDEDORES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALMACEN>()
                .Property(e => e.N)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.SUSPENDIDO)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.ESKIT)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PORDOSIS)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.SECOMPRA)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.SEVENDE)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.NOCOMBINAR)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.MENU)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PORPESO)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PRECIOLIBRE)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.USASTOCKS)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.NODISPONIBLE)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.DESCATALOGADO)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.VERSION)
                .IsFixedLength();

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.ESOFERTA)
                .IsFixedLength();

            modelBuilder.Entity<KITS>()
                .Property(e => e.IMPRIMIRLINEA)
                .IsFixedLength();

            modelBuilder.Entity<KITS>()
                .Property(e => e.VERSION)
                .IsFixedLength();

            modelBuilder.Entity<PRECIOSVENTA>()
                .Property(e => e.VERSION)
                .IsFixedLength();

            modelBuilder.Entity<TRASPALMACEN>()
                .Property(e => e.DESCARGADO)
                .IsFixedLength();

            modelBuilder.Entity<VENDEDORES>()
                .Property(e => e.ACTIVO)
                .IsFixedLength();

            modelBuilder.Entity<VENDEDORES>()
                .Property(e => e.DESCATALOGADO)
                .IsFixedLength();

            modelBuilder.Entity<VENDEDORES>()
                .Property(e => e.VERSION)
                .IsFixedLength();
        }
    }
}
