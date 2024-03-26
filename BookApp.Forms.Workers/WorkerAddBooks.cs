using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.Services.DataGridViewUtilities;
using BookApp.Forms.Services.DbEntityUtilities;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookApp.Forms.Workers
{
    public partial class WorkerAddBooks : Form
	{
		private BookAppContext dbContext;
		private BooksUtility booksUtility;

		public WorkerAddBooks()
		{
			InitializeComponent();
			button2.Visible = false;

			dbContext = new BookAppContext();

			booksUtility = new BooksUtility(dbContext);

			booksUtility.LoadAuthorsToComboBox(authorsComboBox);
			booksUtility.LoadGenresToComboBox(genreComboBox);

			DataGridViewUtility.GenerateColumnsForBooksDataGridView(dataGridView1);
			booksUtility.LoadBooksToDataGridView(dataGridView1);

			LoadUserInfo();
		}

		
		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewBooks>(this);
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

		private void authorImageBox_Click(object sender, EventArgs e)
		{
			string authorName = Interaction.InputBox("Моля, въведете име на автора:", "Въвеждане на име на автор");

			if (!string.IsNullOrWhiteSpace(authorName))
			{
				if (IsValidName(authorName))
				{
					booksUtility.AddNewAuthor(authorName, authorsComboBox);
				}
				else
				{
					MessageBox.Show("Не е въведено валидно име");
				}
			}
		}

		private void genreImageBox_Click(object sender, EventArgs e)
		{
			string genre = Interaction.InputBox("Моля, въведете жанр:", "Въвеждане на жанр");

			if (!string.IsNullOrWhiteSpace(genre))
			{
				if (IsValidName(genre))
				{
					booksUtility.AddNewGenre(genre, genreComboBox);
				}
				else
				{
					MessageBox.Show("Не е въведен валиден жанр.");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button2.Visible = true;
			string authorName = textBox1.Text.Trim();

			if (string.IsNullOrEmpty(authorName))
			{
				MessageBox.Show("Попълни име на автора!");
				booksUtility.LoadBooksToDataGridView(dataGridView1);
			}
			else
			{
				DataGridViewUtility.FilterAuthorsInDataGrid(authorName, dataGridView1);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			booksUtility.LoadBooksToDataGridView(dataGridView1);
		}

		private void addBookButton_Click(object sender, EventArgs e)
		{
			string title = titleBook.Text;
			int authorId = 0, genreId = 0, quantity = 0;
			decimal price = 0;
			ValidateFields(title, ref authorId, ref genreId, ref quantity, ref price);

			string description = descriptionBox.Text;

			if (!description.IsNullOrEmpty())
			{
				booksUtility.AddBook(title, authorId, genreId, price, quantity, description);
				booksUtility.LoadBooksToDataGridView(dataGridView1);
				ClearBoxes();
			}
			else
			{
				booksUtility.AddBook(title, authorId, genreId, price, quantity);
				booksUtility.LoadBooksToDataGridView(dataGridView1);
				ClearBoxes();
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Сигурен ли си, че искаш да изтриеш книгата?");

			if (result == DialogResult.OK)
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

					int bookId = Convert.ToInt32(selectedRow.Cells["BookId"].Value);

					if (!booksUtility.DeleteBook(bookId))
					{
						MessageBox.Show("Книгата не беше изтрита!");
					}
					else
					{
						MessageBox.Show("Книгата беше изтрита!");
					}
				}
			}

			booksUtility.LoadBooksToDataGridView(dataGridView1);
		}

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				dataGridView1.ClearSelection();
				dataGridView1.Rows[e.RowIndex].Selected = true;
				dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
				contextMenuStrip1.Show(dataGridView1, e.Location);
			}
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				int rowIndex = dataGridView1.CurrentRow.Index;

				int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["BookId"].Value);
				string title = dataGridView1.Rows[rowIndex].Cells["Title"].Value.ToString();
				string author = dataGridView1.Rows[rowIndex].Cells["Author"].Value.ToString();
				string priceString = dataGridView1.Rows[rowIndex].Cells["Price"].Value.ToString();

				priceString = priceString.Replace("лв.", "").Trim();
				if (decimal.TryParse(priceString, out decimal price))
				{
				}
				else
				{
					MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				int quantity = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["BookQuantity"].Value);

				if (booksUtility.UpdateBook(id, title, author, price, quantity))
				{
					MessageBox.Show("Успешна редакция!");
				}
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewUserOrders>(this);
		}

		private void ClearBoxes()
		{
			titleBook.Text = "";
			priceBox.Text = "";
			quantityBox.Text = "";
			descriptionBox.Text = "";
		}

		private static bool IsValidName(string name)
		{
			Regex regex = new Regex(@"[A-Za-zА-Яа-я]+");

			return regex.IsMatch(name);
		}

		private void LoadUserInfo()
		{
			User currentUser = SessionManager.GetCurrentUser();

			titleForm.Text = currentUser.Username;
		}

		private void ValidateFields(string title, ref int authorId, ref int genreId, ref int quantity, ref decimal price)
		{
			if (!IsValidName(title))
			{
				MessageBox.Show("Попълни правилно заглавието!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (!int.TryParse(authorsComboBox.SelectedValue.ToString(), out authorId))
			{
				MessageBox.Show("Избери автор на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (!int.TryParse(genreComboBox.SelectedValue.ToString(), out genreId))
			{
				MessageBox.Show("Избери жанр на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (!decimal.TryParse(priceBox.Text, out price))
			{
				MessageBox.Show("Въведи правилна сума!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (!int.TryParse(quantityBox.Text, out quantity))
			{
				MessageBox.Show("Попълни правилно количеството!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
		}

	}
}
