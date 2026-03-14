<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="App_3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>

<body style="margin: 0; font-family: Segoe UI,Arial; background: linear-gradient(135deg,#5f9cff,#7ed6df); height: 100vh;">

    <form id="form1" runat="server">

        <div style="width: 380px; margin: 100px auto; background: white; border-radius: 12px; box-shadow: 0 10px 30px rgba(0,0,0,0.2); overflow: hidden;">

            <!-- Top Header Bar -->

            <div style="background: #4A6CF7; padding: 18px; text-align: center; color: white; font-size: 20px; font-weight: 600;">
                User Login
            </div>


            <div style="padding: 30px;">


                <!-- Username -->

                <div style="margin-bottom: 18px;">
                    <label style="font-weight: 600; color: #333;">Username</label><br />

                    <asp:TextBox
                        ID="txtUser"
                        runat="server"
                        Width="100%"
                        Height="18px"
                        Style="padding: 8px; border-radius: 6px; border: 1px solid #d1d5db; margin-top: 6px; font-size: 14px;">
                    </asp:TextBox>

                </div>


                <!-- Email -->

                <div style="margin-bottom: 18px;">
                    <label style="font-weight: 600; color: #333;">Email</label><br />

                    <asp:TextBox
                        ID="txtEmail"
                        runat="server"
                        TextMode="Email"
                        Width="100%"
                        Height="18px"
                        Style="padding: 8px; border-radius: 6px; border: 1px solid #d1d5db; margin-top: 6px; font-size: 14px;">
                    </asp:TextBox>

                </div>


                <!-- Password -->

                <div style="margin-bottom: 10px;">
                    <label style="font-weight: 600; color: #333;">Password</label><br />

                    <asp:TextBox
                        ID="txtPass"
                        runat="server"
                        TextMode="Password"
                        Width="100%"
                        Height="18px"
                        Style="padding: 8px; border-radius: 6px; border: 1px solid #d1d5db; margin-top: 6px; font-size: 14px;">
                    </asp:TextBox>

                </div>


                <!-- Forgot password -->

                <div style="text-align: right; margin-bottom: 20px; font-size: 13px;">
                    <a href="#" style="color: #4A6CF7; text-decoration: none;">Forgot Password?
                    </a>
                </div>


                <!-- Login Button -->

                <div style="text-align: center;">

                    <asp:Button
                        ID="btnLogin"
                        PostBackUrl="~/Respond.aspx"
                        runat="server"
                        Text="Login"
                        Width="100%"
                        Height="40px"
                        BackColor="#4A6CF7"
                        ForeColor="White"
                        Style="border: none; border-radius: 6px; font-size: 15px; font-weight: 600; cursor: pointer;" />
                </div>
                <div style="text-align: center;">

                    <asp:Button
                        ID="btnReset"
                        OnClick="btnReset_Click"
                        runat="server"
                        Text="Reset"
                        Width="100%"
                        Height="40px"
                        BackColor="#4A6CF7"
                        ForeColor="White"
                        Style="border: none; border-radius: 6px; font-size: 15px; font-weight: 600; cursor: pointer; margin-top: 10px" />
                </div>


                <br />

                <div style="text-align: center; font-size: 13px; color: #666;">
                    Don't have an account?
                    <a href="#" style="color: #4A6CF7; text-decoration: none;">Register</a>
                </div>


                <br />

                <div style="text-align: center;">
                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                </div>


            </div>

        </div>

    </form>

</body>
</html>
