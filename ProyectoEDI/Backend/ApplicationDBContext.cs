using Entities.Entidades_Definicion;
using Entities.Entidades_Representacion.Abstract;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Segment = Entities.Entidades_Definicion.Segment;

namespace ProyectoEDI.Backend
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().Ignore(m => m.MessagePositions);
            modelBuilder.Ignore<Segment>();
            modelBuilder.Entity<Message>().ToTable("Message");
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Version).IsRequired();
                entity.Property(m => m.Release).IsRequired();
                entity.Property(m => m.DirectoryVersion).IsRequired();
                entity.Property(m => m.Name).IsRequired();
                entity.Property(m => m.Description).IsRequired();
            });
        }
    }
}
