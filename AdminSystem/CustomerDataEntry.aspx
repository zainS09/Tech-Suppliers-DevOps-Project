<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f2f2f2;
        }
        .container {
            width: 80%;
            margin: 25px auto;
            background-color: #fff;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0 0 12px rgba(0, 0, 0, 0.1);
        }
        .form-group {
            margin-bottom: 25px;
        }
        .form-label {
            width: 175px;
            display: inline-block;
            vertical-align: top;
        }
        .form-input {
            width: calc(100% - 170px);
            padding: 10px;
            border-radius: 8px;
            border: 2px solid #ccc;
        }
        .btn {
            padding: 10px 20px;
            border-radius: 6px;
            border: none;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
            margin-right: 15px;
        }
        .btn:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="form-group">

            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" CssClass="form-input" MaxLength="4" TextMode="Number"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" CssClass="btn" OnClick="btnFind_Click" Text="Find" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerName" runat="server" Text="Full Name" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerDateOfBirth" runat="server" Text="Date Of Birth" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCustomerDateOfBirth" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerPassword" runat="server" Text="Password" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCustomerPassword" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerActive" runat="server" Text="Active" CssClass="form-label"></asp:Label>
            <asp:CheckBox ID="chkActive" runat="server" Checked="True" OnCheckedChanged="chkCustomerActive_CheckedChanged" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        <asp:Button ID="btnOk" runat="server" CssClass="btn" OnClick="btnOk_Click" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" CssClass="btn" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnReturn" runat="server" CssClass="btn" Text="Return to Main Menu" />
    </form>
</body>
</html>
