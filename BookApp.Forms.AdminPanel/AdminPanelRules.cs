using AutoMapper;
using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelRules : Form
	{
		private readonly BookAppContext dbContext;

		public AdminPanelRules()
		{
			InitializeComponent();
			dbContext = new BookAppContext();

			PopulateUsersListBox();
			PopulateWorkersListBox();

			LoadOrders();
		}

		private void LoadOrders()
		{
			var orders = dbContext.Orders.ToList();
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelClientOrders>(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelAddBook>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string email = textBox1.Text;

			if (!email.IsNullOrEmpty())
			{
				SearchUsersByEmail(email);
			}
			else
			{
				MessageBox.Show("Моля, въведете email адрес");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			PopulateUsersListBox();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string email = textBox2.Text;

			if (!email.IsNullOrEmpty())
			{
				SearchWorkersByEmail(email);
			}
			else
			{
				MessageBox.Show("Моля, въведете email адрес");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			PopulateWorkersListBox();
		}

		private void moveToSellersButton_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null)
			{
				string selectedItem = listBox1.SelectedItem.ToString();

				DialogResult result = MessageBox.Show("Сигурен ли си, че искаш да преместиш потребителя към работниците?");

				if (result == DialogResult.OK)
				{
					listBox1.Items.Remove(selectedItem);
					listBox2.Items.Add(selectedItem);

					UpdateUserStatus(selectedItem);
				}
			}
			else
			{
				MessageBox.Show("Избери потребител!");
			}
		}

		private void moveToUsersButton_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedItem != null)
			{
				string selectedItem = listBox2.SelectedItem.ToString();

				DialogResult result = MessageBox.Show("Сигурен ли си, че искаш да преместиш работника към потребителите?");

				if (result == DialogResult.OK)
				{
					listBox2.Items.Remove(selectedItem);
					listBox1.Items.Add(selectedItem);

					UpdateUserStatus(selectedItem);
				}
			}
			else
			{
				MessageBox.Show("Избери работник!");
			}
		}

		private void listBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int index = listBox1.IndexFromPoint(e.Location);
				if (index != ListBox.NoMatches)
				{
					listBox1.SelectedIndex = index;
					contextMenuStrip1.Show(listBox1, e.Location);
				}
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string selectedItem = listBox1.SelectedItem.ToString();

			DeleteUser(selectedItem);
			
			PopulateUsersListBox();
		}

		private void listBox2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int index = listBox2.IndexFromPoint(e.Location);
				if (index != ListBox.NoMatches)
				{
					listBox2.SelectedIndex = index;
					contextMenuStrip2.Show(listBox2, e.Location);
				}
			}
		}

		private void изтрийToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string selectedItem = listBox2.SelectedItem.ToString();

			DeleteUser(selectedItem);

			PopulateWorkersListBox();
		}

		private void SearchWorkersByEmail(string email)
		{
			bool emailFound = false;

			foreach (var item in listBox2.Items)
			{
				if (item.ToString().Contains(email))
				{
					emailFound = true;
					listBox2.Items.Clear();
					listBox2.Items.Add(item);
					break;
				}
			}

			if (!emailFound)
			{
				MessageBox.Show($"Не е намерен такъв email!");
			}
		}

		private void SearchUsersByEmail(string email)
		{
			bool emailFound = false;

			foreach (var item in listBox1.Items)
			{
				if (item.ToString().Contains(email))
				{
					emailFound = true;
					listBox1.Items.Clear();
					listBox1.Items.Add(item);
					break;
				}
			}

			if (!emailFound)
			{
				MessageBox.Show($"Не е намерен такъв email!");
			}
		}

		private void PopulateWorkersListBox()
		{
			listBox2.Items.Clear();

			try
			{
				var users = dbContext.Users
					.Where(u => u.UserTypeId == 2)
					.Select(user => new UserDTO
					{
						FullName = user.FirstName + " " + user.LastName,
						Email = user.Email
					})
					.OrderBy(u => u.FullName);

				foreach (var user in users)
				{
					listBox2.Items.Add($"{user.FullName} - {user.Email}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PopulateUsersListBox()
		{
			listBox1.Items.Clear();

			try
			{
				var users = dbContext.Users
					.Where(u => u.UserTypeId == 3)
					.Select(user => new UserDTO
					{
						FullName = user.FirstName + " " + user.LastName,
						Email = user.Email
					})
					.OrderBy(u => u.FullName);

				foreach (var user in users)
				{
					listBox1.Items.Add($"{user.FullName} - {user.Email}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateUserStatus(string selectedItem)
		{
			string email = selectedItem.Substring(selectedItem.LastIndexOf('-') + 1).Trim();

			var user = dbContext.Users.FirstOrDefault(u => u.Email == email);

			if (user != null)
			{
				user.UserTypeId = user.UserTypeId == 2 ? 3 : 2;
				dbContext.SaveChanges();
			}
		}

		private void DeleteUser(string selectedItem)
		{
			string email = selectedItem.Substring(selectedItem.LastIndexOf('-') + 1).Trim();

			var user = dbContext.Users.FirstOrDefault(u => u.Email == email);

			if (user != null)
			{
				dbContext.Users.Remove(user);
				dbContext.SaveChanges();
				MessageBox.Show("Потребителят е изтрит.");
			}
			else
			{
				MessageBox.Show("Потребителят не е намерен.");
			}
		}
	}
}
