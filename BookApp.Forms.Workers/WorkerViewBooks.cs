using BookApp.Data;
using BookApp.Data.Models;
using BookApp.Forms.Services.DataGridViewUtilities;
using BookApp.Forms.Services.DbEntityUtilities;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BookApp.Forms.Workers
{
    public partial class WorkerViewBooks : Form
	{
		private readonly BookAppContext dbContext;
		private BooksUtility booksUtility;

		public WorkerViewBooks()
		{
			InitializeComponent();
			dbContext = new BookAppContext();

			DataGridViewUtility.GenerateColumnsForViewBooksDataGridView(dataGridView1);
			LoadDataToDataGridView();
			
			LoadUserInfo();
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

		private void addBookButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerAddBooks>(this);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			button3.Visible = true;

			string authorInput = textBox2.Text;

			DataGridViewUtility.FilterBooksByAuthorName(dataGridView1, authorInput);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			button3.Visible = false;

			LoadDataToDataGridView();
		}

		private void LoadDataToDataGridView()
		{
			dataGridView1.Rows.Clear();

			booksUtility = new BooksUtility(dbContext);
			booksUtility.LoadViewBooksToDataGridView(dataGridView1);
		}

		private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
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
				string description = dataGridView1.Rows[rowIndex].Cells["Description"]?.Value?.ToString() ?? "";

				if (description != null)
				{
					if (booksUtility.UpdateBook(id, title, author, price, quantity, description))
					{
						MessageBox.Show("Успешна редакция!");
					}
				}
				else
				{
					if (booksUtility.UpdateBook(id, title, author, price, quantity))
					{
						MessageBox.Show("Успешна редакция!");
					}
				}
				
			}
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

		private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void button2_Click(object sender, EventArgs e)
		{
			button3.Visible = true;

			string titleInput = textBox1.Text;

			DataGridViewUtility.FilterBooksByTitle(dataGridView1, titleInput);
		}

		private void buyBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			booksUtility.AddBookToUserOrder(dataGridView1);
			LoadDataToDataGridView();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<WorkerViewUserOrders>(this);
		}

		private void LoadUserInfo()
		{
			User currentUser = SessionManager.GetCurrentUser();
			titleForm.Text = currentUser.Username;
		}
	}
}
