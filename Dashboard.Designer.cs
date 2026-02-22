namespace Hotel_Wednesday
{
	partial class Dashboard
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
			welcomeLabel = new Label();
			logoutBtn = new Button();
			roomsBtn = new Button();
			bookingsBtn = new Button();
			customersBtn = new Button();
			reportsBtn = new Button();
			deleteBtn = new Button();
			SuspendLayout();
			// 
			// welcomeLabel
			// 
			welcomeLabel.AutoSize = true;
			welcomeLabel.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			welcomeLabel.Location = new Point(50, 30);
			welcomeLabel.Name = "welcomeLabel";
			welcomeLabel.Size = new Size(300, 33);
			welcomeLabel.TabIndex = 0;
			welcomeLabel.Text = "Welcome";
			// 
			// logoutBtn
			// 
			logoutBtn.Location = new Point(650, 30);
			logoutBtn.Name = "logoutBtn";
			logoutBtn.Size = new Size(100, 35);
			logoutBtn.TabIndex = 1;
			logoutBtn.Text = "Logout";
			logoutBtn.UseVisualStyleBackColor = true;
			logoutBtn.Click += logoutBtn_Click;
			// 
			// roomsBtn
			// 
			roomsBtn.Font = new Font("Segoe UI", 12F);
			roomsBtn.Location = new Point(50, 100);
			roomsBtn.Name = "roomsBtn";
			roomsBtn.Size = new Size(150, 60);
			roomsBtn.TabIndex = 2;
			roomsBtn.Text = "Rooms";
			roomsBtn.UseVisualStyleBackColor = true;
			// 
			// bookingsBtn
			// 
			bookingsBtn.Font = new Font("Segoe UI", 12F);
			bookingsBtn.Location = new Point(220, 100);
			bookingsBtn.Name = "bookingsBtn";
			bookingsBtn.Size = new Size(150, 60);
			bookingsBtn.TabIndex = 3;
			bookingsBtn.Text = "Bookings";
			bookingsBtn.UseVisualStyleBackColor = true;
			// 
			// customersBtn
			// 
			customersBtn.Font = new Font("Segoe UI", 12F);
			customersBtn.Location = new Point(390, 100);
			customersBtn.Name = "customersBtn";
			customersBtn.Size = new Size(150, 60);
			customersBtn.TabIndex = 4;
			customersBtn.Text = "Customers";
			customersBtn.UseVisualStyleBackColor = true;
			// 
			// reportsBtn
			// 
			reportsBtn.Font = new Font("Segoe UI", 12F);
			reportsBtn.Location = new Point(560, 100);
			reportsBtn.Name = "reportsBtn";
			reportsBtn.Size = new Size(150, 60);
			reportsBtn.TabIndex = 5;
			reportsBtn.Text = "Reports";
			reportsBtn.UseVisualStyleBackColor = true;
			// 
			// deleteBtn
			// 
			deleteBtn.BackColor = Color.IndianRed;
			deleteBtn.Font = new Font("Segoe UI", 12F);
			deleteBtn.ForeColor = Color.White;
			deleteBtn.Location = new Point(50, 180);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new Size(150, 60);
			deleteBtn.TabIndex = 6;
			deleteBtn.Text = "Delete Records";
			deleteBtn.UseVisualStyleBackColor = false;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(deleteBtn);
			Controls.Add(reportsBtn);
			Controls.Add(customersBtn);
			Controls.Add(bookingsBtn);
			Controls.Add(roomsBtn);
			Controls.Add(logoutBtn);
			Controls.Add(welcomeLabel);
			Name = "Dashboard";
			Text = "Dashboard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label welcomeLabel;
		private Button logoutBtn;
		private Button roomsBtn;
		private Button bookingsBtn;
		private Button customersBtn;
		private Button reportsBtn;
		private Button deleteBtn;
	}
}