using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[MaxLength(30)]
		public string FirstName { get; set; } = "";

		[MaxLength(30)]
		public string LastName { get; set; } = "";

		[EmailAddress]
		public string Email { get; set; } = "";

		[MaxLength(50)]
		public string Username { get; set; }

		[MaxLength(20)]
		public string Password { get; set; }

		public DateTime Birthday { get; set; }

		public int UserTypeId { get; set; } = 3;
		public UserType UserType { get; set; }

		public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

		//TODO: This should be in service logic, not here

		//public void SetPassword(string password)
		//{
		//	byte[] hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
		//	Password = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
		//}

		//// Method to verify password
		//public bool VerifyPassword(string password)
		//{
		//	byte[] hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
		//	string hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
		//	return Password == hashedPassword;
		//}
	}
}
