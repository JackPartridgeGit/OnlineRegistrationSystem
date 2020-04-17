using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Registration_Form
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblProcess.Text = "Your registration has been processed. Thank you very much";

                SqlCommand command;

                SqlConnection conn;

                string query;

                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                conn.Open();

                query = "INSERT INTO CLIENT(FullName, LoginId, Password, Address, City, State, Phone)" +
                        "VALUES (@fullName, @loginId, @password, @address, @city, @state, @phone);";

                command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@fullName", TextBox1.Text);
                command.Parameters.AddWithValue("@loginId", TextBox2.Text);
                command.Parameters.AddWithValue("@password", TextBox3.Text);
                command.Parameters.AddWithValue("@address", TextBox4.Text);
                command.Parameters.AddWithValue("@city", TextBox5.Text);
                command.Parameters.AddWithValue("@state", TextBox6.Text);
                command.Parameters.AddWithValue("@phone", TextBox7.Text);

                command.ExecuteNonQuery();

                command.Dispose();

                conn.Close();
            }
        }
    }
}