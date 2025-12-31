<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWarning" runat="server" Text="Are you sure yo want to delete this record?"></asp:Label>
        </div>
        <p>
             <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="button" OnClick="btnYes_Click" />
        </p>
        <p>
<asp:Button ID="btnNo" runat="server" Text="No" CssClass="button button-secondary" OnClick="btnNo_Click" />
            </p>
    </form>
</body>
</html>
