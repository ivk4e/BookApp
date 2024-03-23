namespace BookApp.Forms.Workers
{
	partial class WorkersViewOrders
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersViewOrders));
			panel1 = new Panel();
			groupBox1 = new GroupBox();
			pictureBox4 = new PictureBox();
			radioButton1 = new RadioButton();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			label6 = new Label();
			dataGridView1 = new DataGridView();
			label8 = new Label();
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
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(241, 227, 203);
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(label5);
			panel1.Location = new Point(1, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(857, 557);
			panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(pictureBox4);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Controls.Add(radioButton3);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.Location = new Point(394, 36);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(430, 54);
			groupBox1.TabIndex = 15;
			groupBox1.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Cursor = Cursors.Hand;
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
			pictureBox4.Location = new Point(388, 15);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(36, 32);
			pictureBox4.TabIndex = 11;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4_Click_1;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(6, 22);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(148, 19);
			radioButton1.TabIndex = 8;
			radioButton1.TabStop = true;
			radioButton1.Text = "Очаква потвърждение";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(284, 22);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(75, 19);
			radioButton3.TabIndex = 10;
			radioButton3.TabStop = true;
			radioButton3.Text = "Отказана";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged_1;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.ForeColor = SystemColors.ControlText;
			radioButton2.ImageAlign = ContentAlignment.BottomRight;
			radioButton2.Location = new Point(173, 22);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(91, 19);
			radioButton2.TabIndex = 9;
			radioButton2.TabStop = true;
			radioButton2.Text = "Потвърдена";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.FromArgb(202, 81, 22);
			label6.Location = new Point(169, 52);
			label6.Name = "label6";
			label6.Size = new Size(96, 25);
			label6.TabIndex = 14;
			label6.Text = "Поръчки";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(169, 96);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(655, 394);
			dataGridView1.TabIndex = 13;
			dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
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
			ordersImageButton.Cursor = Cursors.Hand;
			ordersImageButton.Image = Properties.Resources.bookshelf;
			ordersImageButton.Location = new Point(38, 174);
			ordersImageButton.Name = "ordersImageButton";
			ordersImageButton.Size = new Size(75, 61);
			ordersImageButton.TabIndex = 2;
			ordersImageButton.TabStop = false;
			ordersImageButton.Click += ordersImageButton_Click;
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
			usersPictureButton.Image = Properties.Resources.gear;
			usersPictureButton.Location = new Point(37, 47);
			usersPictureButton.Name = "usersPictureButton";
			usersPictureButton.Size = new Size(75, 67);
			usersPictureButton.TabIndex = 0;
			usersPictureButton.TabStop = false;
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
			pictureBox3.TabIndex = 8;
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
			// WorkersViewOrders
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
			Name = "WorkersViewOrders";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Orders";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
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
		private PictureBox closeWindowButton;
		private Label label8;
		private Label titleForm;
		private Label label9;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private GroupBox groupBox1;
		private PictureBox pictureBox4;
		private RadioButton radioButton1;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private Label label6;
		private DataGridView dataGridView1;
	}
}
	
