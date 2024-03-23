using BookApp.Forms.Services;
using BookApp.Forms.Services.LoginAndRegister;
using System.Text.RegularExpressions;

namespace BookApp.Forms.Login
{
	public partial class RegistrationView : Form
	{
		public RegistrationView()
		{
			InitializeComponent();

			textBox5.PasswordChar = '*';
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<LoginForm>(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string firstName = textBox1.Text;
			string lastName = textBox2.Text;
			string email = textBox3.Text;
			string username = textBox4.Text;
			string password = textBox5.Text;
			DateTime birthday = dateTimePicker1.Value;

			var userRegistration = new UserRegistration();

			if (ValidateFields(firstName, lastName, email, username, password, birthday))
			{
				if (userRegistration.Register(firstName, lastName, email, username, password, birthday))
				{
					FormUtility.ShowNewForm<LoginForm>(this);
				}
			}
		}

		private static bool ValidateFields(string firstName, string lastName, string email, string username, string password, DateTime birthday)
		{
			//firstName
			if (string.IsNullOrWhiteSpace(firstName))
			{
				MessageBox.Show("First name cannot be empty.", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (!IsValidName(firstName))
			{
				MessageBox.Show("First name should contain only letters", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//lastName
			if (string.IsNullOrWhiteSpace(lastName))
			{
				MessageBox.Show("Last name cannot be empty.", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (!IsValidName(lastName))
			{
				MessageBox.Show("Last name should contain only letters", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//email
			if (string.IsNullOrWhiteSpace(email))
			{
				MessageBox.Show("Email is required", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (!IsValidEmail(email))
			{
				MessageBox.Show("Email is invalid", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//username
			if (string.IsNullOrWhiteSpace(username))
			{
				MessageBox.Show("Username is required.", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//password
			if (string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Password is required", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else if (password.Length < 7)
			{
				MessageBox.Show("Password should be more than 7 symbols", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			//birthday
			if (!IsMinimumAgeValid(birthday, 13))
			{
				MessageBox.Show("You must be at least 13 years old to register.", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			return true;
		}

		private static bool IsMinimumAgeValid(DateTime birthday, int minimumAge)
		{
			DateTime today = DateTime.Today;
			int age = today.Year - birthday.Year;

			if (age < minimumAge)
			{
				//Checking if the bithday has passed this year
				if (birthday.Date > today.AddYears(-age))
				{
					age--;
				}
			}

			return age >= minimumAge;
		}

		private static bool IsValidEmail(string email)
		{
			var regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

			return regex.IsMatch(email);
		}

		private static bool IsValidName(string name)
		{
			Regex regex = new Regex(@"^[a-zA-Z]+$");

			return regex.IsMatch(name);
		}
	}
}
