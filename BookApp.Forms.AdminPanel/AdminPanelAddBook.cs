using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services;
using BookApp.Forms.Services.Admin;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;

namespace BookApp.Forms.AdminPanel
{
	public partial class AdminPanelAddBook : Form
	{
		private BookAppContext dbContext;

		public AdminPanelAddBook()
		{
			InitializeComponent();
			dbContext = new BookAppContext();

			PopulateAuthors();
			PopulateGenres();

			LoadColumns();
			LoadBooks();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelRules>(this);
		}

		private void ordersImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<AdminPanelClientOrders>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBookButton_Click(object sender, EventArgs e)
		{
			string title = titleBook.Text;
			int authorId = int.Parse(authorsComboBox.SelectedValue.ToString());
			int genreId = int.Parse(genreComboBox.SelectedValue.ToString());
			decimal price = decimal.Parse(priceBox.Text);
			int quantity = int.Parse(quantityBox.Text);
			string description = descriptionBox.Text;

			var newBook = new BookUtilities();

			if (ValidateFields(title, authorId, genreId, price, quantity))
			{
				if (!description.IsNullOrEmpty())
				{
					newBook.AddBook(title, authorId, genreId, price, quantity, description);
					LoadBooks();
				}
				else
				{
					newBook.AddBook(title, authorId, genreId, price, quantity);
					LoadBooks();
				}
			}
		}

		private void authorImageBox_Click(object sender, EventArgs e)
		{
			string authorName = Interaction.InputBox("Моля, въведете име на автора:", "Въвеждане на име на автор");

			if (!string.IsNullOrWhiteSpace(authorName))
			{
				if (IsValidName(authorName))
				{
					AddNewAuthor(authorName);
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
					AddNewGenre(genre);
				}
				else
				{
					MessageBox.Show("Не е въведен валиден жанр.");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string authorName = textBox1.Text.Trim();

			if (string.IsNullOrEmpty(authorName))
			{
				MessageBox.Show("Попълни име на автора!");
				LoadBooks();
			}
			else
			{
				FilterAuthorsInDataGrid(authorName);
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

					var deleteBook = new BookUtilities();

					if (!deleteBook.DeleteBook(bookId))
					{
						MessageBox.Show("Книгата не беше изтрита!");
					}
					else
					{
						MessageBox.Show("Книгата беше изтрита!");
					}
				}
			}

			LoadBooks();
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
				decimal price = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["Price"].Value);

				var updateBook = new BookUtilities();
				
				if (updateBook.UpdateBook(id, title, author, price)) 
				{
					MessageBox.Show("Успешна редакция!");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			LoadBooks();
		}

		private void AddNewAuthor(string authorName)
		{
			var authors = dbContext.Authors.FirstOrDefault(a => a.Name == authorName);

			if (authors != null)
			{
				MessageBox.Show($"{authorName} вече съществува");
				return;
			}

			var author = new Author()
			{
				Name = authorName
			};

			dbContext.Authors.Add(author);
			dbContext.SaveChanges();

			MessageBox.Show($"{authorName} е добавен успешно.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
			PopulateAuthors();
		}

		private void AddNewGenre(string genreName)
		{
			var genres = dbContext.Genres.FirstOrDefault(a => a.Name == genreName);

			if (genres != null)
			{
				MessageBox.Show($"{genreName} вече съществува");
				return;
			}

			var genre = new Genre()
			{
				Name = genreName
			};

			dbContext.Genres.Add(genre);
			dbContext.SaveChanges();

			MessageBox.Show($"{genreName} е добавен успешно.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
			PopulateGenres();
		}

		private void PopulateAuthors()
		{
			var authors = dbContext.Authors.ToList();

			authorsComboBox.DataSource = authors;
			authorsComboBox.DisplayMember = "Name";
			authorsComboBox.ValueMember = "AuthorId";
		}

		private void PopulateGenres()
		{
			var genres = dbContext.Genres.ToList();

			genreComboBox.DataSource = genres;
			genreComboBox.DisplayMember = "Name";
			genreComboBox.ValueMember = "GenreId";
		}

		private static bool IsValidName(string name)
		{
			Regex regex = new Regex(@"[A-Za-z]+");

			return regex.IsMatch(name);
		}

		private void LoadColumns()
		{
			var idColumn = new DataGridViewTextBoxColumn
			{
				Name = "BookId",
				HeaderText = "Id книга",
				ReadOnly = true
			};

			dataGridView1.Columns.Add(idColumn);
			dataGridView1.Columns.Add("Title", "Заглавие");
			dataGridView1.Columns.Add("Author", "Автор");
			dataGridView1.Columns.Add("Price", "Цена");
		}

		private void LoadBooks()
		{
			dataGridView1.Rows.Clear();

			try
			{
				var books = dbContext.Books
					.Select(b => new BooksDTO
					{
						BookId = b.BookId,
						Title = b.Title,
						AuthorName = b.Author.Name,
						Price = b.Price
					})
					.OrderBy(b => b.Title)
					.ThenBy(b => b.Price)
					.ToList();

				foreach (var book in books)
				{
					string formattedPrice = book.Price.ToString("0.00") + " лв.";

					dataGridView1.Rows.Add(book.BookId, book.Title, book.AuthorName, formattedPrice);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateFields(string title, int authorId, int genreId, decimal price, int quantity)
		{
			if (string.IsNullOrEmpty(title))
			{
				MessageBox.Show("Попълни заглавие на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (authorId == 0)
			{
				MessageBox.Show("Избери автор на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (genreId == 0)
			{
				MessageBox.Show("Избери жанр на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (price == 0.00M)
			{
				MessageBox.Show("Попълни цена на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (quantity == 0)
			{
				MessageBox.Show("Попълни количество на книгата!", "Failed Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}

		private void FilterAuthorsInDataGrid(string authorName)
		{
			dataGridView1.ClearSelection();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Cells["Author"].Value.ToString().Equals(authorName, StringComparison.OrdinalIgnoreCase))
				{
					row.Visible = true;
				}
				else
				{
					row.Visible = false;
				}
			}
		}
	}
}
