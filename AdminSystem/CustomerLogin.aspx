<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tech Suppliers Login Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        #form1 {
            background-color: #78b4ff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 500px;
        }
        h2 {
            text-align: center;
            color: #333;
        }
        .form-group {
            margin-bottom: 20px;
        }
        label {
            display: block;
            font-weight: bold;
            margin-bottom: 10px;
        }
        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
            border: 1.5px solid #ccc;
            border-radius: 4px;
        }
        .button-group {
            text-align: center;
            margin-top: 30px;
        }
        .button-group input {
            padding: 20px 30px;
            border: none;
            border-radius: 6px;
            cursor: pointer;
        }
        .button-group input[type="submit"] {
            background-color: #0300ff;
            color: white;
        }
        .button-group input[type="button"] {
            background-color: #f44336;
            color: white;
        }
        .error-message {
            color: #FF3300;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Tech Suppliers Login</h2>
        <div class="form-group">
            <asp:Label ID="lblUserName" runat="server" Text="UserName: " AssociatedControlID="txtUserName"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPassword" runat="server" Text="Password: " AssociatedControlID="txtPassword"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="button-group">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </div>
        <div class="error-message">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
