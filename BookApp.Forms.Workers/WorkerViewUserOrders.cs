using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.Services;
using BookApp.Forms.Services.Admin;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BookApp.Forms.Workers
{
	public partial class WorkerViewUserOrders : Form
	{
		private readonly BookAppContext dbContext;
		private readonly OrdersUtility ordersUtility;

		public WorkerViewUserOrders()
		{
			InitializeComponent();
			dbContext = new BookAppContext();
			ordersUtility = new OrdersUtility(dbContext);

			var currentUser = SessionManager.GetCurrentUser();

			if (currentUser == null)
			{
				MessageBox.Show("Потребителят не е логнат.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DataGridViewUtility.GenerateColumnsForOrdersDataGridViewForSpecificUser(dataGridView2);

			if (!ordersUtility.GetOrdersFromDatabaseForSpecificUser(dataGridView2, currentUser.UserId))
			{
				label7.Visible = true;
				dataGridView2.Visible = false; 
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewProfile>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkersViewOrders>(this);
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewBooks>(this);
		}
	}
}
