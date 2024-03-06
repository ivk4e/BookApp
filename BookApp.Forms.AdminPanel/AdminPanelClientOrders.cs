using BookApp.Forms.Services;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelClientOrders : Form
	{
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
			FormUtility.ShowNewForm<AdminPanelRules>(this);
		}

		private void addBooksImageButton_Click_1(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelAddBook>(this);
		}

		private void exit_Click_1(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
