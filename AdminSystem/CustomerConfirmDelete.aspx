<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
        }
        .container {
            width: 75%;
            margin: 30px auto;
            background-color: #fff;
            padding: 30px;
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
            margin-right: 14px;
        }
        .btn:hover {
            background-color: #0056b3;
        }
        .message {
            margin-bottom: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="message">
            <asp:Label ID="lblWarning" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" CssClass="btn" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" CssClass="btn" OnClick="btnNo_Click" Text="No" />
    </form>
</body>
</html>
