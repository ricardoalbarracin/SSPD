using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityMappings
{
    public class ViewRedesAlcantarilladoRepositoryEntityConfiguration : IEntityTypeConfiguration<ViewRedesAlcantarillado>
    {
        public void Configure(EntityTypeBuilder<ViewRedesAlcantarillado> builder)
        {
           
            builder.ToTable("V_REDES_ALCANTARILLADO");
            builder.HasKey(p => p.Idempresa);
            builder.Property(p => p.Anio).HasColumnName("ANIO");

            builder.Property(p => p.Apsdepartamento).HasColumnName("APSDEPARTAMENTO");
            builder.Property(p => p.Apsmunicipio).HasColumnName("APSMUNICIPIO");
            builder.Property(p => p.Areapromedio).HasColumnName("AREAPROMEDIO");
            builder.Property(p => p.Certiftuberia).HasColumnName("CERTIFTUBERIA");
            builder.Property(p => p.Claseducto).HasColumnName("CLASEDUCTO");
            builder.Property(p => p.Componentered).HasColumnName("COMPONENTERED");
            builder.Property(p => p.Diametronominal).HasColumnName("DIAMETRONOMINAL");
            builder.Property(p => p.Fabtuberia).HasColumnName("FABTUBERIA");
            builder.Property(p => p.Fchinstalacion).HasColumnName("FCHINSTALACION");
            builder.Property(p => p.Idempresa).HasColumnName("IDEMPRESA");
            builder.Property(p => p.Longitud).HasColumnName("LONGITUD");
            builder.Property(p => p.Material).HasColumnName("MATERIAL");
            builder.Property(p => p.Mes).HasColumnName("MES");
            builder.Property(p => p.Nit).HasColumnName("NIT");
            builder.Property(p => p.Nomempresa).HasColumnName("NOMEMPRESA");
            builder.Property(p => p.Numcertificado).HasColumnName("NUMCERTIFICADO");
            builder.Property(p => p.Numlote).HasColumnName("NUMLOTE");
            builder.Property(p => p.Orgcertifproducto).HasColumnName("ORGCERTIFPRODUCTO");
            builder.Property(p => p.Secctransversal).HasColumnName("SECCTRANSVERSAL");
            builder.Property(p => p.Tipoalcantarillado).HasColumnName("TIPOALCANTARILLADO");
            builder.Property(p => p.Tipoinstalacion).HasColumnName("TIPOINSTALACION");
        }
    }
}
