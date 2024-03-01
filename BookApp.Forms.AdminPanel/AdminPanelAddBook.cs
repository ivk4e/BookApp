using BookApp.Forms.Login;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelAddBook : Form
	{
		public AdminPanelAddBook()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void panel5_Paint(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//new LoginForm().ShowDialog();
			//this.Close();

			FormUtility.ShowNewForm<LoginForm>(this);
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//new AdminPanelRules().ShowDialog();
			//this.Close();

			FormUtility.ShowNewForm<AdminPanelRules>(this);
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//new AdminPanelClientOrders().ShowDialog();

			FormUtility.ShowNewForm<AdminPanelClientOrders>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<LoginForm>(this);
		}

		//protected override void OnClosing(CancelEventArgs e)
		//{
		//	base.OnClosing(e);

		//	if (shouldClose)
		//	{
		//		this.Hide();
		//		new LoginForm().ShowDialog();
		//	}
		//}
	}
}
