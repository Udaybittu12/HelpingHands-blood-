using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HelpingHands_blood_
{
    public partial class stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                getdata();
            }
        }
        private void getdata()
        {
            string s = ConfigurationManager.ConnectionStrings["blood"].ToString();
            SqlConnection con = new SqlConnection(s);
            SqlDataAdapter da = new SqlDataAdapter("select*from bgroup", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "bgroup");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q="";
            if (RadioButton1.Checked==true)
            {
                q = "sp_incgroup";
            }
            else if(RadioButton2.Checked==true)
            {
                q = "sp_decgroup";
            }
            string s = ConfigurationManager.ConnectionStrings["blood"].ToString();
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bloodgroup", DropDownList1.SelectedValue);
            int k = cmd.ExecuteNonQuery();
            if (k != 0) { Response.Write("changes updated successfully"); }
            else { Response.Write("invalid"); }
            con.Close();
            getdata();
        }
    }
}