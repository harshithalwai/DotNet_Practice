<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="App_7.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TextBox Demo</title>

    <style>
        body {
            font-family: Segoe UI;
            background: #f4f6f9;
        }

        .container {
            width: 900px;
            margin: auto;
            background: white;
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0px 0px 10px gray;
        }

        h2 {
            color: #1e88e5;
        }

        .box {
            margin-bottom: 20px;
        }

        .label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .textbox {
            width: 300px;
            padding: 10px;
            border-radius: 8px;
            border: 1px solid gray;
        }

        .result {
            color: green;
            font-size: 18px;
        }
    </style>

</head>
<body>

    <form id="form1" runat="server">

        <div class="container">

            <h2>ASP.NET TextBox Complete Demo</h2>

            <!-- Normal TextBox -->
            <div class="box">
                <span class="label">Name</span>

                <asp:TextBox
                    ID="txtName"
                    runat="server"
                    CssClass="textbox"
                    Text="Harshit">
                </asp:TextBox>
            </div>


            <!-- Password -->
            <div class="box">
                <span class="label">Password</span>

                <asp:TextBox
                    ID="txtPassword"
                    runat="server"
                    CssClass="textbox"
                    TextMode="Password">
                </asp:TextBox>

            </div>


            <!-- MultiLine -->
            <div class="box">
                <span class="label">Address</span>

                <asp:TextBox
                    ID="txtAddress"
                    runat="server"
                    CssClass="textbox"
                    TextMode="MultiLine"
                    Rows="4"
                    Columns="40">
                </asp:TextBox>

            </div>


            <!-- ReadOnly -->
            <div class="box">

                <span class="label">Employee ID (ReadOnly)</span>

                <asp:TextBox
                    ID="txtEmpId"
                    runat="server"
                    CssClass="textbox"
                    ReadOnly="true"
                    Text="EMP1001">
                </asp:TextBox>

            </div>


            <!-- Disabled -->
            <div class="box">

                <span class="label">Disabled TextBox</span>

                <asp:TextBox
                    ID="txtDisabled"
                    runat="server"
                    CssClass="textbox"
                    Enabled="false"
                    Text="Cannot edit">
                </asp:TextBox>

            </div>


            <!-- MaxLength -->
            <div class="box">

                <span class="label">Mobile Number</span>

                <asp:TextBox
                    ID="txtMobile"
                    runat="server"
                    CssClass="textbox"
                    MaxLength="10">
                </asp:TextBox>

            </div>


            <!-- AutoPostBack -->
            <div class="box">

                <span class="label">City (AutoPostBack)</span>

                <asp:TextBox
                    ID="txtCity"
                    runat="server"
                    CssClass="textbox"
                    AutoPostBack="true"
                    OnTextChanged="txtCity_TextChanged">
                </asp:TextBox>

            </div>


            <!-- Date -->
            <div class="box">

                <span class="label">Date</span>

                <asp:TextBox
                    ID="txtDate"
                    runat="server"
                    CssClass="textbox"
                    TextMode="Date">
                </asp:TextBox>

            </div>


            <!-- Email -->
            <div class="box">

                <span class="label">Email</span>

                <asp:TextBox
                    ID="txtEmail"
                    runat="server"
                    CssClass="textbox"
                    TextMode="Email">
                </asp:TextBox>

            </div>


            <!-- Number -->
            <div class="box">

                <span class="label">Age</span>

                <asp:TextBox
                    ID="txtAge"
                    runat="server"
                    CssClass="textbox"
                    TextMode="Number">
                </asp:TextBox>

            </div>


            <!-- Search -->
            <div class="box">

                <span class="label">Search</span>

                <asp:TextBox
                    ID="txtSearch"
                    runat="server"
                    CssClass="textbox"
                    TextMode="Search">
                </asp:TextBox>

            </div>


            <!-- Color -->
            <div class="box">

                <span class="label">Favorite Color</span>

                <asp:TextBox
                    ID="txtColor"
                    runat="server"
                    TextMode="Color">
                </asp:TextBox>

            </div>


            <!-- Range -->
            <div class="box">

                <span class="label">Volume</span>

                <asp:TextBox
                    ID="txtRange"
                    runat="server"
                    TextMode="Range">
                </asp:TextBox>

            </div>


            <!-- Button -->
            <div class="box">

                <asp:Button
                    ID="Button1"
                    runat="server"
                    Text="Show Data"
                    OnClick="Button1_Click" />

            </div>


            <div class="box">

                <asp:Label
                    ID="lblResult"
                    runat="server"
                    CssClass="result">
                </asp:Label>

            </div>

        </div>

    </form>

</body>
</html>
