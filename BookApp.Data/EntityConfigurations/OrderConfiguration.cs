using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Data.EntityConfigurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{
			builder.HasOne(x => x.User)
				.WithMany(x => x.Orders)
				.HasForeignKey(x => x.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(x => x.StatusOrder)
				.WithMany(x => x.Orders)
				.HasForeignKey(x => x.StatusId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
