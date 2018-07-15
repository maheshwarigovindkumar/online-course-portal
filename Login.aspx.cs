using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=ocp2;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();

        
    }

 
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "flash" && TextBox2.Text == "1234567890")
        {
            Session["username"] = "flash";
            Response.Redirect("admin.aspx");
        }
        string userName = TextBox1.Text;
        string passWord = TextBox2.Text;
        SqlCommand cmd = new SqlCommand("select * from Reg where username='" + userName + "' and password='" + passWord + "'", cn);


        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.Read())
        {

            Session["userName"] = userName;
            string quvery_String = "?" + Session["username"].ToString() + "?" + DateTime.Now;
            Response.Redirect("Timeline.aspx" + quvery_String);

            cn.Close();

        }
        else
        {
            Label1.Text = "username or password is invalid";

        }
        cn.Close();

    }
}