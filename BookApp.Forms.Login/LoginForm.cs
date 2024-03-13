using BookApp.Forms.AdminPanel;
using BookApp.Forms.Services;
using BookApp.Forms.Services.LoginAndRegister;
using BookApp.Forms.Users;
using BookApp.Forms.Workers;

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
			FormUtility.ShowNewForm<RegistrationView>(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string username = textBox1.Text;
			string password = textBox2.Text;

			var userLogin = new UserLogin();

			if (userLogin.AuthenticateUser(username, password))
			{

				string userType = userLogin.AuthenticateUserType(username);

				if (userType == "admin")
				{
					MessageBox.Show("Successful login!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox1.Text = "";
					textBox2.Text = "";
					FormUtility.ShowDialogAndHideCurrent<AdminPanelRules>(this);
				}
				else if (userType == "worker")
				{
					MessageBox.Show("Successful login!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox1.Text = "";
					textBox2.Text = "";
					FormUtility.ShowDialogAndHideCurrent<WorkersViewOrders>(this);
				}
				else if (userType == "user")
				{
					MessageBox.Show("Successful login!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					textBox1.Text = "";
					textBox2.Text = "";
					FormUtility.ShowDialogAndHideCurrent<UserViewOrders>(this);
				}
				else
				{
					MessageBox.Show("Incorrect username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			else
			{
				MessageBox.Show("Incorrect username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
