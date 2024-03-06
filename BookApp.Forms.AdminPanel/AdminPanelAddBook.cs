using BookApp.Forms.Services;

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
			this.Dispose();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelRules>(this);
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelClientOrders>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void authorImageBox_Click(object sender, EventArgs e)
		{
		}
	}
}
