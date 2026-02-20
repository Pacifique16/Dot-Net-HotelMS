namespace Hotel_Wednesday
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			loginBtn = new Button();
			label3 = new Label();
			passwordTxt = new TextBox();
			label2 = new Label();
			emailTxt = new TextBox();
			linkLabel1 = new LinkLabel();
			label1 = new Label();
			SuspendLayout();
			// 
			// loginBtn
			// 
			loginBtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			loginBtn.Location = new Point(124, 291);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(94, 29);
			loginBtn.TabIndex = 17;
			loginBtn.Text = "Login";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtn_Click_1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(125, 194);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 16;
			label3.Text = "Password";
			// 
			// passwordTxt
			// 
			passwordTxt.Location = new Point(125, 217);
			passwordTxt.Name = "passwordTxt";
			passwordTxt.Size = new Size(264, 27);
			passwordTxt.TabIndex = 15;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(125, 125);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 14;
			label2.Text = "Email";
			// 
			// emailTxt
			// 
			emailTxt.Location = new Point(125, 148);
			emailTxt.Name = "emailTxt";
			emailTxt.Size = new Size(264, 27);
			emailTxt.TabIndex = 13;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(124, 251);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(222, 20);
			linkLabel1.TabIndex = 11;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Don't have an account? SIGN UP";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(125, 39);
			label1.Name = "label1";
			label1.Size = new Size(280, 33);
			label1.TabIndex = 9;
			label1.Text = "HOTEL WEDNESDAY";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(534, 450);
			Controls.Add(loginBtn);
			Controls.Add(label3);
			Controls.Add(passwordTxt);
			Controls.Add(label2);
			Controls.Add(emailTxt);
			Controls.Add(linkLabel1);
			Controls.Add(label1);
			Name = "Login";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button loginBtn;
		private Label label3;
		private TextBox passwordTxt;
		private Label label2;
		private TextBox emailTxt;
		private LinkLabel linkLabel1;
		private Label label1;
	}
}