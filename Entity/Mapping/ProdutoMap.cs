using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProdutoMap : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .HasMaxLength(250)
            .IsRequired();

        builder.Property(p => p.Descricao)
            .HasMaxLength(5000);

        builder.Property(p => p.Preco)
            .HasColumnType("numeric(10,2)");

        builder.Property(p => p.Exibir)
            .IsRequired();
    }
}
