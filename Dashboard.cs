using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Wednesday
{
	public partial class Dashboard : Form
	{
		private string userRole;
		private string userName;

		public Dashboard(string role, string fullname)
		{
			InitializeComponent();
			userRole = role;
			userName = fullname;
			ConfigureRoleBasedAccess();
		}

		private void ConfigureRoleBasedAccess()
		{
			welcomeLabel.Text = $"Welcome, {userName} ({userRole})";

			switch (userRole.ToUpper())
			{
				case "ADMIN":
					break;
				case "MANAGER":
					deleteBtn.Visible = false;
					break;
				case "RECEPTIONIST":
					deleteBtn.Visible = false;
					reportsBtn.Visible = false;
					break;
			}
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Close();
		}
	}
}
