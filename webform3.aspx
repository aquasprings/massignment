<%@ Page Title="" Language="C#" MasterPageFile="~/BankManagementWelcomPage.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="BankManagement.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" >
        <Columns>
            <asp:TemplateField HeaderText="remove">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" CommandArgument='<%#Eval("cusID") %>' runat="server">remove</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
<p>
</p>
</asp:Content>
