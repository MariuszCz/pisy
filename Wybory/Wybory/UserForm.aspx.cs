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
    public partial class UserForm : System.Web.UI.Page
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = Session["New"].ToString();
            GridViewRow row = GridView1.SelectedRow;
            string txtId = row.Cells[1].Text;
            
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            String updateQuery = "update Users set OddanyGlos = @vote where Username='" + name + "'";
            SqlCommand con = new SqlCommand(updateQuery, conn);
            con.Parameters.AddWithValue("@vote", txtId);
            con.ExecuteNonQuery();

            SqlCommand glos = new SqlCommand("SELECT LiczbaGlosow FROM Votes where Id='" + txtId + "'", conn);
            string gl = Convert.ToString(glos.ExecuteScalar());
            int glos2 = Convert.ToInt32(gl);
            glos2++;
            String updateQuery2 = "update Votes set LiczbaGlosow = @vote2 where Id='" + txtId + "'";
            SqlCommand con2 = new SqlCommand(updateQuery2, conn);

            con2.Parameters.AddWithValue("@vote2", glos2);
            con2.ExecuteNonQuery();

            Response.Redirect("UserView.aspx");
            conn.Close();
           
        }

      
       /* protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string name = Session["New"].ToString();
            GridViewRow row = GridView1.SelectedRow;
           string txtId = row.Cells[0].Text;
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
           conn.Open();
           String insertQuery = "insert into Users (OddanyGlos) values (@vote) where Username='" + name + "'";
           SqlCommand con = new SqlCommand(insertQuery, conn);
       
           con.Parameters.AddWithValue("@vote", txtId);
           conn.Close();
        }*/
    }
}