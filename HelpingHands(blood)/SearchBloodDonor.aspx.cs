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
    public partial class SearchBloodDonor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void getdata()
        {
            string s = ConfigurationManager.ConnectionStrings["blood"].ToString();
            SqlConnection con = new SqlConnection(s);
            SqlDataAdapter da = new SqlDataAdapter("select*from blood where donorid='"+TextBox1.Text+"'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "blood");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["blood"].ToString());
            con.Open();
            string q = "sp_searchblood";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@donorid", TextBox1.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows  )
            {
                rdr.Read();
                getdata();
            }
            else
            {
                Response.Write("Record Not Found");
            }
            con.Close();

        }
    }
}