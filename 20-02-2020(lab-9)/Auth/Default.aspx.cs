using System;
using System.Security.Cryptography;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        var uname = Uname.Text;
        var passwd = Passwd.Text;

        var md5 = new MD5CryptoServiceProvider();
        var shaData = md5.ComputeHash(Encoding.ASCII.GetBytes(passwd));
        var hashedPasswd = Convert.ToBase64String(shaData, 0, shaData.Length);

        if (uname.Equals("saihemanth") && hashedPasswd.Equals("X03MO1qnZdYdgyfeuILPmQ=="))
        {
            Session["uname"] = uname;
            Response.Redirect("/Home.aspx");
        }
        else
            Message.Text = "Invalid Username / Password";
    }
}