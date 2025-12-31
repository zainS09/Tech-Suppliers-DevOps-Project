<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListOfCustomers.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f2f2f2;
            align-content: center;
        }
        .container {
            width: 100%;
            margin: 25px auto;
            background-color: #fff;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .btn {
            padding: 10px 20px;
            border-radius: 6px;
            border: none;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
            margin-right: 12px;
        }
        .btn:hover {
            background-color: #0056b3;
        }
        .input-group {
            margin-bottom: 25px;
        }
        .input-label {
            display: block;
            margin-bottom: 10px;
        }
        .input-text {
            width: 100%;
            padding: 10px;
            border-radius: 8px;
            border: 2px solid #ccc;
        }
    </style>
</head>
<body>
   <form id="form2" runat="server" class="container">
    <div>
    </div>
    <asp:ListBox ID="lstCustomerList" runat="server" CssClass="input-text" Height="316px" Width="364px"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnAdd" runat="server" CssClass="btn" OnClick="btnAdd_Click" Text="Add" />
    <asp:Button ID="btnEdit" runat="server" CssClass="btn" OnClick="btnEdit_Click" Text="Edit" />
    <asp:Button ID="btnDelete" runat="server" CssClass="btn" OnClick="btnDelete_Click" Text="Delete" />
    <br />
    <br />
    <div class="input-group">
        <asp:Label ID="lblStatement" runat="server" CssClass="input-label" Text="Enter the FullName"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" CssClass="input-text" Height="18px" Width="340px"></asp:TextBox>
    </div>
    <br />
    <asp:Button ID="btnApply" runat="server" CssClass="btn" OnClick="btnApply_Click" Text="Apply" />
    <asp:Button ID="btnClear" runat="server" CssClass="btn" OnClick="btnClear_Click" Text="Clear" />
    <asp:Button ID="btnReturn" runat="server" CssClass="btn" Text="Return to Main Menu" />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Width="420px"></asp:Label>
    </form>
</body>
</html>
