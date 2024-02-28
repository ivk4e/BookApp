using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Data.EntityConfigurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasIndex(x => x.Username)
				.IsUnique();

			builder.HasOne(x => x.UserType)
				.WithMany(x => x.Users)
				.HasForeignKey(x => x.UserTypeId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
