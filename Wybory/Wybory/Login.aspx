<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Wybory.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 215px;
            text-align: right;
            height: 37px;
        }
        .auto-style4 {
            width: 215px;
            font-size: large;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style6 {
            width: 215px;
            text-align: right;
            font-size: large;
        }
        .auto-style7 {
            height: 37px;
            width: 136px;
        }
        .auto-style10 {
            width: 136px;
        }
        .auto-style11 {
            width: 189px;
        }
        .auto-style12 {
            height: 37px;
            width: 189px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LOGIN:<br />
        <br />
        </strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4" style="text-align: right">Username:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="username" runat="server" Width="159px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="Username is required!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Password:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="pass" runat="server" CssClass="auto-style5" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pass" ErrorMessage="Password is required!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style12">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-bottom: 3px" Text="Login" Height="37px" Width="73px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">New User</asp:HyperLink>
&nbsp;</td>
                <td class="auto-style7"></td>
            </tr>
        </table>
    </form>
</body>
</html>
