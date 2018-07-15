using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class admin : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=ocp2;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text=Session["username"].ToString();

        SqlDataAdapter sda = new SqlDataAdapter("select * from Reg",cn);
        DataSet ds = new DataSet();
        sda.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        SqlDataAdapter sda2 = new SqlDataAdapter("select * from Course",cn);
        DataSet ds2 = new DataSet();
        sda2.Fill(ds2);
        GridView2.DataSource = ds2;
        GridView2.DataBind();

        SqlDataAdapter sda3 = new SqlDataAdapter("select * from Security",cn);
        DataSet ds3 = new DataSet();
        sda3.Fill(ds3);
        GridView3.DataSource = ds3;
        GridView3.DataBind();

        SqlDataAdapter sda4 = new SqlDataAdapter("select * from admin",cn);
        DataSet ds4 = new DataSet();
        sda4.Fill(ds4);
        GridView4.DataSource = ds4;
        GridView4.DataBind();
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("Delete from Reg where username='" + TextBox1.Text + "' ", cn);
        SqlCommand cmd2 = new SqlCommand("Delete from course where uid='" + TextBox1.Text + "' ", cn);
        SqlCommand cmd3 = new SqlCommand("Delete from Security where uid='" + TextBox1.Text + "'", cn);
        SqlCommand cmd4 = new SqlCommand("Delete from admin where uid='"+TextBox1.Text+"'",cn);

        cmd2.ExecuteNonQuery();
        cmd3.ExecuteNonQuery();
        cmd4.ExecuteNonQuery();
        cmd.ExecuteNonQuery();
        cn.Close();
    }
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        cn.Open();

        SqlCommand cmd = new SqlCommand("update Reg set email='" + TextBox3.Text + "' where username='" + TextBox2.Text + "' ", cn);

        cmd.Parameters.AddWithValue("@email", TextBox3.Text);
        cmd.ExecuteNonQuery();
        cn.Close();
    }
}