using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.Services;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BookApp.Forms.Users
{
	public partial class UserViewProfile : Form
	{
		private readonly BookAppContext dbContext;
		private User currentUser;

		public UserViewProfile()
		{
			InitializeComponent();
			dbContext = new BookAppContext();
			
			LoadUserInfo();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewBooks>(this);
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
			FormUtility.ShowNewForm<UserViewOrders>(this);
		}
		private void LoadUserInfo()
		{
			currentUser = SessionManager.GetCurrentUser();
			if (currentUser != null)
			{
				string username = currentUser.Username;
				titleForm.Text = username;
				titleBook.Text = currentUser.FirstName;
				priceBox.Text = currentUser.LastName;
				quantityBox.Text = currentUser.Email;
				textBox1.Text = currentUser.Username;
			}
			else
			{
				MessageBox.Show("No user logged in.");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string newFirstName = Interaction.InputBox("Въведи новото си име:", "Смяна на име", "");
			string username = titleForm.Text;

			var usersUtility = new UsersUtility(dbContext);
			if (usersUtility.ChangeUserFirstName(newFirstName, username))
			{
				LoadUserInfo();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string newLastName = Interaction.InputBox("Въведи новата си фамилия:", "Смяна на фамилия", "");
			string username = titleForm.Text;

			var usersUtility = new UsersUtility(dbContext);
			if (usersUtility.ChangeUserLastName(newLastName, username))
			{
				LoadUserInfo();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string newEmail = Interaction.InputBox("Въведи новия си email:", "Смяна на email", "");

			var usersUtility = new UsersUtility(dbContext);
			if (usersUtility.ChangeUserEmail(newEmail))
			{
				LoadUserInfo();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string newUsername = Interaction.InputBox("Въведи новия си username:", "Смяна на username", "");

			var usersUtility = new UsersUtility(dbContext);
			if (usersUtility.ChangeUserUsername(newUsername))
			{
				LoadUserInfo();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		
		{
			string oldPassword = Interaction.InputBox("Въведи старата парола:", "Смяна на парола", "");
			var usersUtility = new UsersUtility(dbContext);

			if (oldPassword != null && usersUtility.IsValidUserPassword(currentUser.Username, oldPassword))
			{
				string newPassword = Interaction.InputBox("Въведи новата парола:", "Смяна на парола", "");
				if (usersUtility.ChangePassword(oldPassword, newPassword))
				{
					LoadUserInfo();
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Сигурен ли си, че искаш да изтриеш профилът си?");

			if (result == DialogResult.OK)
			{
				string password = Interaction.InputBox("Въведи парола:");
				string username = titleForm.Text;

				var usersUtility = new UsersUtility(dbContext);
				if (usersUtility.DeleteUser(username, password))
				{
					SessionManager.ClearCurrentUser();
					this.Close();
				}
			}
		}
	}
}
