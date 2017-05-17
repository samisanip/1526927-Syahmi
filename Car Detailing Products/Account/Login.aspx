<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Car_Detailing_Products.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--https://www.youtube.com/watch?v=mBrxQQJdoHM&spfreload=10-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
</p>
<p>
    Username:</p>
<p>
    <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
</p>
<p>
    Password:</p>
<p>
    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnLogin" runat="server" CssClass="button" OnClick="btnLogin_Click" Text="Login" />
</p>
</asp:Content>
