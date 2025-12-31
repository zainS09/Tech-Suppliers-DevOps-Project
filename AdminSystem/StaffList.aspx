<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
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
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 400px;
        }
        .form-group {
            margin-bottom: 15px;
            text-align: center;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
        input[type="text"], input[type="number"], input[type="email"], input[type="date"], .form-control {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 8px;
            border-radius: 4px;
            box-sizing: border-box;
        }
        input[type="submit"], input[type="button"], button {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-color: #1abc9c;
            color: white;
            padding: 10px;
            text-transform: uppercase;
            border-radius: 4px;
            cursor: pointer;
            box-shadow: 0 2px 4px rgba(0,0,0,0.2);
            transition: background 0.3s ease;
            margin: 5px 1%;
        }
        input[type="submit"]:hover, input[type="button"]:hover, button:hover {
            background-color: #16a085;
        }
        .checkbox {
            margin: 5px 0 15px 0;
            position: relative;
            line-height: 1;
            text-align: center;
        }
        .checkbox input[type="checkbox"] {
            margin-right: 5px;
        }
        .error-label {
            color: red;
            font-weight: bold;
            margin-top: 15px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <asp:ListBox ID="lstStaffList" runat="server" Height="316px" Width="364px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnAdd" runat="server" Height="35px" OnClick="btnAdd_Click" Text="Add" Width="80px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="36px" Width="81px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Height="36px" Width="74px" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblStatement" runat="server" Text="Enter the staff role"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="29px" Width="340px"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <asp:Button ID="btnReturn" runat="server" Text="Return to Main Menu" Width="180px" OnClick="btnReturn_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" CssClass="error-label" Width="413px" Height="31px"></asp:Label>
        </div>
    </form>
</body>
</html>
