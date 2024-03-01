using BookApp.Forms.Login;
using System.ComponentModel;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelClientOrders : Form
	{
		private bool shouldClose = false;

		public AdminPanelClientOrders()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usersPictureButton_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			new AdminPanelRules().ShowDialog();
			this.Close();
		}

		private void addBooksImageButton_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			new AdminPanelAddBook().ShowDialog();
			this.Close();
		}

		private void exit_Click_1(object sender, EventArgs e)
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
