<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Admin_Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <table width="100%">
           <tr>
               <td>
                   Reports
               </td>
           </tr> 
         <tr>
               <td>
                   Date
               </td>
                <td>
                   
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                   
               </td>
           </tr> 
          <tr>
               <td colspan="2">
                   <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
               </td>
           </tr> 
            <tr>
               <td colspan="2">
                   <asp:GridView ID="dgReport" runat="server" EmptyDataText="no record exists"></asp:GridView>
               </td>
           </tr> 

        <tr>
               <td colspan="2">
                   <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
               </td>
           </tr> 
    </table>
</asp:Content>

