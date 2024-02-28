using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class StatusOrder
	{
		[Key]
		public int StatusId { get; set; }

		public string StatusName { get; set; }

		public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
	}
}
