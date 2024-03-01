using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int StatusId { get; set; }
		public StatusOrder StatusOrder { get; set; }

		public decimal Amount { get; set; }

		public DateTime DateOrder { get; set; }

		public virtual ICollection<BookOrder> BookOrders { get; set; } = new HashSet<BookOrder>();
	}
}
