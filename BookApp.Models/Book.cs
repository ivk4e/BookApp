using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class Book
	{
		[Key]
		public int BookId { get; set; }

		[MaxLength(80)]
		public string Title { get; set; } = "";

		[Required]
		public int AuthorId { get; set; }
		public Author Author { get; set; }

		public int? GenreId { get; set; }
		public Genre Genre { get; set; }

		public decimal Price { get; set; }

		public int BookQuantity { get; set; } = 0;

		[MaxLength(100)]
		public string? Description { get; set; }

		public string Picture { get; set; } = "Images/default_book.jpg";

		public virtual ICollection<BookOrder> BookOrders { get; set; } = new HashSet<BookOrder>();
	}
}
