using BookApp.Forms.Login;
using BookApp.Forms.Services;

namespace BookApp.Forms.Users
{
	public partial class UserViewBooks : Form
	{
		public UserViewBooks()
		{
			InitializeComponent();
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
			FormUtility.ShowNewForm<LoginForm>(this);
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewOrders>(this);
		}
	}
}
