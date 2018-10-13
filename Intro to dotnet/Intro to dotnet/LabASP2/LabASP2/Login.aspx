<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LabASP2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


        <table style="width:100%;" border=1>
            <tr>
                <td width=25%>Usernamse</td>
                <td> 
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="Please enter usernae" 
                        ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>                
            </tr>
             <tr>
                <td width=25%>Password</td>
                <td> 
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                 </td>                
            </tr>

             <tr>
                <td colspan=2 align=center>
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                    <br />
                    <br />
                    <asp:Label ID="lblMessage" runat="server" ForeColor="#CC0000"></asp:Label>
                 </td>
             </tr>
           
        </table>
  



</asp:Content>
