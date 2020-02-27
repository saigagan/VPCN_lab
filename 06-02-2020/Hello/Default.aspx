<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Hello Page</title>
    </head>
    <body>
        <form id="form1" runat="server"> 
            <div>
                <asp:TextBox ID="Name" runat="server"></asp:TextBox> 
                <br />
                <asp:Button ID="Display" runat="server" Text="Display" OnClick="Display_Click"/> 
                <br />
                <asp:Label ID="Message" runat="server" Text=""></asp:Label>
            </div>
        </form>
    </body>
</html>
