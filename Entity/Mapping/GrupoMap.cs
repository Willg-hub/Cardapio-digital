using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class GrupoMap : IEntityTypeConfiguration<Grupo>
{
    public void Configure(EntityTypeBuilder<Grupo> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Nome)
            .HasMaxLength(250);

        builder.HasMany(g => g.ListaProdutos)
            .WithOne(p => p.Grupo)
            .HasForeignKey(p => p.Id_grupo);
    }
}
