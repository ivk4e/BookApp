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
	public static class DataGridViewUtility
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
		
		public static void LoadFilterOrdersToDataGridViewForSpecificUser(DataGridView dataGridView, List<OrdersDTO> orders)
		{
			dataGridView.Rows.Clear();

			foreach (var order in orders)
			{
				string formattedPrice = order.TotalPrice.ToString("0.00") + " лв.";
				dataGridView.Rows.Add(order.OrderId, order.DateOrder, order.BookOrder, formattedPrice, order.Status);
			}
		}
		
		public static void LoadFilterCurrentOrderToDataGridViewForSpecificUser(DataGridView dataGridView, List<OrdersDTO> orders)
		{
			dataGridView.Rows.Clear();

			foreach (var order in orders)
			{
				string formattedPrice = order.TotalPrice.ToString("0.00") + " лв.";
				dataGridView.Rows.Add(order.BookOrder, formattedPrice);
			}
		}

		public static DataGridViewTextBoxColumn CreateTextBoxColumn(string name, string headerText)
			=> new()
				{
					Name = name,
					HeaderText = headerText,
					ReadOnly = true
				};

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

		public static void GenerateColumnsForOrdersDataGridViewForSpecificUser(DataGridView dataGridView)
		{
			var idColumn = CreateTextBoxColumn("OrderId", "Id поръчка");
			var dateOrder = CreateTextBoxColumn("DateOrder", "Дата на поръчка");
			var bookColumn = CreateTextBoxColumn("BookOrder", "Поръчка");
			var totalPrice = CreateTextBoxColumn("TotalPrice", "Сума");

			dataGridView.Columns.Add(idColumn);
			dataGridView.Columns.Add(dateOrder);
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

		public static void GenerateColumnsForViewBooksDataGridView(DataGridView dataGridView)
		{
			var idColumn = CreateTextBoxColumn("BookId", "Id книга");

			dataGridView.Columns.Add(idColumn);
			dataGridView.Columns.Add("Title", "Заглавие");
			dataGridView.Columns.Add("Author", "Автор");
			dataGridView.Columns.Add("Price", "Цена");
			dataGridView.Columns.Add("BookQuantity", "Количество");
			dataGridView.Columns.Add("Description", "Описание");
		}
		
		public static void GenerateColumnsForUserViewBooksDataGridView(DataGridView dataGridView)
		{
			var bookId = new DataGridViewTextBoxColumn
			{
				DataPropertyName = "BookId",
				HeaderText = "BookId",
				Visible = false
			};

			var title = CreateTextBoxColumn("Title", "Заглавие");
			var author = CreateTextBoxColumn("Author", "Автор");
			var price = CreateTextBoxColumn("Price", "Цена");
			var description = CreateTextBoxColumn("Description", "Описание");

			dataGridView.Columns.Add(bookId);
			dataGridView.Columns.Add(title);
			dataGridView.Columns.Add(author);
			dataGridView.Columns.Add(price);
			dataGridView.Columns.Add(description);
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

		public static void FilterBooksByAuthorName(DataGridView dataGridView, string authorInput)
		{
			var matchedRows = new List<DataGridViewRow>();
			bool authorFound = false;

			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				if (row.IsNewRow) continue;

				string rowAuthor = row.Cells["Author"].Value?.ToString();

				if (!string.IsNullOrEmpty(rowAuthor) &&
					(rowAuthor.Equals(authorInput, StringComparison.OrdinalIgnoreCase) ||
					 rowAuthor.StartsWith(authorInput, StringComparison.OrdinalIgnoreCase)))
				{
					matchedRows.Add(row);
					authorFound = true;
				}
			}

			dataGridView.Rows.Clear();
			dataGridView.Rows.AddRange(matchedRows.ToArray());

			if (!authorFound)
			{
				MessageBox.Show("Не намерих такъв автор.");
			}
		}

		public static void FilterBooksByTitle(DataGridView dataGridView, string titleInput)
		{
			var matchedRows = new List<DataGridViewRow>();
			bool titleFound = false;

			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				if (row.IsNewRow) continue;

				string rowTitle = row.Cells["Title"].Value?.ToString();

				if (!string.IsNullOrEmpty(rowTitle) &&
					(rowTitle.Equals(titleInput, StringComparison.OrdinalIgnoreCase) ||
					 rowTitle.StartsWith(titleInput, StringComparison.OrdinalIgnoreCase)))
				{
					matchedRows.Add(row);
					titleFound = true;
				}
			}

			dataGridView.Rows.Clear();
			dataGridView.Rows.AddRange(matchedRows.ToArray());

			if (!titleFound)
			{
				MessageBox.Show("Не намерих такава книга.");
			}
		}
	}
}
