using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Master2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["empname"] == null)//if cookie is not created then it has to be redirected to Login page
                Response.Redirect("Login.aspx");//after login cookie will be created
            else
                Label1.Text = "Welcome " + Request.Cookies["empname"].Value;

        }
    }
}