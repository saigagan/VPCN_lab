<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="Uname" placeholder="Username" runat ="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator runat="server" ID="reqName" ControlToValidate="uname" ErrorMessage="Enter Username" />
        <br /> <br />
        <asp:TextBox ID="Passwd" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator runat="server" ID="reqPasswd" ControlToValidate="passwd" ErrorMessage="Enter Password" />
        <br /> <br />
        <asp:Button ID="Submit" runat="server" Text="Login" OnClick="Submit_Click" />
        <br />
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
