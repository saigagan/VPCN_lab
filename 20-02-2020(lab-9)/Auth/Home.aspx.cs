using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var uname = Session["uname"];

        if (uname == null)
            Response.Redirect("/");
        
        Title.Text = "Welcome, " + uname;
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("/");
    }
}