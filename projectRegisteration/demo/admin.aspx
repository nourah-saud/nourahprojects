
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"  EnableEventValidation="false" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="projectRegisteration.demo.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
</p>

<p>


    <asp:Label ID="Label2" runat="server" Text="Grade"></asp:Label>

    <asp:TextBox ID="tbGrade" runat="server" Width="83px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblOutput" runat="server"></asp:Label>
</p>

<p>
   
  <!--  <asp:Button ID="btnSave" runat="server" Text="Save" Width="60px" OnClick="btnSave_Click" /> -->

    <asp:Button ID="btnClear" runat="server" Text="Clear" Width="60px" OnClick="btnClear_Click "/>

    <asp:Button ID="btnExport" runat="server" Text="Export" Width="60px" OnClick="btnExport_Click" />

&nbsp;&nbsp;
  <!--  <asp:Button ID="btnUpdate" runat="server" Text="Update"   /> -->

</p>
<p>
  </p>
    <p>
  </p>
    <p>
  </p>
    <p>
     <%--   <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete"
                            OnClientClick="return confirm('Are you sure? want to delete the department.');"
                            OnClick="btnDelete2_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblStudentId" runat="server" Text='<%#Eval("studentId") %>' Visible="true"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblStudentFullName" runat="server" Text='<%#Eval("studentFullName") %>' Visible="true"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                
                
                				
                                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblStudentSite" runat="server" Text='<%#Eval("studentSite") %>' Visible="true"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblGrade" runat="server" Text='<%#Eval("grade") %>' Visible="true"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblProjectId" runat="server"  Text='<%#Eval("projectId") %>' Visible="true"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>--%>
     <%--   <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource> --%>

  </p>
     <input type="hidden" runat="server" id="hidStudentID" />
    <br />
    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" DataKeyNames="studentId" >
        <Columns>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete Grade"
                    
                        OnClick="btnDelete2_Click" />
                </ItemTemplate>
                                </asp:TemplateField>
            <asp:TemplateField HeaderText="studentId" InsertVisible="False" SortExpression="studentId">
                <ItemTemplate>
                    <asp:Label ID="lblStudentId" runat="server" Text='<%# Bind("studentId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="studentFullName" SortExpression="studentFullName">
                <ItemTemplate>
                    <asp:Label ID="lblStudentFullName" runat="server" Text='<%# Bind("studentFullName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="studentSite" SortExpression="studentSite">
                <ItemTemplate>
                    <asp:Label ID="lblStudentSite" runat="server" Text='<%# Bind("studentSite") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="grade" SortExpression="grade">
                <ItemTemplate>
                    <asp:Label ID="lblGrade" runat="server" Text='<%# Bind("grade") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="projectId" SortExpression="projectId">
                <ItemTemplate>
                    <asp:Label ID="lblProjectId" runat="server" Text='<%# Bind("projectId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


</asp:Content>
