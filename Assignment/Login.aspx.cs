using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from ASPEMP where Empid=@eid and Password=@pwd", con);
            adp.SelectCommand.Parameters.AddWithValue("@eid", int.Parse(txtempid.Text));
            adp.SelectCommand.Parameters.AddWithValue("@pwd", txtpassword.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds,"P");
            if (ds.Tables["P"].Rows.Count == 1)
            {
                string name = ds.Tables["P"].Rows[0][1].ToString();
                string type = ds.Tables["P"].Rows[0][3].ToString();
                if (type == "Admin")
                {
                    Response.Cookies["empname"].Value = name;
                    Response.Redirect("Admin.aspx");
                }
                else if (type == "associate")
                {
                    Response.Cookies["empname"].Value = name;
                    Response.Redirect("associate.aspx");
                }
            }
            else
                Label1.Text = "Invalid Credentials";
        }
    }
}