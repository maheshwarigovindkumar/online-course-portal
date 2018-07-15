using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class TImeline : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=ocp2;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        Label1.Text = Session["username"].ToString();
        Label5.Text = Application["msg1"].ToString();

        SqlDataAdapter adp = new SqlDataAdapter("select * from Reg where username='" + Session["username"].ToString() + "' ", cn);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        SqlDataAdapter sda = new SqlDataAdapter("select course.uid,course.cid,course.cname from Course where uid=(select username from Reg where username='"+Session["username"].ToString()+"')",cn);
        
        DataSet dsa = new DataSet();
        sda.Fill(dsa);
        GridView2.DataSource = dsa;
        GridView2.DataBind();
        cn.Close();

        string[] quvery_String = { "username", "datetime" };
        Response.Write(Convert.ToString(Request["username"]));

    }

        

    protected void Button5_Click1(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }

  

    protected void Button3_Click1(object sender, EventArgs e)
    {
        cn.Open();

        SqlCommand cmd = new SqlCommand("update Reg set name ='"+Cname.Text+"', number ='"+Cphone.Text+"', password = '"+Cpassword.Text+"' where username = '" + Session["username"].ToString() + "'", cn);
        cmd.Parameters.AddWithValue("@name",Cname.Text);
        cmd.Parameters.AddWithValue("@number",Cphone.Text);
        cmd.Parameters.AddWithValue("@password",Cpassword.Text);
        cmd.ExecuteNonQuery();
        
        //SqlDataAdapter sda = new SqlDataAdapter("update Reg set name ='"+Cname.Text+"', number ='"+Cphone.Text+"', password = '"+Cpassword.Text+"' where username = '" + Session["username"].ToString() + "'", cn);
       // DataSet ds = new DataSet();
        //sda.Fill(ds);
        //GridView1.DataSource = ds;
       // GridView1.DataBind();

        cn.Close();

    }


 
    protected void Button4_Click1(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("Delete from Reg where username='" + Session["username"].ToString() + "' ", cn);
        SqlCommand cmd2 = new SqlCommand("Delete from course where uid='" + Session["username"].ToString() + "' ", cn);
        SqlCommand cmd3 = new SqlCommand("Delete from Security where uid='" + Session["username"].ToString() +"'",cn);
        
        cmd2.ExecuteNonQuery();
        cmd3.ExecuteNonQuery();
        cmd.ExecuteNonQuery();
        Response.Redirect("index.aspx");
        cn.Close();

    }

   
    protected void Button6_Click1(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("insert into admin values(@uid,@prblm)", cn);
        cmd.Parameters.AddWithValue("@uid", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@prblm", TextBox1.Text);
        Label7.Text = "Scuuesful!";
        cmd.ExecuteNonQuery();

        TextBox1.Text = string.Empty;
        cn.Close();
    }
}
