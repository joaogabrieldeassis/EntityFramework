using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataContext.Mapings
{
    public class MapingUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            // public string Name { get; set; }
            // public string Email { get; set; }
            // public string PassWordHash { get; set; }
            // public string Bio { get; set; }
            // public string Image { get; set; }
            // public string Slug { get; set; }

            //Name
            builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

            //Email
            builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnName("Email")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(200);

            //PassWordHas
            builder.Property(x => x.PassWordHash)
            .IsRequired()
            .HasColumnName("PassWordHash")
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

            //Bio
            builder.Property(x => x.Bio)
            .IsRequired()
            .HasColumnName("Bio")
            .HasColumnType("text");

            //Image
            builder.Property(x => x.Image)
            .IsRequired()
            .HasColumnName("Image")
            .HasColumnType("VARCHAR")
            .HasMaxLength(2000);

            //Slug
            builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);
        }
    }
}