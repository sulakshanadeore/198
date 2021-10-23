<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="StateMgtDemo.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="195px" Width="217px"></asp:ListBox>
        <br />
        <br />
        <br />
        Enter ProductID :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter ProductName:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
