using BookApp.Forms.Login;
using BookApp.Forms.Services;

namespace BookApp.Forms.Workers
{
	public partial class WorkersViewOrders : Form
	{
		public WorkersViewOrders()
		{
			InitializeComponent();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewBooks>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewProfile>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<LoginForm>(this);
		}
	}
}
