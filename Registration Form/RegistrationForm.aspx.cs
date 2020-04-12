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

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand command;
            String queryTable;

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();

            queryTable = "Insert into Client(FullName, LoginID, Password, Address, City, State, Phone) values (@FullName, @LoginID, @Password, @Address, @City, @State, @Phone)";

            command = new SqlCommand(queryTable, conn);
            command.Parameters.AddWithValue("@FullName", TextBox1.Text);
            command.Parameters.AddWithValue("@LoginID", TextBox2.Text);
            command.Parameters.AddWithValue("@Password", TextBox3.Text);
            command.Parameters.AddWithValue("@Address", TextBox4.Text);
            command.Parameters.AddWithValue("@City", TextBox5.Text);
            command.Parameters.AddWithValue("@State", TextBox6.Text);
            command.Parameters.AddWithValue("@Phone", TextBox7.Text);

            command.ExecuteNonQuery();
            command.Dispose();
            conn.Close();

        }
    }
}