using BookApp.Data.Models;
using BookApp.Forms.AdminPanel;
using BookApp.Forms.Services;
using BookApp.Forms.Services.LoginAndRegister;
using BookApp.Forms.Users;
using BookApp.Forms.Workers;
using Microsoft.VisualBasic.ApplicationServices;

namespace BookApp.Forms.Login
{
	public partial class LoginForm : Form
	{

		public LoginForm()
		{
			InitializeComponent();
			textBox2.PasswordChar = '*';
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
				var user = userLogin.GetUserInfo(username);
				string userType = userLogin.AuthenticateUserType(username);

				if (userType == "admin")
				{
					ShowMessage(user);
					FormUtility.ShowDialogAndHideCurrent<AdminPanelRules>(this);
					CleanTextBoxes();
				}
				else if (userType == "worker")
				{
					ShowMessage(user);
					FormUtility.ShowDialogAndHideCurrent<WorkersViewOrders>(this);
					CleanTextBoxes();
				}
				else if (userType == "user")
				{
					ShowMessage(user);
					FormUtility.ShowDialogAndHideCurrent<UserViewOrders>(this);
					CleanTextBoxes();
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

		private void CleanTextBoxes()
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private static void ShowMessage(Data.Models.User user)
		{
			UserLogin.SetCurrentUser(user);
			MessageBox.Show("Successful login!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
