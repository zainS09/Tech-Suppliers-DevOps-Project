<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="height: 453px">
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 16px; top: 29px; position: absolute; height: 19px; width: 121px; bottom: 627px" Text="Supplier ID"></asp:Label>
        </div>
        <asp:TextBox ID="txtSupplierID" runat="server" height="22px" style="z-index: 1; left: 172px; top: 27px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierContact" runat="server" height="19px" style="z-index: 1; left: 16px; top: 72px; position: absolute" Text="Supplier Contact" width="121px"></asp:Label>
        <asp:TextBox ID="txtSupplierContact" runat="server" height="22px" style="z-index: 1; left: 171px; position: absolute; top: 70px" width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 352px; top: 23px; position: absolute; height: 31px; width: 87px;" Text="Find" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPriceOfResource" runat="server" height="19px" style="z-index: 1; left: 16px; top: 117px; position: absolute" Text="Price Of Resource" width="121px"></asp:Label>
        <asp:Label ID="lblDateRequested" runat="server" style="z-index: 1; left: 16px; top: 166px; position: absolute; height: 19px; width: 121px" Text="Date Requested"></asp:Label>
        <asp:TextBox ID="txtDateRequested" runat="server" height="22px" style="z-index: 1; left: 173px; top: 163px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtPriceOfResource" runat="server" height="22px" style="z-index: 1; top: 117px; position: absolute; left: 170px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailabilityOfSupplier" runat="server" style="z-index: 1; left: 168px; top: 270px; position: absolute" Text="Availability Of Supplier" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 27px; top: 358px; position: absolute; width: 87px" Text="OK" height="31px" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 306px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 157px; top: 357px; position: absolute" Text="Cancel" height="31px" width="87px" OnClick="btnCancel_Click" />
            <asp:Label ID="lblToBeDeliveredBy" runat="server" style="z-index: 1; left: 16px; top: 220px; position: absolute" Text="To Be Delivered By"></asp:Label>
            <asp:TextBox ID="txtToBeDeliveredBy" runat="server" height="22px" style="z-index: 1; left: 173px; position: absolute; top: 216px" width="128px"></asp:TextBox>
            <asp:Button ID="btnReturn" runat="server" height="31px" OnClick="btnReturn_Click" style="z-index: 1; left: 299px; top: 356px; position: absolute; width: 153px" Text="Return to Main Menu" />
        </div>
    </form>
</body>
</html>
