using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelClientOrders : Form
	{
		private BookAppContext dbContext;

		public AdminPanelClientOrders()
		{
			InitializeComponent();
			dbContext = new BookAppContext();

			LoadColumns();
			LoadOrders();
		}

		private void LoadColumns()
		{
			var idColumn = CreateTextBoxColumn("OrderId", "Id поръчка");
			var customerColumn = CreateTextBoxColumn("CustomerName", "Клиент");
			var bookColumn = CreateTextBoxColumn("BookOrder", "Поръчка");
			var totalPrice = CreateTextBoxColumn("TotalPrice", "Сума");

			dataGridView1.Columns.Add(idColumn);
			dataGridView1.Columns.Add(customerColumn);
			dataGridView1.Columns.Add(bookColumn);
			dataGridView1.Columns.Add("DateOrder", "Дата на поръчка");
			dataGridView1.Columns.Add("Status", "Статус");
			dataGridView1.Columns.Add(totalPrice);
		}

		private void LoadOrders()
		{
			dataGridView1.Rows.Clear();

			var orders = dbContext.Orders
				.Select(o => new OrdersDTO
				{
					OrderId = o.OrderId,
					CustomerName = o.User.FirstName + " " + o.User.LastName,
					BookOrder = string.Join(", ", o.BookOrders.Select(b => b.Book.Title)),
					DateOrder = o.DateOrder,
					Status = o.StatusOrder.StatusName,
					TotalPrice = o.BookOrders.Sum(b => b.Book.Price)
				})
				.OrderBy(o => o.DateOrder)
				.ThenByDescending(o => o.Status)
				.ThenBy(o => o.CustomerName)
				.ToList();


			foreach (var order in orders)
			{
				string formattedPrice = order.TotalPrice.ToString("0.00") + " лв.";
				dataGridView1.Rows.Add(order.OrderId, order.CustomerName, order.BookOrder, order.DateOrder, order.Status, formattedPrice);
			}
		}

		private DataGridViewTextBoxColumn CreateTextBoxColumn(string name, string headerText)
		{
			return new DataGridViewTextBoxColumn
			{
				Name = name,
				HeaderText = headerText,
				ReadOnly = true
			};
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usersPictureButton_Click_1(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelRules>(this);
		}

		private void addBooksImageButton_Click_1(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelAddBook>(this);
		}

		private void exit_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
