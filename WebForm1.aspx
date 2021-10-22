<%@ Page  Language="C#" Title="LoginForm" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstWebApplicationDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<input type="text"--%>
            <asp:Label ID="lblname" runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <br />
         
            <asp:Label ID="lblselectcity" runat="server" Text="Select City">

            </asp:Label>

            <asp:DropDownList ID="ddlCity" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Select State:
            <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                <asp:ListItem Value="GJ">Gujarat</asp:ListItem>
                <asp:ListItem Value="TS">Telangana</asp:ListItem>
                <asp:ListItem Value="KA">Karnataka</asp:ListItem>
                <asp:ListItem Value="MH">Maharashtra</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtvalueGreen" runat="server" BackColor="#009933"></asp:TextBox>
&nbsp;&nbsp;
            <asp:TextBox ID="txtTextMagenta" runat="server" BackColor="Fuchsia"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblcity" runat="server" Text="Enter City"></asp:Label>
            <asp:TextBox ID="txtcity" runat="server" Width="540px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
        </p>
    </form>
</body>
</html>
