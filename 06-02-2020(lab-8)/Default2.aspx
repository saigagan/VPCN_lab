<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 38px;
        }
    </style>
</head>
<body>
    
    <div>
        <form id="form1" runat="server">

            <asp:RequiredFieldValidator
                runat="server"
                ID="req"
                controltovalidate="txtname1"
                ErrorMessage="enter the name" />
            

          
            <asp:TextBox ID="txtname1" runat="server"/>


          
            <asp:Button ID="Button1" runat="server" Text="Button" CssClass="auto-style1" Height="26px" Width="132px" />
        </form>

    </div>
        
   
</body>
</html>
