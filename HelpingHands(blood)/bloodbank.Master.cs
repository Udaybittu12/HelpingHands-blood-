using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelpingHands_blood_
{
    public partial class bloodbank : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNew.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchBloodDonor.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("stock.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditDel.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Session["TextBox1.Text"] =null;
            //Session["TextBox2.Text"] = null;
            Session.Abandon();
            Session.Clear();
            Response.Redirect("adminloginpage.aspx");
        }
    }
}