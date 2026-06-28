<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="App_15.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>MultiView Example</title>
</head>
<body>

    <form id="form1" runat="server">

        <asp:Button ID="btnView1"
            runat="server"
            Text="Home"
            OnClick="btnView1_Click" />

        <asp:Button ID="btnView2"
            runat="server"
            Text="Profile"
            OnClick="btnView2_Click" />

        <asp:Button ID="btnView3"
            runat="server"
            Text="Contact"
            OnClick="btnView3_Click" />

        <hr />

        <asp:MultiView
            ID="MultiView1"
            runat="server"
            ActiveViewIndex="0">

            <!-- View 1 -->
            <asp:View ID="View1" runat="server">

                <h2>Home Page</h2>

                <asp:Label
                    ID="Label1"
                    runat="server"
                    Text="Welcome to Home Page." />

            </asp:View>

            <!-- View 2 -->
            <asp:View ID="View2" runat="server">

                <h2>Profile Page</h2>

                <asp:Label
                    ID="Label2"
                    runat="server"
                    Text="This is your profile." />

            </asp:View>

            <!-- View 3 -->
            <asp:View ID="View3" runat="server">

                <h2>Contact Page</h2>

                <asp:Label
                    ID="Label3"
                    runat="server"
                    Text="Contact us at support@example.com" />

            </asp:View>

        </asp:MultiView>

    </form>

</body>
</html>