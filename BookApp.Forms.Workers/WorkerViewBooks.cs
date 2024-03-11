using BookApp.Forms.Services;

namespace BookApp.Forms.Workers
{
	public partial class WorkerViewBooks : Form
	{
		public WorkerViewBooks()
		{
			InitializeComponent();
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
			this.Close();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkersViewOrders>(this);
		}

		private void addBookButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerAddBooks>(this);
		}
	}
}
