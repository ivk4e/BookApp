using BookApp.Forms.Login;
using System.ComponentModel;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelRules : Form
	{
		private bool shouldClose = false;

		public AdminPanelRules()
		{
			InitializeComponent();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new AdminPanelClientOrders().ShowDialog();
			this.Close();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new AdminPanelAddBook().ShowDialog();
			this.Close();
		}

		private void exit_Click(object sender, EventArgs e)
		{
			shouldClose = true;
			this.Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);

			if (shouldClose)
			{
				this.Hide();
				new LoginForm().ShowDialog();
			}
		}
	}
}
