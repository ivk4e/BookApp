using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Data.EntityConfigurations
{
	public class BookConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.HasOne(x => x.Author)
				.WithMany(x => x.Books)
				.HasForeignKey(y => y.AuthorId)
				.OnDelete(DeleteBehavior.Restrict); //if we delete an author to delete and the books from him

			builder.HasOne(x => x.Genre)
				.WithMany(x => x.Books)
				.HasForeignKey(y => y.GenreId)
				.OnDelete(DeleteBehavior.SetNull); //if we delete a genre just to set the column value to null
		}
	}
}
