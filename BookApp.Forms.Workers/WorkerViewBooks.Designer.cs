namespace BookApp.Forms.Workers
{
	partial class WorkerViewBooks
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
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			label7 = new Label();
			button1 = new Button();
			button2 = new Button();
			textBox1 = new TextBox();
			label11 = new Label();
			button3 = new Button();
			button4 = new Button();
			textBox2 = new TextBox();
			dataGridView1 = new DataGridView();
			addBookButton = new Button();
			label8 = new Label();
			label6 = new Label();
			label5 = new Label();
			panel5 = new Panel();
			label9 = new Label();
			label4 = new Label();
			exit = new PictureBox();
			label3 = new Label();
			addBooksImageButton = new PictureBox();
			label2 = new Label();
			ordersImageButton = new PictureBox();
			label1 = new Label();
			usersPictureButton = new PictureBox();
			panel2 = new Panel();
			pictureBox3 = new PictureBox();
			pictureBox2 = new PictureBox();
			titleForm = new Label();
			closeWindowButton = new PictureBox();
			pictureBox1 = new PictureBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			saveChangesToolStripMenuItem = new ToolStripMenuItem();
			buyBookToolStripMenuItem = new ToolStripMenuItem();
			deleteBookToolStripMenuItem = new ToolStripMenuItem();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)exit).BeginInit();
			((System.ComponentModel.ISupportInitialize)addBooksImageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)ordersImageButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)usersPictureButton).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)closeWindowButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(241, 227, 203);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label11);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(addBookButton);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Location = new Point(1, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(857, 557);
			panel1.TabIndex = 0;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label7.Location = new Point(390, 99);
			label7.Name = "label7";
			label7.Size = new Size(82, 15);
			label7.TabIndex = 38;
			label7.Text = "Име на книга";
			// 
			// button1
			// 
			button1.Location = new Point(578, 117);
			button1.Name = "button1";
			button1.Size = new Size(28, 23);
			button1.TabIndex = 37;
			button1.Text = "x";
			button1.UseVisualStyleBackColor = true;
			button1.Visible = false;
			// 
			// button2
			// 
			button2.Location = new Point(528, 117);
			button2.Name = "button2";
			button2.Size = new Size(49, 23);
			button2.TabIndex = 36;
			button2.Text = "Търси";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(390, 117);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(132, 23);
			textBox1.TabIndex = 35;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label11.Location = new Point(154, 98);
			label11.Name = "label11";
			label11.Size = new Size(86, 15);
			label11.TabIndex = 34;
			label11.Text = "Име на автор";
			// 
			// button3
			// 
			button3.Location = new Point(342, 116);
			button3.Name = "button3";
			button3.Size = new Size(28, 23);
			button3.TabIndex = 33;
			button3.Text = "x";
			button3.UseVisualStyleBackColor = true;
			button3.Visible = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(292, 116);
			button4.Name = "button4";
			button4.Size = new Size(49, 23);
			button4.TabIndex = 32;
			button4.Text = "Търси";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(154, 116);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(132, 23);
			textBox2.TabIndex = 31;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.FromArgb(241, 227, 203);
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(154, 145);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(682, 379);
			dataGridView1.TabIndex = 30;
			dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
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
			addBookButton.Location = new Point(735, 40);
			addBookButton.Name = "addBookButton";
			addBookButton.Size = new Size(101, 27);
			addBookButton.TabIndex = 29;
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
			label8.TabIndex = 7;
			label8.Text = "label8";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.FromArgb(202, 81, 22);
			label6.Location = new Point(154, 39);
			label6.Name = "label6";
			label6.Size = new Size(84, 25);
			label6.TabIndex = 5;
			label6.Text = "Каталог";
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
			// panel5
			// 
			panel5.AutoSize = true;
			panel5.BackColor = Color.FromArgb(202, 81, 22);
			panel5.Controls.Add(label9);
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
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.FromArgb(242, 235, 225);
			label9.Location = new Point(47, 490);
			label9.Name = "label9";
			label9.Size = new Size(43, 15);
			label9.TabIndex = 7;
			label9.Text = "Изход";
			// 
			// label4
			// 
			label4.Location = new Point(0, 0);
			label4.Name = "label4";
			label4.Size = new Size(100, 23);
			label4.TabIndex = 0;
			// 
			// exit
			// 
			exit.BackgroundImageLayout = ImageLayout.Center;
			exit.Cursor = Cursors.Hand;
			exit.Image = Properties.Resources.log_out;
			exit.Location = new Point(42, 420);
			exit.Name = "exit";
			exit.Size = new Size(75, 65);
			exit.TabIndex = 6;
			exit.TabStop = false;
			exit.Click += exit_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.FromArgb(242, 235, 225);
			label3.Location = new Point(45, 363);
			label3.Name = "label3";
			label3.Size = new Size(54, 15);
			label3.TabIndex = 5;
			label3.Text = "Профил";
			// 
			// addBooksImageButton
			// 
			addBooksImageButton.BackgroundImageLayout = ImageLayout.Center;
			addBooksImageButton.Cursor = Cursors.Hand;
			addBooksImageButton.Image = Properties.Resources.user1;
			addBooksImageButton.Location = new Point(38, 295);
			addBooksImageButton.Name = "addBooksImageButton";
			addBooksImageButton.Size = new Size(75, 65);
			addBooksImageButton.TabIndex = 4;
			addBooksImageButton.TabStop = false;
			addBooksImageButton.Click += addBooksImageButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.FromArgb(242, 235, 225);
			label2.Location = new Point(45, 240);
			label2.Name = "label2";
			label2.Size = new Size(51, 15);
			label2.TabIndex = 3;
			label2.Text = "Каталог";
			// 
			// ordersImageButton
			// 
			ordersImageButton.BackgroundImageLayout = ImageLayout.Center;
			ordersImageButton.Image = Properties.Resources.bookshelf;
			ordersImageButton.Location = new Point(38, 174);
			ordersImageButton.Name = "ordersImageButton";
			ordersImageButton.Size = new Size(75, 61);
			ordersImageButton.TabIndex = 2;
			ordersImageButton.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(242, 235, 225);
			label1.Location = new Point(40, 117);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 1;
			label1.Text = "Поръчки";
			// 
			// usersPictureButton
			// 
			usersPictureButton.BackgroundImageLayout = ImageLayout.Center;
			usersPictureButton.Cursor = Cursors.Hand;
			usersPictureButton.Image = Properties.Resources.gear;
			usersPictureButton.Location = new Point(37, 47);
			usersPictureButton.Name = "usersPictureButton";
			usersPictureButton.Size = new Size(75, 67);
			usersPictureButton.TabIndex = 0;
			usersPictureButton.TabStop = false;
			usersPictureButton.Click += usersPictureButton_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(249, 179, 132);
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(pictureBox2);
			panel2.Controls.Add(titleForm);
			panel2.Controls.Add(closeWindowButton);
			panel2.Controls.Add(pictureBox1);
			panel2.Location = new Point(1, 1);
			panel2.Name = "panel2";
			panel2.Size = new Size(857, 30);
			panel2.TabIndex = 0;
			// 
			// pictureBox3
			// 
			pictureBox3.Cursor = Cursors.Hand;
			pictureBox3.Image = Properties.Resources.shopping_cart;
			pictureBox3.Location = new Point(234, 3);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(24, 24);
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.BackgroundImageLayout = ImageLayout.Center;
			pictureBox2.Cursor = Cursors.Hand;
			pictureBox2.Image = Properties.Resources.x_regular_24;
			pictureBox2.Location = new Point(822, 1);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(30, 27);
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// titleForm
			// 
			titleForm.AutoSize = true;
			titleForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			titleForm.ForeColor = Color.FromArgb(88, 28, 12);
			titleForm.Location = new Point(154, 8);
			titleForm.Name = "titleForm";
			titleForm.Size = new Size(70, 15);
			titleForm.TabIndex = 2;
			titleForm.Text = "{username}";
			// 
			// closeWindowButton
			// 
			closeWindowButton.Location = new Point(0, 0);
			closeWindowButton.Name = "closeWindowButton";
			closeWindowButton.Size = new Size(100, 50);
			closeWindowButton.TabIndex = 3;
			closeWindowButton.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(100, 50);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { saveChangesToolStripMenuItem, buyBookToolStripMenuItem, deleteBookToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(184, 70);
			// 
			// saveChangesToolStripMenuItem
			// 
			saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
			saveChangesToolStripMenuItem.Size = new Size(183, 22);
			saveChangesToolStripMenuItem.Text = "Запиши промените";
			saveChangesToolStripMenuItem.Click += saveChangesToolStripMenuItem_Click;
			// 
			// buyBookToolStripMenuItem
			// 
			buyBookToolStripMenuItem.Name = "buyBookToolStripMenuItem";
			buyBookToolStripMenuItem.Size = new Size(183, 22);
			buyBookToolStripMenuItem.Text = "Купи";
			buyBookToolStripMenuItem.Click += buyBookToolStripMenuItem_Click;
			// 
			// deleteBookToolStripMenuItem
			// 
			deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
			deleteBookToolStripMenuItem.Size = new Size(183, 22);
			deleteBookToolStripMenuItem.Text = "Изтрий книга";
			deleteBookToolStripMenuItem.Click += deleteBookToolStripMenuItem_Click;
			// 
			// WorkerViewBooks
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
			Name = "WorkerViewBooks";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Books";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)exit).EndInit();
			((System.ComponentModel.ISupportInitialize)addBooksImageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)ordersImageButton).EndInit();
			((System.ComponentModel.ISupportInitialize)usersPictureButton).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)closeWindowButton).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
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
		private Label label6;
		private Label label5;
		private PictureBox closeWindowButton;
		private Label label8;
		private Label titleForm;
		private Label label9;
		private PictureBox pictureBox2;
		private Button addBookButton;
		private PictureBox pictureBox3;
		private DataGridView dataGridView1;
		private Label label11;
		private Button button3;
		private Button button4;
		private TextBox textBox2;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem saveChangesToolStripMenuItem;
		private ToolStripMenuItem deleteBookToolStripMenuItem;
		private Label label7;
		private Button button1;
		private Button button2;
		private TextBox textBox1;
		private ToolStripMenuItem buyBookToolStripMenuItem;
	}
}
	
