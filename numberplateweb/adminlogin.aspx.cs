using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace numberplateweb
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Admin")
            {
                if (TextBox2.Text == "Admin123")
                {

                    Session["LoginUserName"] = Convert.ToString(TextBox1.Text);
                    Response.Redirect("Dashbord.aspx");

                    //login Success
                }
                else
                {
                    Response.Write("<script>alert(' password wrong');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert(' username wrong');</script>"); //username Wroeng
            }
        }

        
    }
}