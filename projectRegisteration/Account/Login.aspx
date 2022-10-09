<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="projectRegisteration.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
    <br /> <br />
        <table class="style1">
          <!--  <tr><td colspan="2">username = ali   & password = ali</td></tr> -->
           <tr>
                <td class="style2">
                    <strong>Login</strong></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    User Name :&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
  
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password&nbsp;&nbsp; :&nbsp;&nbsp; </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
                        Text="Login" />
<%--                    <asp:Button ID="btnCreateAdmin" runat="server" OnClick="btnCreateAdmin_Click" Text="Admin" Visible="False" />--%>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>


</asp:Content>
