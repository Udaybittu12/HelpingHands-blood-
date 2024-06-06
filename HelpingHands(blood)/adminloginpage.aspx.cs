using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HelpingHands_blood_
{
    public partial class adminloginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["blood"].ToString();   //global connection
            SqlConnection cn = new SqlConnection(con);  //create sqlconnection
            SqlCommand cmd = new SqlCommand("sp_lgin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            int k = (int)cmd.ExecuteScalar();
            if (k!=0)
            {
                Session["TextBox1.Text"] = TextBox1.Text;
                Session["TextBox2.Text"] = TextBox2.Text;
                Response.Write("login success");
                Response.Redirect("stock.aspx");
            }
            else
            { Response.Write( "ivalid username or password"); }
            cn.Close();
        }
    }
}