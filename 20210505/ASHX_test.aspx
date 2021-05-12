<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ASHX_test.aspx.cs" Inherits="_20210505.ASHX_test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" UseSubmitBehavior="False" />
    <asp:Label ID="Message" runat="server"></asp:Label>
    <asp:Image ID="Image1" runat="server" />
</asp:Content>
