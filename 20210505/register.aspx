<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="_20210505.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="user" runat="server"></asp:TextBox>
    <asp:Label ID="userLabel" runat="server"></asp:Label>
    </br>
    <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
    <asp:Label ID="passwdLabel" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </br>
    <asp:Button ID="Button1" runat="server" Text="註冊" OnClick="Button1_Click" />
</asp:Content>
