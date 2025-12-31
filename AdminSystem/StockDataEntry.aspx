<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 35px; top: 26px; position: absolute" Text="Stock ID" width="93px"></asp:Label>
            <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 147px; top: 25px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 35px; top: 66px; position: absolute" Text="Item Name" width="93px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 147px; top: 66px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 35px; top: 108px; position: absolute" Text="Quantity" width="93px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 147px; top: 108px; position: absolute; margin-bottom: 0px"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 35px; top: 150px; position: absolute; margin-bottom: 3px" Text="Price" width="93px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 147px; top: 151px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblArrivedOn" runat="server" style="z-index: 1; left: 35px; top: 199px; position: absolute" Text="Arrived On" width="93px"></asp:Label>
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 35px; top: 245px; position: absolute" Text="Supplier ID"></asp:Label>
        </p>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 147px; top: 245px; position: absolute; margin-bottom: 1px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtArrivedOn" runat="server" style="z-index: 1; left: 147px; top: 199px; position: absolute; margin-bottom: 3px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 147px; top: 298px; position: absolute" Text="Available" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 332px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 380px; position: absolute; " Text="OK" width="77px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 160px; top: 379px; position: absolute; height: 29px; right: 1273px;" Text="Cancel" width="77px" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturnToMenu" runat="server" OnClick="btnReturnToMenu_Click" style="z-index: 1; top: 380px; position: absolute; left: 252px" Text="Return to Main Menu" />
        </p>
        <p style="margin-bottom: 0px">
            &nbsp;</p>
        <p style="margin-bottom: 0px">
            <asp:Button ID="btnFind" runat="server" height="29px" OnClick="btnFind_Click" style="z-index: 1; left: 339px; top: 23px; position: absolute" Text="Find" width="77px" />
        </p>
    </form>
</body>
</html>
