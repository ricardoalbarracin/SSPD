using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.EntityMappings
{
    public class ViewAcuRedesRepositoryEntityConfiguration : IEntityTypeConfiguration<ViewAcuRedes>
    {
        public void Configure(EntityTypeBuilder<ViewAcuRedes> builder)
        {
           
            builder.ToTable("V_ACU_REDES");
            builder.HasKey(p => p.Idempresa);
            builder.Property(p => p.Anio).HasColumnName("ANIO");
            builder.Property(p => p.Apsdepartamento).HasColumnName("APSDEPARTAMENTO");
            builder.Property(p => p.Apsmunicipio).HasColumnName("APSMUNICIPIO");
            builder.Property(p => p.Areasecctransv).HasColumnName("AREASECCTRANSV");
            builder.Property(p => p.Certificatuberia).HasColumnName("CERTIFICATUBERIA");
            builder.Property(p => p.Claseducto).HasColumnName("CLASEDUCTO");
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
            builder.Property(p => p.Nush).HasColumnName("NUSH");
            builder.Property(p => p.Organocertifproducto).HasColumnName("ORGANOCERTIFPRODUCTO");
            builder.Property(p => p.Proceso).HasColumnName("PROCESO");
            builder.Property(p => p.Secciontransv).HasColumnName("SECCIONTRANSV");
            builder.Property(p => p.Tipoinstall).HasColumnName("TIPOINSTALL");
        }
    }
}
