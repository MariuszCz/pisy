using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wybory
{
    public partial class UserView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                welcome.Text += Session["New"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            if (Session["New"].ToString() == "admin")
            {
                back.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manager.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
       

        
    }
}