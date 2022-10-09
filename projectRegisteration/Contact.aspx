<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="projectRegisteration.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <h2> contact</h2>
    <address>
        Saudi Arabia,Riyadh<br />
        <br />
        <abbr title="Phone">Phone:</abbr>
        0502923572
    </address>

    <address>
        <strong>Email:</strong>   <a href="mailto:nourah-saud@hotmail.com">nourah-saud@hotmail.com</a><br />
        <strong>Linkedin:</strong> <a href="https://www.linkedin.com/in/nourah-saud-99250b1b3">https://www.linkedin.com/in/nourah-saud-99250b1b3</a>
    </address>
            <table class="nav-justified">
            <tr>
                <td colspan="2">
                 
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td style="height: 20px; width: 291px">; From</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 291px"> To </td>
                <td>
                    <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 291px; height: 20px"> Subject</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table class="nav-justified">
            <tr>
                <td class="modal-sm" style="width: 291px; height: 20px"> Message</td>
                <td style="height: 20px">
                    <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
   <asp:Button ID="btnSendEmail" runat="server" Text="send Email" Width="116px" OnClick="btnRegistration_Click" />
 


       
</asp:Content>
