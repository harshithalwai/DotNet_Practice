<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App_7.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="one" runat="server" style="width: 100vw; height: 100vh;">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Color"
                AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>

    </form>
</body>
</html>
