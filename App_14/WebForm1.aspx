<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="App_14.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar Demo</title>

    <style>

        body{
            font-family:Segoe UI;
            background:#f5f5f5;
        }

        .container{

            width:450px;
            margin:40px auto;
            padding:20px;
            background:white;
            border-radius:10px;
            box-shadow:0 0 10px lightgray;

        }

        .dateBox{

            display:flex;
            align-items:center;
            gap:10px;

        }

        .calendar{

            margin-top:10px;
        }

        .info{

            margin-top:20px;
            background:#eef6ff;
            padding:10px;
            border-radius:5px;

        }

    </style>

</head>
<body>

<form id="form1" runat="server">

<div class="container">

<h2>Select Date</h2>

<div class="dateBox">

    <asp:TextBox
        ID="TextBox1"
        runat="server"
        Width="250"
        ReadOnly="true">
    </asp:TextBox>

    <asp:ImageButton
        ID="ImageButton1"
        runat="server"
        Width="32"
        Height="32"
        ImageUrl="~/Images/calendar.png"
        OnClick="ImageButton1_Click" />

</div>

<div class="calendar">

<asp:Calendar

    ID="Calendar1"
    runat="server"

    Visible="false"
    
    OnDayRender="Calendar1_DayRender"

    OnSelectionChanged="Calendar1_SelectionChanged"

    BackColor="White"
    BorderColor="#999999"
    CellPadding="5"
    DayNameFormat="Shortest"
    Font-Names="Segoe UI"
    Font-Size="10pt"

    NextPrevFormat="FullMonth"

    TitleStyle-BackColor="#0078D7"
    TitleStyle-ForeColor="White"

    TodayDayStyle-BackColor="Yellow"

    SelectedDayStyle-BackColor="#0078D7"
    SelectedDayStyle-ForeColor="White"

    WeekendDayStyle-BackColor="#F9E79F">

</asp:Calendar>

</div>

<div class="info">

<asp:Label
ID="Label1"
runat="server">
</asp:Label>

</div>

</div>

</form>

</body>
</html>