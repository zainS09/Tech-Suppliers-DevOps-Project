<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 39px">
            <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="65px" />
            <asp:Button ID="btnNo" runat="server" height="29px" OnClick="btnNo_Click" style="margin-left: 69px" Text="No" width="65px" />
        </p>
    </form>
</body>
</html>
