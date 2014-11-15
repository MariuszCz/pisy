using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Wybory
{
    public partial class Users : System.Web.UI.Page
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

            string name = Session["New"].ToString();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            String checkvote = "select OddanyGlos from Users where Username='" + name + "'";
            SqlCommand com = new SqlCommand(checkvote, conn);
            string votes = Convert.ToString(com.ExecuteScalar());
            int licznik = Convert.ToInt32(votes);
            if (licznik != 0)
            {
                Response.Redirect("UserView.aspx");
            }
            else
            {
                Response.Redirect("UserForm.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Response.Redirect("Login.aspx");
        }
       
       
    }
}