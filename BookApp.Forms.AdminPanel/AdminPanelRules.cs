using BookApp.Forms.Services;

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
			FormUtility.ShowNewForm<AdminPanelClientOrders>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelAddBook>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
