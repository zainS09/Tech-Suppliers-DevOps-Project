<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 978px">
    <form id="form1" runat="server">
        <div style="height: 86px">
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 444px; top: 282px; position: absolute; height: 35px; width: 341px;" Text="Are you sure you want to delete this record?" BackColor="White" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 497px; top: 351px; position: absolute; height: 28px; width: 68px; right: 597px;" Text="Yes" BackColor="White" BorderColor="Black" BorderStyle="Solid" CssClass="btn" Font-Bold="True" Font-Italic="True" Font-Size="Medium" />
        <asp:Button ID="btnNo" runat="server" height="28px" OnClick="btnNo_Click" style="z-index: 1; left: 622px; top: 351px; position: absolute" Text="No" width="68px" BackColor="White" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Italic="True" Font-Size="Medium" />
    </form>
</body>
</html>
