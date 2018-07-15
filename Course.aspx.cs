using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Course : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=ocp2;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["username"].ToString();
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        cn.Open();
        int cid = 101;
        string cname = "javascript";
        //string uid = Session["username"].ToString();
        SqlCommand cmd = new SqlCommand("insert into course values(@uid,@cid,@cname) ", cn);

        cmd.Parameters.AddWithValue("@uid",Session["username"].ToString());
        cmd.Parameters.AddWithValue("@cid", cid.ToString());
        cmd.Parameters.AddWithValue("@cname", cname);

        cmd.ExecuteNonQuery();

        Response.Redirect("Timeline.aspx");

        cn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        cn.Open();
        int cid = 102;
        string cname = "Angular-js";
        //string uid = Session["username"].ToString();
        SqlCommand cmd = new SqlCommand("insert into course values(@uid,@cid,@cname) ", cn);

        cmd.Parameters.AddWithValue("@uid", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@cid", cid.ToString());
        cmd.Parameters.AddWithValue("@cname", cname);

        cmd.ExecuteNonQuery();

        Response.Redirect("Timeline.aspx");

        cn.Close();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        cn.Open();
        int cid = 103;
        string cname = "React-js";
        //string uid = Session["username"].ToString();
        SqlCommand cmd = new SqlCommand("insert into course values(@uid,@cid,@cname) ", cn);

        cmd.Parameters.AddWithValue("@uid", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@cid", cid.ToString());
        cmd.Parameters.AddWithValue("@cname", cname);

        cmd.ExecuteNonQuery();

        Response.Redirect("Timeline.aspx");

        cn.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

        cn.Open();
        int cid = 104;
        string cname = "Monogo-Db";
        //string uid = Session["username"].ToString();
        SqlCommand cmd = new SqlCommand("insert into course values(@uid,@cid,@cname) ", cn);

        cmd.Parameters.AddWithValue("@uid", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@cid", cid.ToString());
        cmd.Parameters.AddWithValue("@cname", cname);

        cmd.ExecuteNonQuery();

        Response.Redirect("Timeline.aspx");

        cn.Close();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {

        cn.Open();
        int cid = 105;
        string cname = "Node-js";
        //string uid = Session["username"].ToString();
        SqlCommand cmd = new SqlCommand("insert into course values(@uid,@cid,@cname) ", cn);

        cmd.Parameters.AddWithValue("@uid", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@cid", cid.ToString());
        cmd.Parameters.AddWithValue("@cname", cname);

        cmd.ExecuteNonQuery();

        Response.Redirect("Timeline.aspx");

        cn.Close();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {

        cn.Open();
        int cid = 106;
        string cname = ".net";
        //string uid = Session["username"].ToString();
        SqlCommand cmd = new SqlCommand("insert into course values(@uid,@cid,@cname) ", cn);

        cmd.Parameters.AddWithValue("@uid", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@cid", cid.ToString());
        cmd.Parameters.AddWithValue("@cname", cname);

        cmd.ExecuteNonQuery();

        Response.Redirect("Timeline.aspx");

        cn.Close();
    }
}

   