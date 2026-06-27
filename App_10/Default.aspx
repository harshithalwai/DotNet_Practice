<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="App_10.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Enterprise Excel Import Engine</title>

    <style>

        body
        {
            margin:0;
            padding:25px;
            background:#f5f5f5;
            font-family:Calibri;
        }

        .container
        {
            width:1100px;
            margin:auto;
            background:white;
            padding:25px;
            border-radius:5px;
            box-shadow:0px 0px 10px lightgray;
        }

        .heading
        {
            font-size:28px;
            font-weight:bold;
            margin-bottom:25px;
            color:#1f4e79;
        }

        .button
        {
            background:#0078D4;
            color:white;
            border:none;
            padding:10px 25px;
            cursor:pointer;
            font-size:16px;
        }

        .button:hover
        {
            background:#005a9e;
        }

        .status
        {
            font-weight:bold;
            color:green;
            font-size:16px;
        }

        .grid
        {
            width:100%;
        }

    </style>

</head>

<body>

<form id="form1" runat="server">

<div class="container">

<div class="heading">

Enterprise Excel Import Engine

</div>


<table>

<tr>

<td>

Select Excel File

</td>

<td style="padding-left:20px;">

<asp:FileUpload
    ID="FileUpload1"
    runat="server"/>

</td>

</tr>

<tr>

<td colspan="2">

<br />

<asp:Button

    ID="btnUpload"

    runat="server"

    CssClass="button"

    Text="Import Excel"

    OnClick="btnUpload_Click"/>

</td>

</tr>

<tr>

<td colspan="2">

<br />

<asp:Label

    ID="lblStatus"

    runat="server"

    CssClass="status"/>

</td>

</tr>

<tr>

<td colspan="2">

<br />

<asp:Label

    ID="lblProgress"

    runat="server"

    Font-Bold="true"

    ForeColor="Blue"/>

</td>

</tr>

</table>

<br />

<asp:GridView

    ID="GridView1"

    runat="server"

    CssClass="grid"

    AutoGenerateColumns="true"

    AllowPaging="true"

    PageSize="50">

</asp:GridView>

</div>

</form>

</body>

</html>