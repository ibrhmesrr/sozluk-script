using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace sozlukforum_script
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_signin_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibes8\source\repos\sozluk-script\sozluk-script\App_Data\database.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", con);

            SqlParameter p1 = new SqlParameter("username", textbox_username.Text);
            SqlParameter p2 = new SqlParameter("password", textbox_password.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Label1.Text = "Girebildin siteye üye olaraktan.";
                Session["session"] = textbox_username.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label1.Text = "Cıks. Yanlış bilgiler bunlar.";
            }
            con.Close();
        }

        protected void button_signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibes8\source\repos\sozluk-script\sozluk-script\App_Data\database.mdf;Integrated Security=True");
            SqlCommand com2 = new SqlCommand("insert into users (username, password) values (@username, @password)", con);
            SqlParameter p11 = new SqlParameter("username", textbox_username.Text);
            SqlParameter p22 = new SqlParameter("password", textbox_password.Text);
            com2.Parameters.Add(p11);
            com2.Parameters.Add(p22);

            con.Open();
            SqlDataReader rd = com2.ExecuteReader();




            Session["session"] = textbox_username.Text;
            Response.Redirect("Default.aspx");
            //   com.ExecuteNonQuery();
















        }
    }
}