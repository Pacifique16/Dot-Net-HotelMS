using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Wednesday
{
	public partial class Login : Form
	{
		// connecting string global
		public static string connString = "Data Source=Pacifique\\SQLEXPRESS;Initial Catalog=DOTNET;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True";
		// sql connection global
		SqlConnection conn = new SqlConnection(connString);
		public Login()
		{
			InitializeComponent();
		}

		public static bool verifyPassword(string db_password, string User_Password)
		{
			return BCrypt.Net.BCrypt.Verify(User_Password, db_password);
		}


		private void loginBtn_Click_1(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT User_Email, User_Password, role, Fullname FROM HOTEL_USERSS WHERE User_Email = @email";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());

				if (conn.State == ConnectionState.Closed)
					conn.Open();

				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					string db_password = reader["User_Password"]?.ToString() ?? "";
					if (verifyPassword(db_password, passwordTxt.Text.Trim()))
					{
						string role = reader["role"]?.ToString() ?? "RECEPTIONIST";
						string fullname = reader["Fullname"]?.ToString() ?? "";

						Dashboard dashboard = new Dashboard(role, fullname);
						dashboard.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Invalid email or password");
					}
				}
				else
				{
					MessageBox.Show("Invalid email or password");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SIGN_UP signup = new SIGN_UP();
			signup.Show();
			this.Hide();
		}
	}
}