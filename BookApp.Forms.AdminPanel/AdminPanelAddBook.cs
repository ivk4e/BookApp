using BookApp.Forms.Login;
using System.ComponentModel;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelAddBook : Form
	{
		private bool shouldClose = false;

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
			this.Hide();
			new LoginForm().ShowDialog();
			this.Close();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new AdminPanelRules().ShowDialog();
			this.Close();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			new AdminPanelClientOrders().ShowDialog();
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
