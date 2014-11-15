<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="Wybory.Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          
    <div style="margin-left: 720px">
    
    &nbsp;<asp:Label ID="welcome" runat="server" Text="Welcome "></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Logout" Height="29px" Width="84px" />
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;&nbsp;</td>
            </tr>
        </table>
   
    <div style="height: 361px; width: 669px">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="users" runat="server" Height="46px" OnClick="users_Click" style="margin-left: 0px" Text="Users" Width="78px" />
        <asp:Button ID="votes" runat="server" Height="46px" OnClick="votes_Click" style="margin-top: 0px" Text="Votes" Width="74px" />
        <asp:Button ID="history" runat="server" Height="46px" OnClick="history_Click" Text="History" Width="74px" />
    
    </div>
    </form>
</body>
</html>
