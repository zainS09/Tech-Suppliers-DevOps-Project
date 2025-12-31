<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 539px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="391px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="508px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-bottom: 0px" Text="Add" height="29px" width="98px" />
            <asp:Button ID="btnEdit" runat="server" height="29px" OnClick="btnEdit_Click" style="margin-left: 36px" Text="Edit" width="98px" />
            <asp:Button ID="btnDelete" runat="server" height="29px" OnClick="btnDelete_Click" style="margin-left: 36px" Text="Delete" width="98px" />
        </p>
        <p>
            <asp:Label ID="lblEnterFilter" runat="server" Text="Enter a Item Name"></asp:Label>
            <asp:TextBox ID="txtItemNameFilter" runat="server" style="margin-left: 53px; margin-top: 0px"></asp:TextBox>
            <asp:Button ID="btnReturnToMenu" runat="server" style="z-index: 1; left: 306px; top: 517px; position: absolute" Text="Return to Main Menu" height="26px" OnClick="btnReturnToMenu_Click" width="164px" />
        </p>
        <asp:Button ID="btnFilterApply" runat="server" OnClick="btnFilterApply_Click" Text="Apply Filter" />
        <asp:Button ID="btnFilterClear" runat="server" OnClick="btnFilterClear_Click" style="margin-left: 69px" Text="Clear Filter" />
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
