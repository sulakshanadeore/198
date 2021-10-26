<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MyApp.Master" CodeBehind="Transfer.aspx.cs" Inherits="MasterPagesDemo.Transfer" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    
    <asp:Repeater ID="Repeater1" runat="server">

        <HeaderTemplate>
            <table>
                <tr style="background-color:white">
                    <td>Categoryid</td>
                    <td>CategoryName</td>
                    <td>Description</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr style="background-color:beige">
                <td>
                    <%#DataBinder.Eval(Container,"DataItem.Id")%>
                </td>
                <td>
                    <%#DataBinder.Eval(Container,"DataItem.Catname")%>
                </td>
                <td>
                       <%#DataBinder.Eval(Container,"DataItem.Description")%>
                </td>
            </tr>
        </ItemTemplate>
        <SeparatorTemplate>
            <tr>
                <td>
                    <hr />
                </td>
                <td>
                    <hr />
                </td>
                <td>
                    <hr />
                </td>

            </tr>
        </SeparatorTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color:yellowgreen">
        <td>
                    <%#DataBinder.Eval(Container,"DataItem.Id")%>
                </td>
                <td>
                    <%#DataBinder.Eval(Container,"DataItem.Catname")%>
                </td>
                <td>
                       <%#DataBinder.Eval(Container,"DataItem.Description")%>
                </td>
            </tr>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
            <tr>
                <td>
                    <hr />
                </td>
                <td>
                    <hr />
                </td>
                <td>
                    <hr />
                </td>

            </tr>
        </SeparatorTemplate>
        <FooterTemplate>
            <tr style="background-color:red">
                <td>Category records found</td>
            </tr>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    
</asp:Content>


