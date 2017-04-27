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
                     <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ErrorMessage="Name Is Required"
                     ControlToValidate="txtName"
                     Text="*"
                     ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td>
                     <b>Subject</b>
                 </td>
                 <td> 
                  <asp:TextBox ID="txtSubject" runat="server" Width="250px"></asp:TextBox>
                 </td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                     ErrorMessage="Subject Is Required"
                     ControlToValidate="txtSubject"
                     Text="*"
                     ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td>
                     <b>Email:</b>
                 </td>
                 <td> <asp:TextBox ID="txtEmail" runat="server"  Width="250px"></asp:TextBox></td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                     ErrorMessage="Email Is Required"
                     ControlToValidate="txtEmail"
                     Display="Dynamic"
                     Text="*"
                     ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td>
                     <b>Message:</b>
                 </td>
                 <td> <asp:TextBox ID="txtMessage" runat="server" Width="300px"></asp:TextBox></td>
                 <td>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                     ErrorMessage="Message Is Required"
                     ControlToValidate="txtMessage"
                     Text="*"
                     ForeColor="Red"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Please enter that is required" ForeColor="Red" runat="server" />
                 </td>
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td colspan="3">
                     <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                 </td>
             </tr>
                
         </table>
        </fieldset>
        </div>
        <div id="map">
            <fieldset>
                <legend>Our Location</legend>
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3975.321466155066!2d114.92947514971615!3d4.885730896435152!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x32228ac8ee3f7d03%3A0xcacd96016959ec39!2sLaksamana+College+of+Business!5e0!3m2!1sen!2sbn!4v1493261354141" width="400" height="300" frameborder="0" style="border:0" allowfullscreen></iframe>
            </fieldset>
        </div>

</body>
</html>
</asp:Content>
