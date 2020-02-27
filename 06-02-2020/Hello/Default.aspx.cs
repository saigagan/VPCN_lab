using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Display_Click(object sender, EventArgs e)
    {
        Message.Text = "Welcome, " + Name.Text;
    }
}