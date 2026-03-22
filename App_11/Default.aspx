<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App_11.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Form</title>

    <style>
        body {
            font-family: Segoe UI, Arial;
            background: #f5f6fa;
        }

        .card {
            width: 650px;
            margin: 40px auto;
            background: white;
            padding: 25px 35px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }

        .title {
            text-align: center;
            font-size: 22px;
            font-weight: 600;
            margin-bottom: 20px;
            color: #2c3e50;
        }

        .grid {
            display: grid;
            grid-template-columns: 150px 1fr;
            row-gap: 12px;
            column-gap: 10px;
            align-items: center;
        }

        .grid label {
            font-weight: 600;
            color: #444;
        }

        .textbox {
            padding: 6px 8px;
            border-radius: 5px;
            border: 1px solid #ccc;
            width: 100%;
        }

        .btn {
            margin-top: 20px;
            background: #0078d4;
            color: white;
            border: none;
            padding: 10px 18px;
            border-radius: 6px;
            cursor: pointer;
            font-weight: 600;
        }

        .btn:hover {
            background: #005fa3;
        }

        .msg {
            margin-top: 15px;
            font-weight: 600;
        }
    </style>

</head>
<body>
<form id="form1" runat="server">

    <div class="card">

        <div class="title">Employee Entry Form</div>

        <div class="grid">

            <label>Employee ID</label>
            <asp:TextBox ID="txtEmployeeId" CssClass="textbox" runat="server" />

            <label>First Name</label>
            <asp:TextBox ID="txtFirstName" CssClass="textbox" runat="server" />

            <label>Last Name</label>
            <asp:TextBox ID="txtLastName" CssClass="textbox" runat="server" />

            <label>Email</label>
            <asp:TextBox ID="txtEmail" CssClass="textbox" runat="server" />

            <label>Phone Number</label>
            <asp:TextBox ID="txtPhone" CssClass="textbox" runat="server" />

            <label>Hire Date</label>
            <asp:TextBox ID="txtHireDate" CssClass="textbox" TextMode="Date" runat="server" />

            <label>Job ID</label>
            <asp:TextBox ID="txtJobId" CssClass="textbox" runat="server" />

            <label>Salary</label>
            <asp:TextBox ID="txtSalary" CssClass="textbox" runat="server" />

            <label>Commission %</label>
            <asp:TextBox ID="txtCommission" CssClass="textbox" runat="server" />

            <label>Manager ID</label>
            <asp:TextBox ID="txtManagerId" TextMode="Number" CssClass="textbox" runat="server" />

            <label>Department ID</label>
            <asp:TextBox ID="txtDepartmentId" CssClass="textbox" runat="server" />

        </div>

        <asp:Button ID="btnSave" runat="server" Text="Save Employee" CssClass="btn" OnClick="btnSave_Click" />

        <br />

        <asp:Label ID="lblMessage" runat="server" CssClass="msg" ForeColor="Green" />

    </div>

</form>
</body>
</html>