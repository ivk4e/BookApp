using BookApp.Data;
using BookApp.Data.Models;
using System.Windows.Forms;

namespace BookApp.Forms.Services.LoginAndRegister
{
    public class UserRegistration
    {
        private readonly BookAppContext dbContext;

        public UserRegistration()
        {
            dbContext = new BookAppContext();
        }

        public bool Register(string firstName, string lastName, string email, string username, string password, DateTime birthday)
        {
            if (dbContext.Users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username is already taken", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dbContext.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("There is already registration with this email", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Username = username,
                    Password = HashPassword.SetPassword(password),
                    Birthday = birthday
                };

                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();

                MessageBox.Show("Successfully registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Cannot make registration", "Db trouble", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
