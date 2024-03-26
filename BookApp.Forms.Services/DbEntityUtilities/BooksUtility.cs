using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.DTO;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.DbEntityUtilities
{
    public class BooksUtility
    {
        private readonly BookAppContext dbContext;

        public BooksUtility(BookAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void LoadBooksToDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            try
            {
                var books = dbContext.Books
                    .Select(b => new BooksDTO
                    {
                        BookId = b.BookId,
                        Title = b.Title,
                        AuthorName = b.Author.Name,
                        Price = b.Price,
                        BookQuantity = b.BookQuantity
                    })
                    .OrderBy(b => b.Title)
                    .ThenBy(b => b.Price)
                    .ToList();

                foreach (var book in books)
                {
                    string formattedPrice = book.Price.ToString("0.00") + " лв.";

                    dataGridView.Rows.Add(book.BookId, book.Title, book.AuthorName, formattedPrice, book.BookQuantity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadViewBooksToDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            try
            {
                var books = dbContext.Books
                    .Select(b => new BooksDTO
                    {
                        BookId = b.BookId,
                        Title = b.Title,
                        AuthorName = b.Author.Name,
                        Price = b.Price,
                        BookQuantity = b.BookQuantity,
                        Description = b.Description
                    })
                    .OrderBy(b => b.Title)
                    .ThenBy(b => b.Price)
                    .ToList();

                foreach (var book in books)
                {
                    string formattedPrice = book.Price.ToString("0.00") + " лв.";

                    dataGridView.Rows.Add(book.BookId, book.Title, book.AuthorName, formattedPrice, book.BookQuantity, book.Description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUserViewBooksToDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            try
            {
                var books = dbContext.Books
                    .Select(b => new BooksDTO
                    {
                        BookId = b.BookId,
                        Title = b.Title,
                        AuthorName = b.Author.Name,
                        Price = b.Price,
                        Description = b.Description
                    })
                    .OrderBy(b => b.Title)
                    .ThenBy(b => b.Price)
                    .ToList();

                foreach (var book in books)
                {
                    string formattedPrice = book.Price.ToString("0.00") + " лв.";

                    dataGridView.Rows.Add(book.BookId, book.Title, book.AuthorName, formattedPrice, book.Description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AddBook(string title, int authorId, int genreId, decimal price, int quantity)
        {
            if (dbContext.Authors.FirstOrDefault(a => a.AuthorId == authorId) == null)
            {
                MessageBox.Show("Не съществува такъв автор");
                return false;
            }

            if (dbContext.Genres.FirstOrDefault(g => g.GenreId == genreId) == null)
            {
                MessageBox.Show("Не съществува такъв жанр");
                return false;
            }

            if (dbContext.Books.FirstOrDefault(b => b.Title == title && b.AuthorId == authorId) != null)
            {
                MessageBox.Show($"{title} с автор {dbContext.Authors.Where(a => a.AuthorId == authorId).Select(a => a.Name).FirstOrDefault()}, вече съществува в каталога!");
                return false;
            }

            try
            {
                var newBook = new Book
                {
                    Title = title,
                    AuthorId = authorId,
                    GenreId = genreId,
                    Price = price,
                    BookQuantity = quantity
                };

                dbContext.Books.Add(newBook);
                dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddBook(string title, int authorId, int genreId, decimal price, int quantity, string description)
        {
            if (dbContext.Authors.FirstOrDefault(a => a.AuthorId == authorId) == null)
            {
                MessageBox.Show("Не съществува такъв автор");
                return false;
            }

            if (dbContext.Genres.FirstOrDefault(g => g.GenreId == genreId) == null)
            {
                MessageBox.Show("Не съществува такъв жанр");
                return false;
            }

            try
            {
                var newBook = new Book
                {
                    Title = title,
                    AuthorId = authorId,
                    GenreId = genreId,
                    Price = price,
                    BookQuantity = quantity,
                    Description = description
                };

                dbContext.Books.Add(newBook);
                dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteBook(int bookId)
        {
            var book = dbContext.Books.FirstOrDefault(a => a.BookId == bookId);

            if (book != null)
            {
                dbContext.Books.Remove(book);
                dbContext.SaveChanges();
                return true;
            }

            MessageBox.Show("Книгата вече е била изтрита!");
            return false;
        }

        public bool UpdateBook(int id, string title, string author, decimal price, int quantity)
        {
            try
            {
                var book = dbContext.Books.FirstOrDefault(b => b.BookId == id);
                var authorName = dbContext.Authors.FirstOrDefault(a => a.Name == author);

                if (authorName == null)
                {
                    MessageBox.Show("Не съществува такъв автор!");
                    return false;
                }

                if (book != null)
                {
                    book.Title = title;
                    book.Author = authorName;
                    book.Price = price;
                    book.BookQuantity = quantity;

                    dbContext.SaveChanges();

                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateBook(int id, string title, string author, decimal price, int quantity, string description)
        {
            try
            {
                var book = dbContext.Books.FirstOrDefault(b => b.BookId == id);
                var authorName = dbContext.Authors.FirstOrDefault(a => a.Name == author);

                if (authorName == null)
                {
                    MessageBox.Show("Не съществува такъв автор!");
                    return false;
                }

                if (book != null)
                {
                    book.Title = title;
                    book.Author = authorName;
                    book.Price = price;
                    book.BookQuantity = quantity;
                    book.Description = description;

                    dbContext.SaveChanges();

                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void AddBookToUserOrder(DataGridView dataGridView)
        {
            var selectedBooks = new List<Book>();
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                int bookId = Convert.ToInt32(row.Cells[0].Value);
                var book = dbContext.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    selectedBooks.Add(book);
                }
            }

            foreach (Book book in selectedBooks)
            {
                if (book.BookQuantity == 0)
                {
                    MessageBox.Show($"Няма налични количества за '{book.Title}'.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (selectedBooks.Count == 0)
            {
                MessageBox.Show("Моля изберете книга.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string quantityInput = Interaction.InputBox("Какво количество искате да поръчате?", "Количество");

                if (!int.TryParse(quantityInput, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Моля, въведете валидно количество.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (Book book in selectedBooks)
                {
                    if (quantity > book.BookQuantity)
                    {
                        MessageBox.Show($"Избраното количество за книгата '{book.Title}' надвишава наличното количество.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Firstly we are creating for Orders
                var newOrder = new Order
                {
                    UserId = SessionManager.GetCurrentUser().UserId,
                    StatusId = 1,
                    DateOrder = DateTime.Now
                };
                dbContext.Orders.Add(newOrder);
                dbContext.SaveChanges();

                foreach (Book book in selectedBooks)
                {
                    //Secondly we are creating for BookOrders
                    var newBookOrder = new BookOrder
                    {
                        OrderId = newOrder.OrderId,
                        BookId = book.BookId,
                        Quantity = quantity
                    };
                    book.BookQuantity -= quantity;

                    dbContext.BookOrders.Add(newBookOrder);
                }

                dbContext.SaveChanges();

                MessageBox.Show("Книгата е добавена успешно в поръчките!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при добавяне на книгата: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Authors and Genres
        public void LoadAuthorsToComboBox(ComboBox authorsComboBox)
        {
            var authors = dbContext.Authors.ToList();

            authorsComboBox.DataSource = authors;
            authorsComboBox.DisplayMember = "Name";
            authorsComboBox.ValueMember = "AuthorId";
        }

        public void LoadGenresToComboBox(ComboBox genreComboBox)
        {
            var genres = dbContext.Genres.ToList();

            genreComboBox.DataSource = genres;
            genreComboBox.DisplayMember = "Name";
            genreComboBox.ValueMember = "GenreId";
        }

        public void AddNewAuthor(string authorName, ComboBox authorsComboBox)
        {
            try
            {
                var existingAuthor = dbContext.Authors.FirstOrDefault(a => a.Name == authorName);
                if (existingAuthor != null)
                {
                    MessageBox.Show($"{authorName} вече съществува");
                    return;
                }

                var newAuthor = new Author { Name = authorName };
                dbContext.Authors.Add(newAuthor);
                dbContext.SaveChanges();

                MessageBox.Show($"{authorName} е добавен успешно.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAuthorsToComboBox(authorsComboBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при добавяне на автор: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddNewGenre(string genreName, ComboBox genreComboBox)
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
            LoadGenresToComboBox(genreComboBox);
        }
    }
}
