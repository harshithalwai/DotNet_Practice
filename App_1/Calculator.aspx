<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="App_1.Calculator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>

<body style="margin:0; padding:0; font-family:Arial; background-color:#f4f6f9;">

    <form id="form1" runat="server">

        <div style="width:350px; margin:100px auto; background:white; padding:30px; border-radius:10px; box-shadow:0 0 10px rgba(0,0,0,0.2);">

            <h2 style="text-align:center; margin-bottom:20px;">Simple Calculator</h2>

            <div style="margin-bottom:15px;">
                <asp:Label ID="Label1" runat="server" Text="Number 1"
                    style="display:block; margin-bottom:5px; font-weight:bold;"></asp:Label>

                <asp:TextBox ID="num1" runat="server"
                    style="width:100%; padding:8px; border:1px solid #ccc; border-radius:5px;"></asp:TextBox>
            </div>

            <div style="margin-bottom:15px;">
                <asp:Label ID="Label2" runat="server" Text="Number 2"
                    style="display:block; margin-bottom:5px; font-weight:bold;"></asp:Label>

                <asp:TextBox ID="num2" runat="server"
                    style="width:100%; padding:8px; border:1px solid #ccc; border-radius:5px;"></asp:TextBox>
            </div>

            <div style="margin-bottom:20px;">
                <asp:Label ID="resultlab" runat="server" Text="Result"
                    style="display:block; margin-bottom:5px; font-weight:bold;"></asp:Label>

                <asp:TextBox ID="res" runat="server"
                    style="width:100%; padding:8px; border:1px solid #ccc; border-radius:5px;"></asp:TextBox>
            </div>

            <div style="display:flex; justify-content:space-between;">
                <asp:Button ID="add" runat="server" Text="+"
                    style="width:70px; padding:10px; background:#4CAF50; color:white; border:none; border-radius:5px;"
                    OnClick="btn_Click" />

                <asp:Button ID="sub" runat="server" Text="-"
                    style="width:70px; padding:10px; background:#f44336; color:white; border:none; border-radius:5px;"
                    OnClick="btn_Click" />

                <asp:Button ID="mul" runat="server" Text="×"
                    style="width:70px; padding:10px; background:#2196F3; color:white; border:none; border-radius:5px;"
                    OnClick="btn_Click" />

                <asp:Button ID="div" runat="server" Text="÷"
                    style="width:70px; padding:10px; background:#ff9800; color:white; border:none; border-radius:5px;"
                    OnClick="btn_Click" />
            </div>

        </div>

    </form>

</body>
</html>