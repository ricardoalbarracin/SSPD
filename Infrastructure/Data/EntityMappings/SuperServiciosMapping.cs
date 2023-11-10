using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure.Data.EntityMappings
{
    public static class SuperServiciosMapping
    {
        public static void MapAdministracionTables(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ViewAcuRedesRepositoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ViewTratamientosAguasResidualesRepositoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ViewRedesAlcantarilladoRepositoryEntityConfiguration());
           
        }
    }
}
