<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App_4.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Todo Manager</title>

    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', Tahoma;
            background: linear-gradient(135deg,#4facfe,#00f2fe);
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .card {
            width: 472px;
            background: white;
            border-radius: 12px;
            padding: 30px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.2);
            height: 432px;
        }

        .title {
            text-align: center;
            font-size: 26px;
            font-weight: 600;
            margin-bottom: 6px;
            color: #333;
        }

        .label {
            text-align: center;
            border-radius: 12px;
            color: orangered;
            margin-bottom: 12px;
            padding: 6px;
            transition: opacity 0.5s ease;
        }

        .input-row {
            display: flex;
            gap: 10px;
        }

        .textbox {
            flex: 1;
            padding: 10px;
            border-radius: 6px;
            border: 1px solid #ccc;
            font-size: 14px;
        }

        .btn {
            padding: 10px 14px;
            border: none;
            border-radius: 6px;
            color: white;
            cursor: pointer;
            font-weight: 500;
        }

        .add {
            background: #28a745;
        }

        .add:hover {
            background: #1e7e34;
        }

        .buttons {
            margin-top: 18px;
            display: grid;
            grid-template-columns: repeat(5,1fr);
            gap: 8px;
        }

        .edit {
            background: #007bff;
        }

        .delete {
            background: #dc3545;
        }

        .clear {
            background: #6c757d;
        }

        .show {
            background: #17a2b8;
        }

        .down {
            background: #ff9800;
        }

        .edit:hover {
            background: #0056b3;
        }

        .delete:hover {
            background: #b02a37;
        }

        .clear:hover {
            background: #545b62;
        }

        .show:hover {
            background: #117a8b;
        }

        .down:hover {
            background: #e68900;
        }

        .listbox {
            margin-top: 20px;
            width: 100%;
            height: 200px;
            border-radius: 6px;
            border: 1px solid #ccc;
            padding: 5px;
            font-size: 14px;
        }
    </style>

</head>

<body>

    <form id="form1" runat="server">

        <div class="card">

            <div class="title">
                Todo Manager
            </div>
            <div class="label">
                <asp:Label ID="label1" runat="server" Text=""></asp:Label>
            </div>

            <div class="input-row">

                <asp:TextBox
                    ID="txtTask"
                    runat="server"
                    CssClass="textbox"
                    placeholder="Enter your task here">
                </asp:TextBox>

                <asp:Button
                    ID="btnAdd"
                    runat="server"
                    OnClick="BtnAdd_Click"
                    Text="Add"
                    CssClass="btn add" />

            </div>

            <div class="buttons">

                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn edit" OnClick="BtnEdit_Click" />

                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn delete" OnClick="BtnDelete_Click" />

                <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn clear" OnClick="BtnClear_Click" />

                <asp:Button ID="btnShow" runat="server" Text="Show" CssClass="btn show" OnClick="BtnShow_Click" />


            </div>

            <asp:ListBox
                ID="lstTasks"
                runat="server"
                CssClass="listbox">

                <asp:ListItem Text="Buy groceries" Value="1"></asp:ListItem>
                <asp:ListItem Text="Study ASP.NET" Value="2"></asp:ListItem>
                <asp:ListItem Text="Go to gym" Value="3"></asp:ListItem>

            </asp:ListBox>

        </div>

    </form>

</body>
</html>
