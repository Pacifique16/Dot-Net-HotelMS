namespace Hotel_Wednesday
{
	partial class SIGN_UP
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
			signupBtn = new Button();
			label3 = new Label();
			label2 = new Label();
			emailTxt = new TextBox();
			Fullname = new Label();
			linkLabel1 = new LinkLabel();
			fullnameBox = new TextBox();
			label1 = new Label();
			passwordTxt = new TextBox();
			roleCombo = new ComboBox();
			label4 = new Label();
			SuspendLayout();
			// 
			// signupBtn
			// 
			signupBtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			signupBtn.Location = new Point(124, 395);
			signupBtn.Name = "signupBtn";
			signupBtn.Size = new Size(94, 29);
			signupBtn.TabIndex = 17;
			signupBtn.Text = "Sign Up";
			signupBtn.UseVisualStyleBackColor = true;
			signupBtn.Click += signup_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(125, 238);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 16;
			label3.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(125, 169);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 14;
			label2.Text = "Email";
			// 
			// emailTxt
			// 
			emailTxt.Location = new Point(125, 192);
			emailTxt.Name = "emailTxt";
			emailTxt.Size = new Size(264, 27);
			emailTxt.TabIndex = 13;
			emailTxt.TextChanged += emailTxt_TextChanged;
			// 
			// Fullname
			// 
			Fullname.AutoSize = true;
			Fullname.Location = new Point(125, 110);
			Fullname.Name = "Fullname";
			Fullname.Size = new Size(69, 20);
			Fullname.TabIndex = 12;
			Fullname.Text = "Fullname";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(124, 355);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(219, 20);
			linkLabel1.TabIndex = 11;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Already have an account? Login";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// fullnameBox
			// 
			fullnameBox.Location = new Point(125, 133);
			fullnameBox.Name = "fullnameBox";
			fullnameBox.Size = new Size(264, 27);
			fullnameBox.TabIndex = 10;
			fullnameBox.TextChanged += fullnameBox_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(125, 49);
			label1.Name = "label1";
			label1.Size = new Size(280, 33);
			label1.TabIndex = 9;
			label1.Text = "HOTEL WEDNESDAY";
			// 
			// passwordTxt
			// 
			passwordTxt.Location = new Point(125, 265);
			passwordTxt.Name = "passwordTxt";
			passwordTxt.Size = new Size(264, 27);
			passwordTxt.TabIndex = 18;
			passwordTxt.TextChanged += passwordTxt_TextChanged;
			// 
			// roleCombo
			// 
			roleCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			roleCombo.Location = new Point(125, 325);
			roleCombo.Name = "roleCombo";
			roleCombo.Size = new Size(264, 28);
			roleCombo.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(125, 302);
			label4.Name = "label4";
			label4.Size = new Size(39, 20);
			label4.TabIndex = 20;
			label4.Text = "Role";
			// 
			// SIGN_UP
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(498, 450);
			Controls.Add(label4);
			Controls.Add(roleCombo);
			Controls.Add(passwordTxt);
			Controls.Add(signupBtn);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(emailTxt);
			Controls.Add(Fullname);
			Controls.Add(linkLabel1);
			Controls.Add(fullnameBox);
			Controls.Add(label1);
			Name = "SIGN_UP";
			Text = "SIGN_UP";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button signupBtn;
		private Label label3;
		private Label label2;
		private TextBox emailTxt;
		private Label Fullname;
		private LinkLabel linkLabel1;
		private TextBox fullnameBox;
		private Label label1;
		private TextBox passwordTxt;
		private ComboBox roleCombo;
		private Label label4;
	}
}