using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Mapings
{
    public class MapinCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.Id); //Indentificador 
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn()//Incrementador
            ;
        }
    }
}