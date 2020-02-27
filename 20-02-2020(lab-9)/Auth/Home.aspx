<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Title" runat="server" Text="Welcome, "></asp:Label>
        <br /><br />
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
        <br />
    </div>
    </form>
</body>
</html>
