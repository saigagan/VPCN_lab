using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Label1.Text = "PreInit";

    }
    protected void Page_Init(object sender, EventArgs e)
    {
        Label2.Text = "Init";
    
     }
    protected void Page_InitComplete(object sender, EventArgs e)
    {
        Label3.Text = "InitComplete";
    

    }
    override protected void OnPreLoad(EventArgs e)
    {
        Label4.Text = "OnPreload";

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Label5.Text = "Load";

    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        Label6.Text = "LoadComplete";

    }

    protected override void OnPreRender(EventArgs e)
    {
        Label7.Text = "PreRender";

    }
    protected override void OnSaveStateComplete  ( EventArgs e)
        
    {
        Label8.Text = "SaveStateComplete";
        

    }


}