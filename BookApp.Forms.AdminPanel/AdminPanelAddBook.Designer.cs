namespace BookApp.Forms.AdminPanel
{
	partial class AdminPanelAddBook
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			dataGridView1 = new DataGridView();
			label15 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBox1 = new TextBox();
			addBookButton = new Button();
			label8 = new Label();
			label14 = new Label();
			label7 = new Label();
			label13 = new Label();
			authorImageBox = new PictureBox();
			label12 = new Label();
			label5 = new Label();
			label11 = new Label();
			titleBook = new TextBox();
			label10 = new Label();
			authorsComboBox = new ComboBox();
			label9 = new Label();
			descriptionBox = new RichTextBox();
			label6 = new Label();
			genreComboBox = new ComboBox();
			genreImageBox = new PictureBox();
			priceBox = new TextBox();
			quantityBox = new TextBox();
			panel5 = new Panel();
			label4 = new Label();
			exit = new PictureBox();
			label3 = new Label();
			addBooksImageButton = new PictureBox();
			label2 = new Label();
			ordersImageButton = new PictureBox();
			label1 = new Label();
			usersPictureButton = new PictureBox();
			panel2 = new Panel();
			titleForm = new Label();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)authorImageBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)genreImageBox).BeginInit();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)exit).BeginInit();
			((System.ComponentModel.ISupportInitialize)addBooksImageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)ordersImageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)usersPictureButton).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(241, 227, 203);
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(label15);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(addBookButton);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label14);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label13);
			panel1.Controls.Add(authorImageBox);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label11);
			panel1.Controls.Add(titleBook);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(authorsComboBox);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(descriptionBox);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(genreComboBox);
			panel1.Controls.Add(genreImageBox);
			panel1.Controls.Add(priceBox);
			panel1.Controls.Add(quantityBox);
			panel1.Location = new Point(1, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(857, 557);
			panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(404, 103);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(442, 236);
			dataGridView1.TabIndex = 49;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label15.Location = new Point(404, 56);
			label15.Name = "label15";
			label15.Size = new Size(44, 15);
			label15.TabIndex = 48;
			label15.Text = "Автор";
			// 
			// button2
			// 
			button2.Location = new Point(597, 73);
			button2.Name = "button2";
			button2.Size = new Size(28, 23);
			button2.TabIndex = 47;
			button2.Text = "x";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(547, 73);
			button1.Name = "button1";
			button1.Size = new Size(49, 23);
			button1.TabIndex = 46;
			button1.Text = "Търси";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(404, 74);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(137, 23);
			textBox1.TabIndex = 45;
			// 
			// addBookButton
			// 
			addBookButton.BackColor = Color.FromArgb(202, 81, 22);
			addBookButton.BackgroundImageLayout = ImageLayout.Center;
			addBookButton.Cursor = Cursors.Hand;
			addBookButton.FlatAppearance.BorderColor = Color.FromArgb(88, 28, 12);
			addBookButton.FlatStyle = FlatStyle.Flat;
			addBookButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			addBookButton.ForeColor = Color.White;
			addBookButton.Location = new Point(165, 493);
			addBookButton.Name = "addBookButton";
			addBookButton.Size = new Size(147, 32);
			addBookButton.TabIndex = 43;
			addBookButton.Text = "Добави книга";
			addBookButton.UseMnemonic = false;
			addBookButton.UseVisualStyleBackColor = false;
			addBookButton.Click += addBookButton_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(0, 0);
			label8.Name = "label8";
			label8.Size = new Size(38, 15);
			label8.TabIndex = 21;
			label8.Text = "label8";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label14.ForeColor = Color.FromArgb(202, 81, 22);
			label14.Location = new Point(165, 339);
			label14.Name = "label14";
			label14.Size = new Size(65, 15);
			label14.TabIndex = 42;
			label14.Text = "Описание";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.FromArgb(241, 227, 203);
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.FromArgb(202, 81, 22);
			label7.Location = new Point(538, 439);
			label7.Name = "label7";
			label7.Size = new Size(86, 15);
			label7.TabIndex = 9;
			label7.Text = "Добави автор";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label13.ForeColor = Color.FromArgb(202, 81, 22);
			label13.Location = new Point(165, 281);
			label13.Name = "label13";
			label13.Size = new Size(76, 15);
			label13.TabIndex = 41;
			label13.Text = "Количество";
			// 
			// authorImageBox
			// 
			authorImageBox.BackgroundImageLayout = ImageLayout.Center;
			authorImageBox.Cursor = Cursors.Hand;
			authorImageBox.Image = Properties.Resources.editor;
			authorImageBox.Location = new Point(547, 369);
			authorImageBox.Name = "authorImageBox";
			authorImageBox.Size = new Size(64, 65);
			authorImageBox.TabIndex = 18;
			authorImageBox.TabStop = false;
			authorImageBox.Click += authorImageBox_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label12.ForeColor = Color.FromArgb(202, 81, 22);
			label12.Location = new Point(165, 220);
			label12.Name = "label12";
			label12.Size = new Size(37, 15);
			label12.TabIndex = 40;
			label12.Text = "Цена";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(0, 0);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 4;
			label5.Text = "label5";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.FromArgb(202, 81, 22);
			label11.Location = new Point(165, 159);
			label11.Name = "label11";
			label11.Size = new Size(39, 15);
			label11.TabIndex = 39;
			label11.Text = "Жанр";
			// 
			// titleBook
			// 
			titleBook.BackColor = Color.FromArgb(242, 235, 225);
			titleBook.BorderStyle = BorderStyle.FixedSingle;
			titleBook.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			titleBook.ForeColor = SystemColors.Desktop;
			titleBook.Location = new Point(165, 60);
			titleBook.Name = "titleBook";
			titleBook.Size = new Size(220, 25);
			titleBook.TabIndex = 31;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.FromArgb(202, 81, 22);
			label10.Location = new Point(165, 101);
			label10.Name = "label10";
			label10.Size = new Size(41, 15);
			label10.TabIndex = 38;
			label10.Text = "Автор";
			// 
			// authorsComboBox
			// 
			authorsComboBox.BackColor = Color.FromArgb(242, 235, 225);
			authorsComboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			authorsComboBox.ForeColor = Color.Black;
			authorsComboBox.FormattingEnabled = true;
			authorsComboBox.Location = new Point(165, 119);
			authorsComboBox.Name = "authorsComboBox";
			authorsComboBox.Size = new Size(220, 25);
			authorsComboBox.TabIndex = 29;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.FromArgb(202, 81, 22);
			label9.Location = new Point(165, 42);
			label9.Name = "label9";
			label9.Size = new Size(60, 15);
			label9.TabIndex = 37;
			label9.Text = "Заглавие";
			// 
			// descriptionBox
			// 
			descriptionBox.BackColor = Color.FromArgb(242, 235, 225);
			descriptionBox.BorderStyle = BorderStyle.FixedSingle;
			descriptionBox.ForeColor = SystemColors.WindowText;
			descriptionBox.Location = new Point(165, 357);
			descriptionBox.Name = "descriptionBox";
			descriptionBox.Size = new Size(220, 126);
			descriptionBox.TabIndex = 30;
			descriptionBox.Text = "";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.FromArgb(241, 227, 203);
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.FromArgb(202, 81, 22);
			label6.Location = new Point(647, 439);
			label6.Name = "label6";
			label6.Size = new Size(84, 15);
			label6.TabIndex = 36;
			label6.Text = "Добави жанр";
			// 
			// genreComboBox
			// 
			genreComboBox.BackColor = Color.FromArgb(242, 235, 225);
			genreComboBox.Font = new Font("Segoe UI", 9.75F);
			genreComboBox.ForeColor = Color.Black;
			genreComboBox.FormattingEnabled = true;
			genreComboBox.Location = new Point(165, 177);
			genreComboBox.Name = "genreComboBox";
			genreComboBox.Size = new Size(220, 25);
			genreComboBox.TabIndex = 32;
			// 
			// genreImageBox
			// 
			genreImageBox.BackgroundImageLayout = ImageLayout.Center;
			genreImageBox.Cursor = Cursors.Hand;
			genreImageBox.Image = Properties.Resources.book;
			genreImageBox.Location = new Point(655, 374);
			genreImageBox.Name = "genreImageBox";
			genreImageBox.Size = new Size(64, 60);
			genreImageBox.TabIndex = 35;
			genreImageBox.TabStop = false;
			genreImageBox.Click += genreImageBox_Click;
			// 
			// priceBox
			// 
			priceBox.BackColor = Color.FromArgb(242, 235, 225);
			priceBox.BorderStyle = BorderStyle.FixedSingle;
			priceBox.Font = new Font("Segoe UI", 9.75F);
			priceBox.ForeColor = SystemColors.Desktop;
			priceBox.Location = new Point(165, 238);
			priceBox.Name = "priceBox";
			priceBox.Size = new Size(220, 25);
			priceBox.TabIndex = 33;
			// 
			// quantityBox
			// 
			quantityBox.BackColor = Color.FromArgb(242, 235, 225);
			quantityBox.BorderStyle = BorderStyle.FixedSingle;
			quantityBox.Font = new Font("Segoe UI", 9.75F);
			quantityBox.ForeColor = SystemColors.Desktop;
			quantityBox.Location = new Point(165, 299);
			quantityBox.Name = "quantityBox";
			quantityBox.Size = new Size(220, 25);
			quantityBox.TabIndex = 34;
			// 
			// panel5
			// 
			panel5.AutoSize = true;
			panel5.BackColor = Color.FromArgb(202, 81, 22);
			panel5.Controls.Add(label4);
			panel5.Controls.Add(exit);
			panel5.Controls.Add(label3);
			panel5.Controls.Add(addBooksImageButton);
			panel5.Controls.Add(label2);
			panel5.Controls.Add(ordersImageButton);
			panel5.Controls.Add(label1);
			panel5.Controls.Add(usersPictureButton);
			panel5.Location = new Point(1, 1);
			panel5.Name = "panel5";
			panel5.Size = new Size(139, 558);
			panel5.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.FromArgb(242, 235, 225);
			label4.Location = new Point(48, 494);
			label4.Name = "label4";
			label4.Size = new Size(43, 15);
			label4.TabIndex = 7;
			label4.Text = "Изход";
			label4.Click += label4_Click;
			// 
			// exit
			// 
			exit.BackgroundImage = Properties.Resources.log_out;
			exit.BackgroundImageLayout = ImageLayout.Center;
			exit.Cursor = Cursors.Hand;
			exit.Location = new Point(37, 424);
			exit.Name = "exit";
			exit.Size = new Size(64, 65);
			exit.TabIndex = 6;
			exit.TabStop = false;
			exit.Click += exit_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.FromArgb(242, 235, 225);
			label3.Location = new Point(44, 370);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 5;
			label3.Text = "Каталог";
			// 
			// addBooksImageButton
			// 
			addBooksImageButton.BackgroundImage = Properties.Resources.bookshelf;
			addBooksImageButton.BackgroundImageLayout = ImageLayout.Center;
			addBooksImageButton.Location = new Point(37, 300);
			addBooksImageButton.Name = "addBooksImageButton";
			addBooksImageButton.Size = new Size(64, 65);
			addBooksImageButton.TabIndex = 4;
			addBooksImageButton.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(242, 235, 225);
			label2.Location = new Point(39, 246);
			label2.Name = "label2";
			label2.Size = new Size(59, 15);
			label2.TabIndex = 3;
			label2.Text = "Поръчки";
			// 
			// ordersImageButton
			// 
			ordersImageButton.BackgroundImageLayout = ImageLayout.Center;
			ordersImageButton.Cursor = Cursors.Hand;
			ordersImageButton.Image = Properties.Resources.checklist;
			ordersImageButton.Location = new Point(37, 171);
			ordersImageButton.Name = "ordersImageButton";
			ordersImageButton.Size = new Size(64, 70);
			ordersImageButton.TabIndex = 2;
			ordersImageButton.TabStop = false;
			ordersImageButton.Click += ordersImageButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(242, 235, 225);
			label1.Location = new Point(28, 117);
			label1.Name = "label1";
			label1.Size = new Size(84, 15);
			label1.TabIndex = 1;
			label1.Text = "Потребители";
			// 
			// usersPictureButton
			// 
			usersPictureButton.BackgroundImage = Properties.Resources.gear;
			usersPictureButton.BackgroundImageLayout = ImageLayout.Center;
			usersPictureButton.Cursor = Cursors.Hand;
			usersPictureButton.Location = new Point(37, 46);
			usersPictureButton.Name = "usersPictureButton";
			usersPictureButton.Size = new Size(64, 64);
			usersPictureButton.TabIndex = 0;
			usersPictureButton.TabStop = false;
			usersPictureButton.Click += usersPictureButton_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(249, 179, 132);
			panel2.Controls.Add(titleForm);
			panel2.Controls.Add(pictureBox1);
			panel2.Location = new Point(1, 1);
			panel2.Name = "panel2";
			panel2.Size = new Size(857, 30);
			panel2.TabIndex = 0;
			// 
			// titleForm
			// 
			titleForm.AutoSize = true;
			titleForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			titleForm.ForeColor = Color.FromArgb(88, 28, 12);
			titleForm.Location = new Point(145, 8);
			titleForm.Name = "titleForm";
			titleForm.Size = new Size(118, 15);
			titleForm.TabIndex = 3;
			titleForm.Text = "Добавяне на книги";
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.x_regular_24;
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.Cursor = Cursors.Hand;
			pictureBox1.Location = new Point(824, 1);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(31, 27);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// AdminPanelAddBook
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(859, 560);
			ControlBox = false;
			Controls.Add(panel5);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AdminPanelAddBook";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Books";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)authorImageBox).EndInit();
			((System.ComponentModel.ISupportInitialize)genreImageBox).EndInit();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)exit).EndInit();
			((System.ComponentModel.ISupportInitialize)addBooksImageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)ordersImageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)usersPictureButton).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Panel panel5;
		private PictureBox pictureBox1;
		private PictureBox usersPictureButton;
		private Label label1;
		private PictureBox ordersImageButton;
		private Label label2;
		private Label label3;
		private PictureBox addBooksImageButton;
		private PictureBox exit;
		private Label label4;
		private Label label5;
		private Label label7;
		private PictureBox authorImageBox;
		private Label label8;
		private Label titleForm;
		private Button addBookButton;
		private Label label14;
		private Label label13;
		private Label label12;
		private Label label11;
		private TextBox titleBook;
		private Label label10;
		private ComboBox authorsComboBox;
		private Label label9;
		private RichTextBox descriptionBox;
		private Label label6;
		private ComboBox genreComboBox;
		private PictureBox genreImageBox;
		private TextBox priceBox;
		private TextBox quantityBox;
		private Label label15;
		private Button button2;
		private Button button1;
		private TextBox textBox1;
		private DataGridView dataGridView1;
	}
}
	
