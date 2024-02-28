using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Data.EntityConfigurations
{
	public class BookOrderConfiguration : IEntityTypeConfiguration<BookOrder>
	{
		public void Configure(EntityTypeBuilder<BookOrder> builder)
		{
			builder.HasKey(x => new { x.BookId, x.OrderId });
		}
	}
}
