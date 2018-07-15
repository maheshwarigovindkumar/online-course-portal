using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Reg : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=ocp2;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand cmd = new SqlCommand("insert into Reg values(@username,@name,@email,@number,@loaction,@age,@password)", cn);
            SqlCommand cmd2 = new SqlCommand("insert into Security values(@uid,@sec_que)",cn);

            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@email", TextBox3.Text);
            cmd.Parameters.AddWithValue("@number", TextBox4.Text);
            cmd.Parameters.AddWithValue("@loaction", TextBox9.Text);
            cmd.Parameters.AddWithValue("@age", TextBox8.Text);
            cmd.Parameters.AddWithValue("@password", TextBox7.Text);

            cmd2.Parameters.AddWithValue("@uid",TextBox1.Text);
            cmd2.Parameters.AddWithValue("@sec_que",TextBox10.Text);
                                                        
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
           // string userName = TextBox1.Text;
            //string passWord = TextBox7.Text;

            //SqlCommand cmd2=new SqlCommand("select * from Reg where username='" + userName + "' and password='" + passWord + "'", cn);

            //SqlDataReader sdr = cmd.ExecuteReader();
            //Session["username"] = userName;

           
            Label2.Text = "Scuessfull!";
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox8.Text = string.Empty;
            TextBox7.Text = string.Empty;

            

            Response.Redirect("Login.aspx");


        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                Label2.Text = "user name is alredy exit";
            }
            else
            {
                Label2.Text = "An Error: " + ex.Message;
            }
        }
        cn.Close();
    }
}