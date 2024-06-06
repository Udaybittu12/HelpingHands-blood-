using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelpingHands_blood_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            if (username == "customer" && password == "password")
            {
                // Store the username in session
                Session["username"] = username;

                // Redirect to home page
                Response.Redirect("customer.aspx");
            }
            else
            {
                Response.Write( "Invalid username or password!");
            }
        }
    }
}