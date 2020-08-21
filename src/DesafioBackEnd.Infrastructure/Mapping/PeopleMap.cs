using DesafioBackEnd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioBackEnd.Mapping
{
    public class PeopleMap : IEntityTypeConfiguration<PeopleEntity>
    {
        public void Configure(EntityTypeBuilder<PeopleEntity> builder)
        {
            builder.ToTable("People");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Email)
                   .IsUnique();                   
            builder.Property(x => x.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(x => x.LastName)
                  .IsRequired()
                  .HasMaxLength(100);
            builder.Property(x => x.Gender)
                  .IsRequired()
                  .HasMaxLength(2);
            builder.Property(x => x.Phone)
                  .IsRequired()
                  .HasMaxLength(15);
            builder.Property(x => x.Email)
                   .HasMaxLength(100);
            
        }
    }
}