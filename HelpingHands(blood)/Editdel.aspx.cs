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
    public partial class AddNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                getdata();
            }
        }
        private void getdata()
        {
            string s = ConfigurationManager.ConnectionStrings["blood"].ToString();
            SqlConnection con = new SqlConnection(s);
            SqlDataAdapter da=new SqlDataAdapter("sp_alldonordetails", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "blood");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c1 = row.FindControl("TextBox1");
            TextBox t1 = (TextBox)c1;
            Control c2 = row.FindControl("TextBox2");
            TextBox t2 = (TextBox)c2;
            Control c3 = row.FindControl("TextBox3");
            TextBox t3 = (TextBox)c3;
            Control c4 = row.FindControl("DropDownList1");
            DropDownList D1 = (DropDownList)c4;
            Control c5 = row.FindControl("TextBox4");
            TextBox t5 = (TextBox)c5;
            Control c6 = row.FindControl("TextBox5");
            TextBox t6 = (TextBox)c6;
            Control c7 = row.FindControl("TextBox6");
            TextBox t7 = (TextBox)c7;
            Control c8 = row.FindControl("TextBox7");
            TextBox t8 = (TextBox)c8;
            Control c9 = row.FindControl("DropDownList2");
            DropDownList D2 = (DropDownList)c9;
            Control c10 = row.FindControl("TextBox8");
            TextBox t10 = (TextBox)c10;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["blood"].ToString());
            con.Open();
            string q = "sp_updateblood";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@donorid",t1.Text);
            cmd.Parameters.AddWithValue("@name",t2.Text);
            cmd.Parameters.AddWithValue("@fathername",t3.Text);
            cmd.Parameters.AddWithValue("@bloodgroup",D1.SelectedValue);
            cmd.Parameters.AddWithValue("@mothername",t5.Text);
            cmd.Parameters.AddWithValue("@city",t6.Text);
            cmd.Parameters.AddWithValue("@dateofbirth",t7.Text);
            cmd.Parameters.AddWithValue("@mobile",t8.Text);
            cmd.Parameters.AddWithValue("@gender",D2.SelectedValue);
            cmd.Parameters.AddWithValue("@Address",t10.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            getdata();
              
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Control c1 = row.FindControl("Label1");
            Label l1 = (Label)c1;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["blood"].ToString());
            con.Open();
            string q = "sp_delblood";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@donorid", l1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            getdata();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            getdata();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            getdata();
        }
    }
}