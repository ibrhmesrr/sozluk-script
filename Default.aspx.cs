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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ibes8\source\repos\sozlukforum-script\App_Data\data.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from list_topic", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("entrys.aspx?p=lens");
        }
    }
}