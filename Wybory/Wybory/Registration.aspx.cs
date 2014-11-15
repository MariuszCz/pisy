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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                String checkuser = "select count(*) from Users where Username='" + TextBoxUser.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 0)
                {

                    String insertQuery = "insert into Users (Id,Username,Password,Email,Country,OddanyGlos) values (@id,@uname,@password,@email,@country,@vote)";
                    SqlCommand con = new SqlCommand(insertQuery, conn);
                    SqlCommand licznik_rek = new SqlCommand("SELECT COUNT(*) FROM Users", conn);
                    string licznik_g = Convert.ToString(licznik_rek.ExecuteScalar());
                    int licznik = Convert.ToInt32(licznik_g);
                    licznik++;
                    con.Parameters.AddWithValue("@id", licznik);
                    con.Parameters.AddWithValue("@uname", TextBoxUser.Text);
                    con.Parameters.AddWithValue("@password", TextBoxPass.Text);
                    con.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                    con.Parameters.AddWithValue("@country", DropDownList1.Text);
                    con.Parameters.AddWithValue("@vote", '0');
                    con.ExecuteNonQuery();
                    Response.Redirect("Login.aspx");
                    Response.Write("Registration is successfull!");
                    
                }
             else {
                 Response.Write("User already exist");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }

        }
    }
}