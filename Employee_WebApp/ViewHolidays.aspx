<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewHolidays.aspx.cs" Inherits="Employee_WebApp.ViewHolidays" %>

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
        }
        .auto-style3 {
            margin-left: 647px;
            margin-right: 1098px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>View Holidays</strong></div>
        <p>
            &nbsp;</p>
        <div class="auto-style2">
        </div>

        <div class="auto-style2">
        <asp:Table ID="Table1" runat="server" CssClass="auto-style3" GridLines="Both" HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0">
            <asp:TableRow>
                <asp:TableCell>Holiday Start</asp:TableCell>
                <asp:TableCell>Holiday End</asp:TableCell>
                <asp:TableCell>Holiday Status</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </div>

    </form>
</body>
</html>
