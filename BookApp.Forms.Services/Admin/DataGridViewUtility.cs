using BookApp.Data;
using BookApp.Forms.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.Admin
{
	public class DataGridViewUtility
	{
		public static void LoadFilterOrdersToDataGridView(DataGridView dataGridView, List<OrdersDTO> orders)
		{
			dataGridView.Rows.Clear();

			foreach (var order in orders)
			{
				string formattedPrice = order.TotalPrice.ToString("0.00") + " лв.";
				dataGridView.Rows.Add(order.OrderId, order.CustomerName, order.DateOrder, order.BookOrder, formattedPrice, order.Status);
			}
		}

		public static DataGridViewTextBoxColumn CreateTextBoxColumn(string name, string headerText)
		{
			return new DataGridViewTextBoxColumn
			{
				Name = name,
				HeaderText = headerText,
				ReadOnly = true
			};
		}

		public static void GenerateColumnsForOrdersDataGridView(DataGridView dataGridView)
		{
			var idColumn = CreateTextBoxColumn("OrderId", "Id поръчка");
			var customerColumn = CreateTextBoxColumn("CustomerName", "Клиент");
			var bookColumn = CreateTextBoxColumn("BookOrder", "Поръчка");
			var totalPrice = CreateTextBoxColumn("TotalPrice", "Сума");

			dataGridView.Columns.Add(idColumn);
			dataGridView.Columns.Add(customerColumn);
			dataGridView.Columns.Add("DateOrder", "Дата на поръчка");
			dataGridView.Columns.Add(bookColumn);
			dataGridView.Columns.Add(totalPrice);
			dataGridView.Columns.Add("Status", "Статус");
		}

		public static void GenerateColumnsForBooksDataGridView(DataGridView dataGridView)
		{
			var idColumn = new DataGridViewTextBoxColumn
			{
				Name = "BookId",
				HeaderText = "Id книга",
				ReadOnly = true
			};

			dataGridView.Columns.Add(idColumn);
			dataGridView.Columns.Add("Title", "Заглавие");
			dataGridView.Columns.Add("Author", "Автор");
			dataGridView.Columns.Add("Price", "Цена");
			dataGridView.Columns.Add("BookQuantity", "Количество");
		}

		public static void FilterAuthorsInDataGrid(string authorName, DataGridView dataGridView)
		{
			dataGridView.ClearSelection();

			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				if (row.Cells["Author"].Value.ToString().Equals(authorName, StringComparison.OrdinalIgnoreCase))
				{
					row.Visible = true;
				}
				else
				{
					row.Visible = false;
				}
			}
		}
	}
}
