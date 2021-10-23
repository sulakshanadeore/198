<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ControlsDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #00FFFF;
        }
        .auto-style2 {
            height: 23px;
            width: 378px;
        }
        .auto-style3 {
            height: 102px;
            width: 378px;
        }
        .auto-style4 {
            height: 23px;
            width: 206px;
        }
        .auto-style5 {
            height: 102px;
            width: 206px;
        }
    </style>
</head>
<body style="height: 169px; width: 439px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="background-color:aquamarine">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Personal</asp:ListItem>
                            <asp:ListItem>Educational</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style3">
                        <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="PersonalView" runat="server">
                                <asp:Label ID="Label2" runat="server" Text="Personal Details"></asp:Label>
                                <br />
                                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                                <br />
                                <asp:Image ID="Image1" runat="server" />
                                <br />
                                <br />
                            </asp:View>
                            <asp:View ID="EducationalDetails" runat="server">
                                <asp:Label ID="Label3" runat="server" Text="Education Details"></asp:Label>
                                <br />
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <br />
                                <br />
                            </asp:View>
                            <asp:View ID="Other" runat="server">
                                <asp:Label ID="Label4" runat="server" Text="Other Details"></asp:Label>
                                <br />
                                <br />
                                <asp:TextBox ID="TextBox1" runat="server" Height="70px" TextMode="MultiLine" Width="257px"></asp:TextBox>
                            </asp:View>
                        </asp:MultiView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
