using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services;
using BookApp.Forms.Services.Admin;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				FilterOrdersByStatus(1);
			}
			else
			{
				LoadOrders();
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				FilterOrdersByStatus(2);
			}
			else
			{
				LoadOrders();
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				FilterOrdersByStatus(3);
			}
			else
			{
				LoadOrders();
			}
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.ColumnIndex >= 0 && e.RowIndex >= 0)
			{
				DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
				if (column.Name == "Status")
				{
					string currentStatus = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
					ContextMenuStrip statusMenuStrip = new ContextMenuStrip();

					if (currentStatus == "Потвърдена")
					{
						statusMenuStrip.Items.Add("Отказана", null, StatusMenuItem_Click);
					}
					else if (currentStatus == "Отказана")
					{
						MessageBox.Show("Тази поръчка вече е отказана и не могат да се предприемат действия!");
					}
					else
					{
						statusMenuStrip.Items.Add("Потвърдена", null, StatusMenuItem_Click);
						statusMenuStrip.Items.Add("Отказана", null, StatusMenuItem_Click);
					}

					dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
					statusMenuStrip.Show(dataGridView1, e.Location);
				}
			}
		}

		private void StatusMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			string status = item.Text;

			int statusId = GetStatusId(status);
			int rowIndex = dataGridView1.CurrentCell.RowIndex;
			int orderId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["OrderId"].Value);

			if (UpdateOrderStatus(orderId, statusId))
			{
				MessageBox.Show("Успешно сменен статус");
				LoadOrders();
				return;
			}
			MessageBox.Show("Неуспешно сменен статус");
		}
		
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			LoadOrders();
			if (radioButton1.Checked)
			{
				radioButton1.Checked = false;
			}
			else if (radioButton2.Checked)
			{
				radioButton2.Checked = false;
			}
			else
			{
				radioButton3.Checked = false;
			}
		}

		private void FilterOrdersByStatus(int statusId)
		{
			var filteredOrders = dbContext.Orders
			   .Where(o => o.StatusId == statusId)
			   .Select(o => new OrdersDTO
			   {
				   OrderId = o.OrderId,
				   CustomerName = o.User.FirstName + " " + o.User.LastName,
				   DateOrder = o.DateOrder,
				   BookOrder = string.Join(", ", o.BookOrders.Select(b =>
					   $"{b.Book.Title}{(b.Quantity > 1 ? $" x{b.Quantity}" : "")}")),
				   TotalPrice = o.BookOrders.Sum(b => b.Quantity * b.Book.Price),
				   Status = o.StatusOrder.StatusName
			   })
			   .OrderBy(o => o.OrderId)
			   .ThenBy(o => o.CustomerName)
			   .ThenByDescending(o => o.Status)
			   .ToList();

			DataGridViewHelper.LoadOrders(dataGridView1, filteredOrders);
		}

		private void LoadColumns()
		{
			var idColumn = DataGridViewHelper.CreateTextBoxColumn("OrderId", "Id поръчка");
			var customerColumn = DataGridViewHelper.CreateTextBoxColumn("CustomerName", "Клиент");
			var bookColumn = DataGridViewHelper.CreateTextBoxColumn("BookOrder", "Поръчка");
			var totalPrice = DataGridViewHelper.CreateTextBoxColumn("TotalPrice", "Сума");

			dataGridView1.Columns.Add(idColumn);
			dataGridView1.Columns.Add(customerColumn);
			dataGridView1.Columns.Add("DateOrder", "Дата на поръчка");
			dataGridView1.Columns.Add(bookColumn);
			dataGridView1.Columns.Add(totalPrice);
			dataGridView1.Columns.Add("Status", "Статус");
		}

		private void LoadOrders()
		{
			var orders = dbContext.Orders
				.Select(o => new OrdersDTO
				{
					OrderId = o.OrderId,
					CustomerName = o.User.FirstName + " " + o.User.LastName,
					DateOrder = o.DateOrder,
					BookOrder = string.Join(", ", o.BookOrders.Select(b =>
						$"{b.Book.Title}{(b.Quantity > 1 ? $" ({b.Quantity} бр.)" : "")}")),
					TotalPrice = o.BookOrders.Sum(b => b.Quantity * b.Book.Price),
					Status = o.StatusOrder.StatusName
				})
				.OrderBy(o => o.OrderId)
				.ThenBy(o => o.CustomerName)
				.ThenByDescending(o => o.Status)
				.ToList();

			DataGridViewHelper.LoadOrders(dataGridView1, orders);
		}

		private bool UpdateOrderStatus(int orderId, int statusId)
		{
			try
			{
				var order = dbContext.Orders.FirstOrDefault(o => o.OrderId == orderId);
				if (order != null)
				{
					order.StatusId = statusId;
					dbContext.SaveChanges();

					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private int GetStatusId(string status)
		{
			switch (status)
			{
				case "Очаква потвърждение":
					return 1;
				case "Потвърдена":
					return 2;
				case "Отказана":
					return 3;
				default:
					return -1;
			}
		}

	
	}
}
