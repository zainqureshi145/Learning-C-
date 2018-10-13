<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UpdateUser.aspx.cs" Inherits="Forms_UpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <br /><br />
    <table border="1" width="80%">                
         <tr>
            <td style="text-align:center">
                <b>Update Users</b>
            </td>
        </tr>

        <tr>
            <td style="text-align:center">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvUsers" runat="server" Width="100%"></asp:GridView>
            </td>
        </tr>
        </table> 
        <br />
        <table border="1" width="80%"> 
        <tr>
            <td style="text-align:center">
               ID = <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp;                
            </td>
        </tr>
        <tr>
            <td style="text-align:center">
               Name = <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>&nbsp;                
            </td>
        </tr>
        <tr>
            <td style="text-align:center">                
                <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click"  />
            </td>
        </tr>
        </table>
        <br />
        <table border="1" width="80%">  
        <tr>    
            <td  style="text-align:center;">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>                
            </td>
        </tr>
       </table>
</asp:Content>

