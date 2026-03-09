<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="App_6.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Qualification List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Select Qualification</h2>

            <asp:DropDownList 
                ID="ddlQualification" 
                runat="server" 
                Width="200px">
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>