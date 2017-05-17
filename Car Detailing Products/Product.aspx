<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Car_Detailing_Products.Product1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--https://www.youtube.com/watch?v=SFDQ6Lkp8Ec -->
    <style type="text/css">
        .auto-style1 {
            height: 67px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/Product.css" rel="stylesheet" />
    <div id="product">
    <table>
        <tr>
            <td rowspan="4">
                <asp:image ID="imgProduct" runat="server" CssClass="detailsImage"/>
            </td><h2>
                <asp:label ID="lblTitle" runat="server" text="Label"></asp:label>
                <hr/>
                 </h2>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:label>
            </td>
            <td> <asp:label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:label></td><br/>
            Quantity:
            <asp:dropdownlist ID="ddlAmount" runat="server"></asp:dropdownlist><br/>
            <asp:label ID="lblResult" runat="server" Text=""></asp:label>
        </tr>
        <tr>
            <td>Product Name:<asp:label ID="lblItemNr" runat="server" text="Label"></asp:label> 
                <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Add Product" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:label runat="server" text="Available" CssClass="productPrice"></asp:label> </td>
            
        </tr>
    </table>
    </div>
</asp:Content>
