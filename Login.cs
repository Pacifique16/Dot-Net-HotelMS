using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
		public static string connString = ConfigurationManager.ConnectionStrings["hotel"].ConnectionString;
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
			//query to retrieve
			try
			{
				string query = "SELECT User_Email, User_Password FROM HOTEL_USERSS WHERE User_Email = @email";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
				cmd.Parameters.AddWithValue("@password", passwordTxt.Text.Trim());

				//open connection
				if (conn.State == ConnectionState.Closed)
					conn.Open();

				//read data from db
				SqlDataReader reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					string db_password = reader["User_Password"].ToString();
					if (verifyPassword(db_password, passwordTxt.Text.Trim()))
					{

						Dashboard dashboard = new Dashboard();
						dashboard.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Invalid email or password");
					}

					//close connection

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//add parameters
			//
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SIGN_UP signup = new SIGN_UP();
			signup.Show();
			this.Hide();
		}
	}
}