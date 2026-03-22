<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App_14.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Form</title>
    <style>
        .row {
            margin: 6px;
        }

        label {
            width: 120px;
            display: inline-block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <div class="row">
                <label>Student ID</label>
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Load" OnClick="Button1_Click" />
            </div>

            <div class="row">
                <label>Name</label>
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            </div>

            <div class="row">
                <label>Gender</label>
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="row">
                <label>Total Marks</label>
                <asp:TextBox ID="txtTotalMarks" runat="server"></asp:TextBox>
            </div>

            <div class="row">
                <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
            </div>

            <div class="row">
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </div>

        </div>

    </form>
</body>
</html>
