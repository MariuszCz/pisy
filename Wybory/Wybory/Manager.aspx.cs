﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wybory
{
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["New"] != null)
            {
                if (Session["New"].ToString() == "admin")
                {

                    welcome.Text += Session["New"].ToString();
                }

                else
                {
                    Response.Redirect("Login.aspx");


                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["New"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void users_Click(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }

        protected void votes_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserView.aspx");
        }

        protected void history_Click(object sender, EventArgs e)
        {
            Response.Redirect("history.aspx");
        }
    }
}