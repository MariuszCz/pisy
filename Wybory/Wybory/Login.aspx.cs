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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();


            String checkuser = "select count(*) from Users where Username='" + username.Text + "'";
            SqlCommand con = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(con.ExecuteScalar().ToString());
            if (temp == 1)
            {
                
                string checkPasswordQuery = "select Password from Users where Username='" + username.Text + "'";
                SqlCommand PassCom = new SqlCommand(checkPasswordQuery,conn);
                string password = PassCom.ExecuteScalar().ToString().Replace(" ","");
                if (password == pass.Text)
                {
                    Session["New"] = username.Text;
                    Response.Write("Password is correct");


                    String insertQuery = "insert into History (Id,Username,Data) values (@id,@usname,@data)";
                    SqlCommand ins = new SqlCommand(insertQuery, conn);
                  
                    SqlCommand licznik_rek = new SqlCommand("SELECT COUNT(*) FROM History", conn);
                    string licznik_g = Convert.ToString(licznik_rek.ExecuteScalar());
                    int licznik = Convert.ToInt32(licznik_g);
                    licznik++;
                    ins.Parameters.AddWithValue("@id", licznik);
                    ins.Parameters.AddWithValue("@usname", username.Text);
                    ins.Parameters.AddWithValue("@data", DateTime.Now.ToString());
                    ins.ExecuteNonQuery();
                    if (username.Text == "admin")
                    {
                        Response.Redirect("Manager.aspx");
                    }
                    else
                    {
                        Response.Redirect("Users.aspx");
                    }
                }
                    else
                    {
                        Response.Write("Password is not correct");
                    }
                }
                else 
                {
                    Response.Write("Username is not correct");
                }
            conn.Close();
        }
            }
            
    }
