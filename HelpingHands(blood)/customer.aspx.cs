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
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["blood"].ToString());
            con.Open();
            string q = "sp_blood";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@donorid", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@fathername", TextBox3.Text);
            cmd.Parameters.AddWithValue("@bloodgroup", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@mothername", TextBox4.Text);
            cmd.Parameters.AddWithValue("@city", TextBox5.Text);
            cmd.Parameters.AddWithValue("@dateofbirth", TextBox6.Text);
            cmd.Parameters.AddWithValue("@mobile", TextBox7.Text);
            cmd.Parameters.AddWithValue("@gender", DropDownList2.SelectedValue);
            cmd.Parameters.AddWithValue("@Address", TextBox8.Text);
            int k = cmd.ExecuteNonQuery();
            if (k != 0) { Response.Write("submitted successfully and refresh"); }
            else { Response.Write("sorry your response not done!"); }
            con.Close();
        }
    }
}