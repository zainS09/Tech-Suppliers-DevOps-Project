<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Management Login Page</title>
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
            margin-bottom: 10px;
            font-weight: bold;
        }
        input[type="text"], input[type="password"] {
            width: calc(100% - 16px);
            padding: 10px;
            border: 1px solid #1abc9c;
            border-radius: 4px;
            box-sizing: border-box;
            background-color: #ecf0f1;
            color: #2c3e50;
        }
        input[type="submit"], input[type="button"], button {
            background-color: #1abc9c;
            color: white;
            border: none;
            padding: 12px 20px;
            text-transform: uppercase;
            border-radius: 4px;
            cursor: pointer;
            width: calc(50% - 10px);
            box-shadow: 0 3px 6px rgba(0,0,0,0.2);
            transition: background 0.3s ease;
            margin: 10px 5px;
        }
        input[type="submit"]:hover, input[type="button"]:hover, button:hover {
            background-color: #16a085;
        }
        .error-label {
            color: #e74c3c;
            font-weight: bold;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <asp:Label ID="lblUserName" runat="server" Text="UserName: " Width="65px"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" Width="330px" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPassword" runat="server" Text="Password: " Width="65px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Width="330px" TextMode="Password"></asp:TextBox>  
        </div>
        <div class="form-group">
            <asp:Button ID="btnLogin" runat="server" Height="35px" OnClick="btnLogin_Click" Text="Login" Width="80px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Height="36px" Width="81px" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" Width="370px" ForeColor="#FF3300"></asp:Label>
        </div>
    </form>
</body>
</html>
