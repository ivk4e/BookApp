using AutoMapper;
using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services;
using BookApp.Forms.Services.Admin;
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

			LoadUsersListBox();
			LoadWorkersListBox();
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
			button2.Visible = true;

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
			LoadUsersListBox();
			button2.Visible = false;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			button3.Visible = true;
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
			LoadWorkersListBox();
			button3.Visible = false;
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
					LoadWorkersListBox();
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
					LoadUsersListBox();
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
			
			LoadUsersListBox();
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

			LoadWorkersListBox();
		}

		private void SearchWorkersByEmail(string email)
		{
			ListBoxFilterUtility<string>.FilterItems(listBox2, email);
		}

		private void SearchUsersByEmail(string email)
		{
			ListBoxFilterUtility<string>.FilterItems(listBox1, email);
		}

		private void LoadWorkersListBox()
		{
			var listBoxLoadUsers = new ListBoxLoader();

			static string userFormatter(Data.Models.User user) => $"{user.FirstName} {user.LastName} - {user.Email}";
			listBoxLoadUsers.PopulateListBox(listBox2, 2, userFormatter);
		}

		private void LoadUsersListBox()
		{
			var listBoxLoadUsers = new ListBoxLoader();

			static string userFormatter(Data.Models.User user) => $"{user.FirstName} {user.LastName} - {user.Email}";
			listBoxLoadUsers.PopulateListBox(listBox1, 3, userFormatter);
		}

		private void UpdateUserStatus(string selectedItem)
		{
			string email = selectedItem[(selectedItem.LastIndexOf('-') + 1)..].Trim(); // selectedItem.Substring((selectedItem.LastIndexOf('-') + 1)).Trim(); 

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
