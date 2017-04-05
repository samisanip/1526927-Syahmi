<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Car_Detailing_Products.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/Contact.css" rel="stylesheet" />   
    
<html>
    <body>
        <div id="contact">
        <fieldset>
        <legend>Contact Us</legend>
         <table>
             <tr>
                 <td>
                     <b>Name:</b>
                 </td>
                 <td>
                     <asp:TextBox ID="txtName" runat="server" placeholder="Your Name..." Width="250px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td>
                     <b>Last Name:</b>
                 </td>
                 <td> <asp:TextBox ID="txtLastName" runat="server" placeholder="Your Last Name..." Width="250px"></asp:TextBox></td>
             </tr>
             <tr>
                 <td>
                     <b>Email:</b>
                 </td>
                 <td> <asp:TextBox ID="txtEmail" runat="server" placeholder="Your Email..." Width="250px"></asp:TextBox></td>
             </tr>
             <tr>
                 <td>
                     <b>Message:</b>
                 </td>
                 <td> <asp:TextBox ID="txtMessage" runat="server" placeholder="Any Comment..." Width="300px"></asp:TextBox></td>
             </tr>
             <tr>
                 <td>
                     <asp:Button ID="Button1" runat="server" Text="Submit" />
                 </td>
             </tr>
                
         </table>
        </fieldset>
        </div>

        <div id="map">
            <fieldset>
                <legend>Our Location</legend>
                <img src="Image/Default/Location.png" />
            </fieldset>
        </div>

</body>
</html>
</asp:Content>
