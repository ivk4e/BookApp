using BookApp.Data;
using BookApp.Forms.Services.DataGridViewUtilities;
using BookApp.Forms.Services.DbEntityUtilities;
using BookApp.Forms.Services.LoginAndRegister;

namespace BookApp.Forms.Users
{
    public partial class UserViewOrders : Form
	{
		private readonly BookAppContext dbContext;
		private readonly OrdersUtility ordersUtility;

		public UserViewOrders()
		{
			InitializeComponent();
			dbContext = new BookAppContext();
			ordersUtility = new OrdersUtility(dbContext);

			var currentUser = SessionManager.GetCurrentUser();
			titleForm.Text = currentUser.Username;

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

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewBooks>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewProfile>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
