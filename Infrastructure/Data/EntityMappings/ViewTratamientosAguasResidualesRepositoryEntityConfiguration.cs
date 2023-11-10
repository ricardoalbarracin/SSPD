using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityMappings
{
    public class ViewTratamientosAguasResidualesRepositoryEntityConfiguration : IEntityTypeConfiguration<ViewTratamientosAguasResiduales>
    {
        public void Configure(EntityTypeBuilder<ViewTratamientosAguasResiduales> builder)
        {
           
            builder.ToTable("V_TRATA_AGUA_RESIDUAL");
            builder.HasKey(p => p.Idempresa);
            builder.Property(p => p.Anio).HasColumnName("ANIO");
            builder.Property(p => p.Apsdepartamento).HasColumnName("APSDEPARTAMENTO");
            builder.Property(p => p.Apsmunicipio).HasColumnName("APSMUNICIPIO");
            builder.Property(p => p.Caudalmedioentrada).HasColumnName("CAUDALMEDIOENTRADA");
            builder.Property(p => p.Caudalmediosalida).HasColumnName("CAUDALMEDIOSALIDA");
            builder.Property(p => p.Dboentrada).HasColumnName("DBOENTRADA");
            builder.Property(p => p.Dbosalida).HasColumnName("DBOSALIDA");
            builder.Property(p => p.Idempresa).HasColumnName("IDEMPRESA");
            builder.Property(p => p.Mes).HasColumnName("MES");
            builder.Property(p => p.Nombresistema).HasColumnName("NOMBRESISTEMA");
            builder.Property(p => p.Nomempresa).HasColumnName("NOMEMPRESA");
            builder.Property(p => p.Nuptar).HasColumnName("NUPTAR");
            builder.Property(p => p.Solidototalentrada).HasColumnName("SOLIDOTOTALENTRADA");
            builder.Property(p => p.Solidototalsalida).HasColumnName("SOLIDOTOTALSALIDA");
        }
    }
}
