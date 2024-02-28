using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class UserType
	{
		[Key]
		public int UserTypeId { get; set; }

		[Required]
		public string UserTypeName { get; set; } = "user";

		public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
	}
}
