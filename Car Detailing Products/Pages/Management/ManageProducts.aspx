<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="Car_Detailing_Products.Pages.Management.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--https://www.youtube.com/watch?v=hkiYuPBwnkQ-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    </p>
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        Type:</p>
    <p>
        <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_1526927_1526927_co5025ConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [Name]"></asp:SqlDataSource>
    </p>
    <p>
        Price:</p>
    <p>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    </p>
    <p>
        Image:</p>
    <p>
        <asp:DropDownList ID="ddlImage" runat="server" Width="160px">
        </asp:DropDownList>
    </p>
    <p>
        Description:</p>
    <p>
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
</asp:Content>
