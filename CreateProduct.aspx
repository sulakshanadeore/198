<%@ Page Title="" Language="C#" MasterPageFile="~/MyApp.Master" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="MasterPagesDemo.CreateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
    Enter ProductName:<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
</p>
<p>
    Enter Price:<asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
</p>
<p>
    Enter UOM:<asp:TextBox ID="txtuom" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
</p>
<p>
    &nbsp;</p>

</asp:Content>
