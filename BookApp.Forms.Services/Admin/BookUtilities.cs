﻿using BookApp.Data;
using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.Admin
{
	public class BookUtilities
	{
		private readonly BookAppContext dbContext;

		public BookUtilities()
        {
			dbContext = new BookAppContext();
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
				MessageBox.Show($"{title} с автор {dbContext.Authors.Where(a => a.AuthorId == authorId).Select( a => a.Name).FirstOrDefault()}, вече съществува в каталога!");
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
	}
}
