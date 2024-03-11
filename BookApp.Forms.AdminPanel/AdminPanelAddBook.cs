using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

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
			string author = authorsComboBox.SelectedItem.ToString();
			string genre = authorsComboBox.SelectedItem.ToString();
			decimal price = decimal.Parse(priceBox.Text);
			int quantity = int.Parse(quantityBox.Text);
			string description = descriptionBox.Text;



		}

		private void authorImageBox_Click(object sender, EventArgs e)
		{
			string authorName = Microsoft.VisualBasic.Interaction.InputBox("Моля, въведете име на автора:", "Въвеждане на име на автор");

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
			string genre = Microsoft.VisualBasic.Interaction.InputBox("Моля, въведете жанр:", "Въвеждане на жанр");

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

		private void LoadBooks()
		{
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Add("BookId", "Id книга");
			dataGridView1.Columns.Add("Title", "Заглавие");
			dataGridView1.Columns.Add("Author", "Автор");
			dataGridView1.Columns.Add("Price", "Цена");

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
					dataGridView1.Rows.Add(book.BookId, book.Title, book.AuthorName, book.Price.ToString("0.00"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
