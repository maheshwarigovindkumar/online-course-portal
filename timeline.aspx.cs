using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class timeline : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text=Session["username"].ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
          
        Response.Redirect("Course.aspx");
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://www.geeksforgeeks.org/c-plus-plus/");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("https://www.geeksforgeeks.org/data-structures/");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
}