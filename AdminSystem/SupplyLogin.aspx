<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyLogin.aspx.cs" Inherits="SupplyLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 432px;
            height: 363px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplyLoginPage" runat="server" style="z-index: 1; left: 153px; top: 31px; position: absolute; height: 33px; width: 143px" Text="Supply Login Page" BackColor="White" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Size="Large" Font-Strikeout="False"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 57px; top: 96px; position: absolute; height: 34px; width: 90px; right: 1369px" Text="UserName:" BackColor="White" BorderColor="Black" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 156px; top: 94px; position: absolute; width: 137px; height: 21px; bottom: 555px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 58px; top: 163px; position: absolute; height: 34px" Text="Password:" width="90px" BackColor="White" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" height="21px" style="z-index: 1; left: 155px; top: 159px; position: absolute" TextMode="Password" width="137px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Italic="True"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" height="30px" style="z-index: 1; left: 208px; top: 212px; position: absolute" Text="Cancel" width="68px" OnClick="btnCancel_Click" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Font-Size="Medium" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 25px; top: 280px; position: absolute; height: 74px; width: 316px" BackColor="White" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        <p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 87px; top: 213px; position: absolute; height: 30px; width: 68px; right: 1330px" Text="Login" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Font-Size="Medium" />
        </p>
    </form>
</body>
</html>
