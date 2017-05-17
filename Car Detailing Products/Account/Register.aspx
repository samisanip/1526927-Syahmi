<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Car_Detailing_Products.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--https://www.youtube.com/watch?v=mBrxQQJdoHM&spfreload=10 -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Register.css" rel="stylesheet" />
    <div id="register">
        <br />
    
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
        Confirm Password:</p>
    <p>
        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
        <p>
            First Name:</p>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
        <p>
            Last Name:</p>
        <p>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
        <p>
            Address:</p>
        <p>
            <asp:TextBox ID="txtAddress" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
        <p>
            Postal Code:</p>
        <p>
            <asp:TextBox ID="txtPostalCode" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Register" />
    </p>
       </div>
    
</asp:Content>
