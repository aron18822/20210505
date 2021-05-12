<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="text2.aspx.cs" Inherits="_20210505.text2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/scissors.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/stone.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/paper.png" OnClick="Button_Click" />
    </br>
    <asp:Label ID="userResult" runat="server"></asp:Label>
    </br>
    <asp:Image ID="computerImage" runat="server" BorderStyle="None" Height="138px" Width="153px" />
    <asp:Label ID="LabelWin" runat="server"></asp:Label>
    <asp:Label ID="Labeleven" runat="server"></asp:Label>
    <asp:Label ID="LabelLose" runat="server"></asp:Label>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AccountConnectionString %>" SelectCommand="SELECT * FROM [accountInformation]"></asp:SqlDataSource>
    </br>
    <asp:Label ID="computerResult" runat="server"></asp:Label>
    </br>
    <asp:Label ID="final" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    <asp:Button ID="logout" runat="server" Text="登出" OnClick="logout_Click" />
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
    </asp:Timer>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
    <br />
</asp:Content>
