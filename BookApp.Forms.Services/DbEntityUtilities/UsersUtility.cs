using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.Services.LoginAndRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookApp.Forms.Services.DbEntityUtilities
{
    public class UsersUtility
    {
        private readonly BookAppContext dbContext;

        public UsersUtility(BookAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool ChangeUserFirstName(string newFirstName, string username)
        {
            if (string.IsNullOrEmpty(newFirstName))
            {
                MessageBox.Show("Въведи валидно име.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User currentUser = SessionManager.GetCurrentUser();

            if (currentUser == null || !IsValidName(newFirstName))
            {
                MessageBox.Show("Потребителят не е логнат или въведеното име не е валидно.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

                if (user != null)
                {
                    user.FirstName = newFirstName;
                    dbContext.SaveChanges();

                    currentUser.FirstName = newFirstName;

                    MessageBox.Show("Името е сменено успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Потребителят не е намерен в базата данни.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяната на името: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ChangeUserLastName(string newLastName, string username)
        {
            if (string.IsNullOrEmpty(newLastName))
            {
                MessageBox.Show("Въведи валидна фамилия.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User currentUser = SessionManager.GetCurrentUser();

            if (currentUser == null || !IsValidName(newLastName))
            {
                MessageBox.Show("Потребителят не е логнат или въведеното име не е валидно.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

                if (user != null)
                {
                    user.LastName = newLastName;
                    dbContext.SaveChanges();

                    currentUser.LastName = newLastName;

                    MessageBox.Show("Името е сменено успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Потребителят не е намерен в базата данни.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяната на името: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ChangeUserEmail(string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail) || !IsValidEmail(newEmail))
            {
                MessageBox.Show("Въведи валиден email.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User currentUser = SessionManager.GetCurrentUser();

            if (currentUser == null)
            {
                MessageBox.Show("Потребителят не е логнат.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.UserId == currentUser.UserId);

                if (user != null)
                {
                    if (!CheckExistingEmail(newEmail))
                    {
                        MessageBox.Show("Имейлът вече се използва от друг потребител.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                    user.Email = newEmail;
                    dbContext.SaveChanges();

                    currentUser.Email = newEmail;

                    MessageBox.Show("Email е сменен успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Грешка при смяна на имейла.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяна на имейла: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ChangeUserUsername(string newUsername)
        {
            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Въведи валиден username.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            User currentUser = SessionManager.GetCurrentUser();
            if (currentUser == null)
            {
                MessageBox.Show("Потребителят не е логнат.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                if (!CheckExistingUsername(newUsername))
                {
                    MessageBox.Show($"Username {newUsername} вече се използва от друг потребител.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                var user = dbContext.Users.FirstOrDefault(u => u.UserId == currentUser.UserId);
                if (user != null)
                {
                    user.Username = newUsername;
                    dbContext.SaveChanges();

                    currentUser.Username = newUsername;

                    MessageBox.Show("Username е сменен успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Грешка при смяна на username.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяна на username: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool IsValidUserPassword(string username, string password)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

            if (user != null && HashPassword.VerifyPassword(password, user.Password)) { return true; }

            MessageBox.Show("Моля, въведи правилна стара парола.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (newPassword == oldPassword)
            {
                MessageBox.Show("Новата парола не трябва да бъде като старата.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Моля, въведи новата парола.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (newPassword.Length < 7)
            {
                MessageBox.Show("Password should be more than 7 symbols", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            User currentUser = SessionManager.GetCurrentUser();

            if (currentUser == null)
            {
                MessageBox.Show("Потребителят не е логнат.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.UserId == currentUser.UserId);

                if (user != null)
                {
                    string hashedNewPassword = HashPassword.SetPassword(newPassword);

                    user.Password = hashedNewPassword;
                    dbContext.SaveChanges();

                    MessageBox.Show("Паролата е променена успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Грешка при смяна на паролата.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при смяна на паролата: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Моля, въведи потребителско име и парола.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("Потребителят не е намерен.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!HashPassword.VerifyPassword(password, user.Password))
            {
                MessageBox.Show("Грешна парола.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var orders = dbContext.Orders.Where(o => o.UserId == user.UserId).ToList();

                foreach (var order in orders)
                {
                    dbContext.Orders.Remove(order);
                }

                dbContext.Users.Remove(user);
                dbContext.SaveChanges();

                MessageBox.Show("Потребителят е изтрит успешно.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при изтриване на потребителя: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Validations
        private bool CheckExistingUsername(string newUsername)
        {
            var existingUser = dbContext.Users.FirstOrDefault(u => u.Username == newUsername);

            return existingUser == null;
        }

        private bool CheckExistingEmail(string newEmail)
        {
            var existingUser = dbContext.Users.FirstOrDefault(u => u.Email == newEmail);

            return existingUser == null;
        }

        private static bool IsValidName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Zа-яА-Я]+$");

            return regex.IsMatch(name);
        }

        private static bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            return regex.IsMatch(email);
        }
    }
}
