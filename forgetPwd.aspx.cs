using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class forgetPwd : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=ocp2;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
   

    protected void Button1_Click(object sender, EventArgs e)
    {
        cn.Open();

        SqlCommand cmd = new SqlCommand("select Security.uid, Security.sec_que from Security where sec_que='" + TextBox3.Text + "' and uid='" + TextBox2.Text + "' ", cn);
        SqlDataReader sdr = cmd.ExecuteReader();
      

        if (sdr.Read())
        {
            cn.Close();
            cn.Open();
            SqlCommand cmd2 = new SqlCommand("update Reg set password=@password where username='"+TextBox2.Text+"'",cn);
            cmd2.Parameters.AddWithValue("@password",TextBox4.Text);
            cmd2.ExecuteNonQuery();
              Label1.Text = "Password updated!";
            cn.Close();
            
        }

        else
        {
            
            Label1.Text = "Enter VAlid Answer & username";
           
        }

        cn.Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}