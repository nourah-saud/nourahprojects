<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="myProject.aspx.cs" Inherits="projectRegisteration.demo.myProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
   
    <br />
    <asp:Label ID="lblOutPut" runat="server"></asp:Label>
    <br />
<table>
   <tr>
        <td id="table">
           <asp:Label ID="lblName" runat="server" Text="Name :"></asp:Label>
    
           <asp:TextBox ID="tbName" runat="server" Height="31px" Width="186px"></asp:TextBox>
    
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
           <asp:Label ID="lblSite" runat="server" Text="Intern Site :"></asp:Label>
   
           <asp:TextBox ID="tbSite" runat="server" Height="31px" Width="186px"></asp:TextBox>
       </td>
    </tr>
</table>


   
    <br />
    <asp:RadioButtonList ID="rblProject" runat="server" Height="30px" Width="98px">
    </asp:RadioButtonList>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Height="32px" Text="Submit" Width="128px" OnClick="btnSubmit_Click" />
    <br />
    <br />
   

   
</asp:Content>
    
