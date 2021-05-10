﻿using WebPage.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace WebPage
{
    public partial class Login : System.Web.UI.Page
    {
        localhost.WebService service = new localhost.WebService();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String userName = TextBox1.Text;
            String password = TextBox2.Text;

            var response = service.login(userName, password);

            bool responseState = (bool)response.ElementAt(0);
            string userType = (string)response.ElementAt(1);

            if (responseState)
            {
                FormsAuthentication.SetAuthCookie(userName, true);
                if (userType == "student")
                {
                    Response.Redirect("student/profile.aspx");
                }
                else
                {
                    Response.Redirect("admin/dashboard.aspx");
                }
            }
        }
    }
}