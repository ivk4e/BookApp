using BookApp.Data;
using BookApp.Forms.Services.DataGridViewUtilities;
using BookApp.Forms.Services.DbEntityUtilities;
using BookApp.Forms.Services.LoginAndRegister;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Forms.Users
{
    public partial class UserViewBooks : Form
	{
		private readonly BookAppContext dbContext;
		private BooksUtility booksUtility;

		public UserViewBooks()
		{
			InitializeComponent();
			dbContext = new BookAppContext();

			var currentUser = SessionManager.GetCurrentUser();
			titleForm.Text = currentUser.Username;

			DataGridViewUtility.GenerateColumnsForUserViewBooksDataGridView(dataGridView1);
			LoadDataToDataGridView();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addBooksImageButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewProfile>(this);
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usersPictureButton_Click(object sender, EventArgs e)
		{
			FormUtility.ShowNewForm<UserViewOrders>(this);
		}
		private void LoadDataToDataGridView()
		{
			dataGridView1.Rows.Clear();

			booksUtility = new BooksUtility(dbContext);
			booksUtility.LoadUserViewBooksToDataGridView(dataGridView1);
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

		private void button2_Click(object sender, EventArgs e)
		{
			button3.Visible = true;

			string titleInput = textBox1.Text;

			DataGridViewUtility.FilterBooksByTitle(dataGridView1, titleInput);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button1.Visible = false;

			LoadDataToDataGridView();
		}

		private void buyBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			booksUtility.AddBookToUserOrder(dataGridView1);
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
	}
}
