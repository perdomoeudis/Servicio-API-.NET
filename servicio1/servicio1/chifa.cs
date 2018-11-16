namespace servicio1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class chifa : DbContext
    {
        public chifa()
            : base("name=chifa")
        {
        }

        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<Combo> Combo { get; set; }
        public virtual DbSet<ComboPlato> ComboPlato { get; set; }
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<Motorista> Motorista { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Plato> Plato { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banner>()
                .Property(e => e.vNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.vNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.vDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.vImagen)
                .IsUnicode(false);

            modelBuilder.Entity<Motorista>()
                .Property(e => e.vNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Motorista>()
                .Property(e => e.vApellido)
                .IsUnicode(false);

            modelBuilder.Entity<Motorista>()
                .Property(e => e.vDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<Motorista>()
                .Property(e => e.vTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.vDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.vPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .Property(e => e.vTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<Plato>()
                .Property(e => e.vNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Plato>()
                .Property(e => e.vDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Plato>()
                .Property(e => e.vImagen)
                .IsUnicode(false);

            modelBuilder.Entity<Plato>()
                .Property(e => e.iPrecio)
                .IsFixedLength();
        }
    }
}
