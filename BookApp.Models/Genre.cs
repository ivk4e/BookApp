using System.ComponentModel.DataAnnotations;

namespace BookApp.Data.Models
{
	public class Genre
	{
		[Key]
		public int GenreId { get; set; }

		public string Name { get; set; } = "";

		public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
	}
}
