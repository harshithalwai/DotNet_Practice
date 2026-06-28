<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="App_14.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wizard Control Example</title>
</head>
<body>

    <form id="form1" runat="server">

        <asp:Wizard
            ID="Wizard1"
            runat="server"
            DisplaySideBar="true"
            OnFinishButtonClick="Wizard1_FinishButtonClick">

            <WizardSteps>

                <asp:WizardStep
                    ID="WizardStep1"
                    runat="server"
                    Title="Personal Details">

                    <h3>Personal Details</h3>

                    <p>
                        Name :
                        <asp:TextBox
                            ID="txtName"
                            runat="server" />
                    </p>

                    <p>
                        Age :
                        <asp:TextBox
                            ID="txtAge"
                            runat="server" />
                    </p>

                </asp:WizardStep>

                <asp:WizardStep
                    ID="WizardStep2"
                    runat="server"
                    Title="Contact Details">

                    <h3>Contact Details</h3>

                    <p>
                        Email :
                        <asp:TextBox
                            ID="txtEmail"
                            runat="server" />
                    </p>

                    <p>
                        Phone :
                        <asp:TextBox
                            ID="txtPhone"
                            runat="server" />
                    </p>

                </asp:WizardStep>

                <asp:WizardStep
                    ID="WizardStep3"
                    runat="server"
                    Title="Confirmation"
                    StepType="Complete">

                    <h3>Registration Successful!</h3>

                    <asp:Label
                        ID="lblMessage"
                        runat="server"
                        Font-Bold="true"
                        Font-Size="Large" />

                </asp:WizardStep>

            </WizardSteps>

        </asp:Wizard>

    </form>

</body>
</html>