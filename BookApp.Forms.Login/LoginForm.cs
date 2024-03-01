namespace BookApp.Forms.Login
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Dispose();
			new Registration().Show();
		}
	}
}
