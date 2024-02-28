using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookApp.Data
{
	public class BookAppContext : DbContext
	{
		public BookAppContext()
		{
		}

		public BookAppContext(DbContextOptions dbContextOptions)
			: base(dbContextOptions)
		{
		}

		public DbSet<Book> Books { get; set; }

		public DbSet<Author> Authors { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<StatusOrder> StatusOrders { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<UserType> UserTypes { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(Configuration.ConnectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			modelBuilder.ApplyConfigurationsFromAssembly(assembly);
		}
	}
}
