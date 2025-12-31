<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #2c3e50;
            color: #333;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        form {
            background-color: #2c3e50;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 300px;
            text-align: center;
        }
        .button {
            margin: 10px;
            padding: 10px 20px;
            background-color: #1abc9c;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-transform: uppercase;
            box-shadow: 0 2px 4px rgba(0,0,0,0.2);
        }
        .button:hover {
            background-color: #16a085;
        }
        .button-secondary {
            background-color: #e74c3c;
        }
        .button-secondary:hover {
            background-color: #c0392b;
        }
        h2 {
            color: #ffffff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Are you sure you want to delete this record?</h2>
            <asp:Button ID="btnYes" runat="server" Text="Yes" CssClass="button" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="button button-secondary" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
