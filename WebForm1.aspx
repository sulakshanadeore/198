<%@ Page  Language="C#" Title="LoginForm" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstWebApplicationDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
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
        <div>
            <asp:Label ID="lblcity" runat="server" Text="Enter City"></asp:Label>
            <asp:TextBox ID="txtcity" runat="server" Width="540px"></asp:TextBox>
        </div>
            <p>
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
            </p>
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
            List of items&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MyCart" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Shopping cart<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select ITem and click here to Remvoe Item" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="140px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="111px">
                <asp:ListItem Value="15000">Mobiles</asp:ListItem>
                <asp:ListItem Value="200">charger</asp:ListItem>
                <asp:ListItem Value="45000">Laptop</asp:ListItem>
                <asp:ListItem Value="3000">Hard disk</asp:ListItem>
                <asp:ListItem Value="200">Diwali Lights</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" CssClass="auto-style1" Height="126px" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" Width="228px"></asp:ListBox>
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Pay Now" />
            <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
