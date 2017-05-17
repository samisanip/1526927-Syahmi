<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Car_Detailing_Products.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--https://www.youtube.com/watch?v=67fW_kNLghc&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9&index=7 -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlShoppingCart" runat="server">

    </asp:Panel>

    <table>
        <tr>
            <td><b>Total: </b></td>
            <td><asp:Literal ID="litTotal" runat="server" Text="" /></td>

            <td><b>Vat: </b></td>
            <td><asp:Literal ID="litVat" runat="server" Text="" /></td>

            <td><b>Shopping: </b></td>
            <td>$ 15</td>

            <td><b>Total Amount: </b></td>
            <td><asp:Literal ID="litTotalAmount" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Default.aspx"
                Text="Continue Shopping" />

                OR

                <asp:Button ID="btnCheckOut" runat="server" PostBackUrl="~/Success.aspx"
                CssClass="button" Width="250px" Text="Continue Checkout" />

            </td>
        </tr>
    </table>
</asp:Content>
