using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Wednesday
{
	public partial class SIGN_UP : Form
	{
		public SIGN_UP()
		{
			InitializeComponent();
			roleCombo.Items.AddRange(new string[] { "Admin", "Receptionist", "Manager" });
			roleCombo.SelectedIndex = 1;
		}

		public static string connString = ConfigurationManager.ConnectionStrings["Hotel"].ConnectionString;
		SqlConnection con = new SqlConnection(connString);
		private void fullnameBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void emailTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordTxt_TextChanged(object sender, EventArgs e)
		{

		}

		public static string hash(String password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password);
		}
		
		private void signup_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "INSERT INTO HOTEL_USERSS (Fullname,User_Email, User_Password, role) VALUES (@fullname,@email,@Password,@role)";

				using (var conLocal = new SqlConnection(connString))
				using (var cmd = new SqlCommand(query, conLocal))
				{
					cmd.Parameters.AddWithValue("@fullname", fullnameBox.Text.Trim());
					cmd.Parameters.AddWithValue("@Email", emailTxt.Text);
					cmd.Parameters.AddWithValue("@Password", hash(passwordTxt.Text.Trim()));
					cmd.Parameters.AddWithValue("@role", roleCombo.SelectedItem.ToString().ToUpper());

					conLocal.Open();
					int rowsAffected = cmd.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MessageBox.Show("Signup successful!");
						var login = new Login();
						login.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Signup failed. Please try again.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}
	}
}
