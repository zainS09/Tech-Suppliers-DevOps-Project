<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tech Supplier Main Menu</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #2c3e50;
            color: #ecf0f1;
            margin: 0;
            padding: 20px;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        form {
            background-color: #34495e;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 6px 12px rgba(0,0,0,0.2);
            width: 360px;
            text-align: center;
        }
        .form-group {
            margin-bottom: 20px;
        }
        label {
            display: block;
            margin-bottom: 20px;
            font-size: 24px;
            font-weight: bold;
        }
        input[type="submit"], input[type="button"], button {
            background-color: #1abc9c;
            color: white;
            border: none;
            padding: 12px 20px;
            text-transform: uppercase;
            border-radius: 4px;
            cursor: pointer;
            width: 100%;
            box-shadow: 0 3px 6px rgba(0,0,0,0.2);
            transition: background 0.3s ease;
            margin: 10px 0;
        }
        input[type="submit"]:hover, input[type="button"]:hover, button:hover {
            background-color: #16a085;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <asp:Label ID="lblWarning" runat="server" Text="Tech Supplier Main Menu"></asp:Label>
        </div>
        <div class="form-group">
            <asp:Button ID="btnCustomerData" runat="server" OnClick="btnCustomer_Click" Text="Customer Management" />
        </div>
        <div class="form-group">
            <asp:Button ID="btnStaffData" runat="server" OnClick="btnStaff_Click" Text="Staff Management" />
        </div>
        <div class="form-group">
            <asp:Button ID="btnStockrData" runat="server" OnClick="btnStock_Click" Text="Stock Management" />
        </div>
        <div class="form-group">
            <asp:Button ID="btnSupplierData" runat="server" OnClick="btnSupplier_Click" Text="Supplier Management" />
        </div>
        <div class="form-group">
            <asp:Button ID="btnOrderData" runat="server" OnClick="btnOrder_Click" Text="Order Management" />
        </div>
    </form>
</body>
</html>
