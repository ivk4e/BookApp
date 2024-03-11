using BookApp.Forms.Services;

namespace BookApp.Forms.Users
{
	public partial class UserViewProfile : Form
	{
		public UserViewProfile()
		{
			InitializeComponent();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewBooks>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewOrders>(this);
		}
	}
}
