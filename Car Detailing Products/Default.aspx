<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Car_Detailing_Products.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 150px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/Default.css" rel="stylesheet" />
    <div id="home">
   
        <table>
      <tr>
          <td class="auto-style1"><img src="Image/Default/Essence%20Plus.jpg" alt=""/></td>
          <td><img src="Image/Default/Reflect.jpg" alt=""/></td>
          <td><img src="Image/Default/Fixer.jpg" alt="" /></td>
          <td><img src="Image/Default/Essence.jpg" alt=""/></td>
     </tr>
    <tr>
        <td class="auto-style1"><img src="Image/Default/Pads/Cool%20Pad.jpg" alt="" /></td>
        <td><img src="Image/Default/Pads/Finishing%20pad.jpg" alt=""/></td>
        <td><img src="Image/Default/Pads/Lake%20Pad.jpg" alt="" /></td>
        <td><img src="Image/Default/Pads/Microfiber%20Pad.jpg" alt=""/></td>
    </tr>
            </table>
      </div>

 
</asp:Content>
