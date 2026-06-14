<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="App_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        jo value ko submit hone tk waity kre cached events 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <div>
            ASP.NET Server Control Events
            In Part 4, of this video series, we have discussed that, events can occur at 3 levels in an
            asp.net web application.
            1. At the application level (Example-Session_Start event in global.asax)
            2. At the Page or web form level (Example- Page_Load)
            3. At the control level(Example-Selected Index changed event of a dropdownlist)

            ASP.NET server controls, such as TextBox, Button, and DropDownList has their own
            events. We have a set of asp.net validation controls, that has validation events. The
            events that these controls expose, can be broadly divided into 3 categories.

            Postback events - These events submit the Web page, immediately to the server for
            processing. Click event of a button control is an example for PostBack event.

            Cached events-These events are saved in the page's viewstate to be processed when a
            postback event occurs. TextChanged event of TextBox control, and
            SelectedIndexChanged event of a DropDownList control are examples of cached events.
            Cached events can be converted into postback events, by setting the AutoPostBack
            property of the control to true.
            Validation events-These events occur on the client, before the page is posted back to
            the server. All validation controls use these type of events.
        </div>
    </form>
</body>
</html>
