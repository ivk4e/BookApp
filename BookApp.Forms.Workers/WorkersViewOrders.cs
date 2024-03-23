using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.Services;
using BookApp.Forms.Services.Admin;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Forms.Workers
{
	public partial class WorkersViewOrders : Form
	{
		private readonly BookAppContext dbContext;
		private readonly OrdersUtility ordersUtility;

		public WorkersViewOrders()
		{
			InitializeComponent();
			dbContext = new BookAppContext();
			ordersUtility = new OrdersUtility(dbContext);

			DataGridViewUtility.GenerateColumnsForOrdersDataGridView(dataGridView1);
			ordersUtility.GetOrdersFromDatabase(dataGridView1);

			LoadUserInfo();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewBooks>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
			SessionManager.ClearCurrentUser();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewProfile>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
			SessionManager.ClearCurrentUser();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				var filteredOrders = ordersUtility.FilterOrdersByStatus(1);
				DataGridViewUtility.LoadFilterOrdersToDataGridView(dataGridView1, filteredOrders);
			}
			else
			{
				ordersUtility.GetOrdersFromDatabase(dataGridView1);
			}
		}

		private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				var filteredOrders = ordersUtility.FilterOrdersByStatus(2);
				DataGridViewUtility.LoadFilterOrdersToDataGridView(dataGridView1, filteredOrders);
			}
			else
			{
				ordersUtility.GetOrdersFromDatabase(dataGridView1);
			}
		}

		private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				var filteredOrders = ordersUtility.FilterOrdersByStatus(3);
				DataGridViewUtility.LoadFilterOrdersToDataGridView(dataGridView1, filteredOrders);
			}
			else
			{
				ordersUtility.GetOrdersFromDatabase(dataGridView1);
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

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			ordersUtility.GetOrdersFromDatabase(dataGridView1);
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

		private void StatusMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			string status = item.Text;

			int statusId = GetStatusId(status);
			int rowIndex = dataGridView1.CurrentCell.RowIndex;
			int orderId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["OrderId"].Value);

			if (ordersUtility.UpdateOrderStatus(orderId, statusId))
			{
				MessageBox.Show("Успешно сменен статус");
				ordersUtility.GetOrdersFromDatabase(dataGridView1);
				return;
			}
			MessageBox.Show("Неуспешно сменен статус");
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

		private void LoadUserInfo()
		{
			User currentUser = SessionManager.GetCurrentUser();
			if (currentUser != null)
			{
				string username = currentUser.Username;
				titleForm.Text = username;
			}
			else
			{
				MessageBox.Show("No user logged in.");
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewUserOrders>(this);
		}
	}
}
