using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sozlukforum_script
{
    public partial class create_entry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_session_result.Visible = false;
            button_send.Visible = false;
            lbl_topic.Visible = false;
            textbox_entry.Visible = false;
            textbox_topic.Visible = false;
        }
    }
}