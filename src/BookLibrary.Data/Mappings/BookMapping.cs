using BookLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Data.Mappings
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("book_id").UseIdentityColumn();

            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(100).IsRequired();

            builder.Property(x => x.FirstName).HasColumnName("first_name").HasMaxLength(50).IsRequired();

            builder.Property(x => x.LastName).HasColumnName("last_name").HasMaxLength(50).IsRequired();

            builder.Property(x => x.TotalCopies).HasColumnName("total_copies").IsRequired();

            builder.Property(x => x.CopiesInUse).HasColumnName("copies_in_use").IsRequired();

            builder.Property(x => x.Type).HasColumnName("type").HasMaxLength(50);

            builder.Property(x => x.ISBN).HasColumnName("isbn").HasMaxLength(80);

            builder.Property(x => x.Category).HasColumnName("category").HasMaxLength(50);
        }
    }
}
