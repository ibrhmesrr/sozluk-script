using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace sozlukforum_script
{
    public partial class entrys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = Request.QueryString["p"];
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibes8\source\repos\sozlukforum-script\App_Data\data.mdf;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select * from topic_" + Request.QueryString["p"] + "", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
            catch {
                Response.Redirect("baslikyok.html");
            }
        }
    }
}