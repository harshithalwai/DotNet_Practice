<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxSample.aspx.cs" Inherits="App_2.AjaxSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <div style="width: 350px; margin: 100px auto; background: white; padding: 30px; border-radius: 10px; box-shadow: 0 0 10px rgba(0,0,0,0.2);">

                    <h2 style="text-align: center; margin-bottom: 20px;">Simple Calculator</h2>

                    <div style="margin-bottom: 15px;">
                        <asp:Label ID="Label1" runat="server" Text="Number 1"
                            Style="display: block; margin-bottom: 5px; font-weight: bold;"></asp:Label>

                        <asp:TextBox ID="num1" runat="server"
                            Style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 5px;"></asp:TextBox>
                    </div>

                    <div style="margin-bottom: 15px;">
                        <asp:Label ID="Label2" runat="server" Text="Number 2"
                            Style="display: block; margin-bottom: 5px; font-weight: bold;"></asp:Label>

                        <asp:TextBox ID="num2" runat="server"
                            Style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 5px;"></asp:TextBox>
                    </div>

                    <div style="margin-bottom: 20px;">
                        <asp:Label ID="resultlab" runat="server" Text="Result"
                            Style="display: block; margin-bottom: 5px; font-weight: bold;"></asp:Label>

                        <asp:TextBox ID="res" runat="server"
                            Style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 5px;"></asp:TextBox>
                    </div>

                    <div style="display: flex; justify-content: space-between;">
                        <asp:Button ID="add" runat="server" Text="+"
                            Style="width: 70px; padding: 10px; background: #4CAF50; color: white; border: none; border-radius: 5px;"
                            CommandName="+" OnCommand="btn_command" />

                        <asp:Button ID="sub" runat="server" Text="-"
                            Style="width: 70px; padding: 10px; background: #f44336; color: white; border: none; border-radius: 5px;"
                            CommandName="-" OnCommand="btn_command" />

                        <asp:Button ID="mul" runat="server" Text="×"
                            Style="width: 70px; padding: 10px; background: #2196F3; color: white; border: none; border-radius: 5px;"
                            CommandName="*" OnCommand="btn_command" />

                        <asp:Button ID="div" runat="server" Text="÷"
                            Style="width: 70px; padding: 10px; background: #ff9800; color: white; border: none; border-radius: 5px;"
                            CommandName="/" OnCommand="btn_command" />
                    </div>

                </div>

            </ContentTemplate>
        </asp:UpdatePanel>
    </form>

</body>
</html>
