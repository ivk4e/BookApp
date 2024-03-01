using BookApp.Forms.Login;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelRules : Form
	{
		public AdminPanelRules()
		{
			InitializeComponent();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//new AdminPanelClientOrders().ShowDialog();
			//this.Close();

			FormUtility.ShowNewForm<AdminPanelClientOrders>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//new AdminPanelAddBook().ShowDialog();
			//this.Close();

			FormUtility.ShowNewForm<AdminPanelAddBook>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			//shouldClose = true;
			//this.Close();

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
