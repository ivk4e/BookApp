using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class BookOrder
	{
		[Required]
		public int BookId { get; set; }
		public Book Book { get; set; }

		[Required]
		public int OrderId { get; set; }
		public Order Order { get; set; }
	}
}
