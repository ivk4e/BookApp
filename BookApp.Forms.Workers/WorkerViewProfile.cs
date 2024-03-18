using BookApp.Forms.Services;

namespace BookApp.Forms.Workers
{
	public partial class WorkerViewProfile : Form
	{
		public WorkerViewProfile()
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

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkersViewOrders>(this);
		}


	}
}
