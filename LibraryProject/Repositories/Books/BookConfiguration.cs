using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryProject.Repositories.Books;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).IsRequired().HasMaxLength(100);
        builder.Property(b => b.Author).IsRequired().HasMaxLength(100);
        builder.Property(b=> b.PublicationYear).IsRequired();
        builder.Property(b => b.Isbn).IsRequired().HasMaxLength(13);
        builder.Property(b => b.Genre).IsRequired().HasMaxLength(50);
        builder.Property(b => b.Publisher).HasMaxLength(100);
        builder.Property(b => b.PageCount).IsRequired();
        builder.Property(b => b.Language).IsRequired().HasMaxLength(50);
        builder.Property(b => b.Summary).IsRequired().HasMaxLength(500);
        builder.Property(b => b.AvailableCopies).IsRequired();
    }
}