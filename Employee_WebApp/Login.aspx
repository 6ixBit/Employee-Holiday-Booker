<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Employee_WebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 669px;
            text-align: right;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style5 {
            width: 607px;
        }
        .auto-style6 {
            margin-left: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Login to Holiday Booking System</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox_email" runat="server" TextMode="Email" Width="150px"></asp:TextBox>
                    <strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox_email" CssClass="auto-style4" ErrorMessage="An email address is required"></asp:RequiredFieldValidator>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox_password" runat="server" TextMode="Password" Width="149px"></asp:TextBox>
                    <strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_password" CssClass="auto-style4" ErrorMessage="Your password is required"></asp:RequiredFieldValidator>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button_login" runat="server" CssClass="auto-style6" OnClick="Button_login_Click" Text="Login" Width="78px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
