<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ViewUser.aspx.cs" Inherits="Forms_ViewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br /><br />
    <table border="0" width="80%">                
            <tr>
            <td style="text-align:center">
                <b>Register Users</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvUsers" runat="server" Width="100%"></asp:GridView>
            </td>
        </tr>
         <tr>    
            <td  style="text-align:center;">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>                
            </td>
        </tr>
        </table>
</asp:Content>

