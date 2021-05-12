<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="room.aspx.cs" Inherits="_20210505.room" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>    
    <asp:Button ID="btnMessage" runat="server" OnClick="btnMessage_Click" Text="送出" />
    <br />
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="lblChat" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
    <br />
    <asp:Button ID="logout" runat="server" Text="登出" OnClick="logout_Click" />
    <asp:Timer ID="Timer1" runat="server" Interval="100" OnTick="Timer1_Tick">
    </asp:Timer>
</asp:Content>
