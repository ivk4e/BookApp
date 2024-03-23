using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Forms.DTO
{
	public class BooksDTO
	{
        public int BookId { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public decimal Price { get; set; }

		public int BookQuantity { get; set; }

        public string Description { get; set; }
    }
}
