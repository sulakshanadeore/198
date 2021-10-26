<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MyApp.Master" CodeBehind="Login.aspx.cs" Inherits="MasterPagesDemo.Login" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
   <%--   <form id="form1" runat="server">--%>
        <div>
            <br />
            Session ID :
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            Is NewSession:
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            IS cookieLess:
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            U are the&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp; user of this applications<br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter UserName">

            </asp:Label>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Password">

            </asp:Label>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
            <br />

            
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />


        </div>
    <%--</form>--%>
</asp:Content>


