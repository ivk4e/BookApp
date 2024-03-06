namespace BookApp.Forms.Login
{
	partial class LoginForm
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
			pictureBox1 = new PictureBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			button1 = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label1 = new Label();
			panel2 = new Panel();
			pictureBox2 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(241, 227, 203);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(1, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(478, 557);
			panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.love__1_;
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.Location = new Point(149, 84);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(177, 148);
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Cursor = Cursors.Hand;
			label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.ForeColor = SystemColors.HotTrack;
			label5.Location = new Point(301, 443);
			label5.Name = "label5";
			label5.Size = new Size(75, 13);
			label5.TabIndex = 8;
			label5.Text = "Регистрация";
			label5.Click += label5_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label4.Location = new Point(214, 443);
			label4.Name = "label4";
			label4.Size = new Size(90, 13);
			label4.TabIndex = 7;
			label4.Text = "Нямаш профил?";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label3.Location = new Point(104, 384);
			label3.Name = "label3";
			label3.Size = new Size(52, 15);
			label3.TabIndex = 6;
			label3.Text = "Парола:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label2.Location = new Point(104, 315);
			label2.Name = "label2";
			label2.Size = new Size(125, 15);
			label2.TabIndex = 5;
			label2.Text = "Потребителско име:";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(202, 81, 22);
			button1.BackgroundImageLayout = ImageLayout.Center;
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderColor = Color.FromArgb(88, 28, 12);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(228, 485);
			button1.Name = "button1";
			button1.Size = new Size(147, 32);
			button1.TabIndex = 4;
			button1.Text = "Влез";
			button1.UseMnemonic = false;
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.FromArgb(242, 235, 225);
			textBox2.BorderStyle = BorderStyle.FixedSingle;
			textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox2.ForeColor = SystemColors.Desktop;
			textBox2.Location = new Point(104, 404);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(271, 33);
			textBox2.TabIndex = 3;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.FromArgb(242, 235, 225);
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.ForeColor = SystemColors.Desktop;
			textBox1.Location = new Point(104, 335);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(271, 33);
			textBox1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(88, 28, 12);
			label1.Location = new Point(190, 245);
			label1.Name = "label1";
			label1.Size = new Size(99, 47);
			label1.TabIndex = 1;
			label1.Text = "Влез";
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(249, 179, 132);
			panel2.Controls.Add(pictureBox2);
			panel2.Location = new Point(1, 1);
			panel2.Name = "panel2";
			panel2.Size = new Size(478, 30);
			panel2.TabIndex = 0;
			// 
			// pictureBox2
			// 
			pictureBox2.BackgroundImage = Properties.Resources.x_regular_24;
			pictureBox2.Cursor = Cursors.Hand;
			pictureBox2.Location = new Point(439, 1);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(29, 29);
			pictureBox2.TabIndex = 0;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(480, 560);
			ControlBox = false;
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private TextBox textBox1;
		private Button button1;
		private TextBox textBox2;
		private Label label3;
		private Label label2;
		private Label label5;
		private Label label4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
	}
}
