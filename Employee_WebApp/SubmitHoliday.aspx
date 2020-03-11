<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitHoliday.aspx.cs" Inherits="Employee_WebApp.SubmitHoliday" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
            text-decoration: underline;
        }
        .auto-style2 {
            text-align: center;
            font-size: large;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 649px;
        }
        .auto-style5 {
            color: #FF0000;
        }
        .auto-style7 {
            margin-left: 38px;
        }
        .auto-style8 {
            width: 649px;
            text-align: right;
        }
        .auto-style9 {
            text-align: center;
            font-size: large;
            color: #0099FF;
        }
        .auto-style10 {
            color: #0099FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Submit A Holiday Request</strong></div>
        <p class="auto-style2">
            <em>On this page you can submit a holiday request which will be viewed by our admin and dependent on whether or not they align with our constraints, your request will iether be Accepted or Rejected.</em></p>
        <p class="auto-style2">
            &nbsp;</p>
        
        <table class="auto-style3">
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">Format: YYYY-MM-DD</td>
            </tr>
            <tr>
                <td class="auto-style8">Holiday Start</td>
                <td>
                    <asp:TextBox ID="TextBox_holidayStart" runat="server"></asp:TextBox>
                    <strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox_holidayStart" CssClass="auto-style5" ErrorMessage="A start date for your holiday is required"></asp:RequiredFieldValidator>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style8">Holiday End</td>
                <td>
                    <asp:TextBox ID="TextBox_holidayEnd" runat="server"></asp:TextBox>
                    <strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_holidayEnd" CssClass="auto-style5" ErrorMessage="An end date is required"></asp:RequiredFieldValidator>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button_submitHoliday" runat="server" CssClass="auto-style7" OnClick="Button_submitHoliday_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
