using Core.Entities;
using Infrastructure.Data.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace GN.Sanidad.Lamia.EntityFrameworkCore.DataAccess
{

    public class LamiaDbContext : DbContext
    {
        private bool _disposed;

        private const string DEFAULT_CONNECTION = "LamiaOracle";

        public virtual DbSet<ViewAcuRedes> View1 { get; set; }
        public virtual DbSet<ViewTratamientosAguasResiduales> View2 { get; set; }
        public virtual DbSet<ViewRedesAlcantarillado> View3 { get; set; }
        
        Guid Guid;
        public LamiaDbContext(DbContextOptions<LamiaDbContext> options) : base(options)
        {
            Guid = Guid.NewGuid();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.MapAdministracionTables();
            
        }

        public override void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {

                    if (Database?.GetDbConnection()?.State == ConnectionState.Open)
                    {
                        Database.CloseConnection();
                    }
                    base.Dispose();
                }
                _disposed = true;
            }
        }
    }
}