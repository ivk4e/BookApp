using BookApp.Forms.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.Admin
{
	public class DataGridViewHelper
	{
		public static DataGridViewTextBoxColumn CreateTextBoxColumn(string name, string headerText)
		{
			return new DataGridViewTextBoxColumn
			{
				Name = name,
				HeaderText = headerText,
				ReadOnly = true
			};
		}

		public static void LoadOrders(DataGridView dataGridView, List<OrdersDTO> orders)
		{
			dataGridView.Rows.Clear();

			foreach (var order in orders)
			{
				string formattedPrice = order.TotalPrice.ToString("0.00") + " лв.";
				dataGridView.Rows.Add(order.OrderId, order.CustomerName, order.DateOrder, order.BookOrder, formattedPrice, order.Status);
			}
		}
	}
}
