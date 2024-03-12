using BookApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Forms.DTO
{
	public class OrdersDTO
	{
		public int OrderId { get; set; }

		public string CustomerName { get; set; }

		public string BookOrder { get; set; }
		
		public DateTime DateOrder { get; set; }

		public string Status { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
