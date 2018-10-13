<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br><br>
    <table border="1" width="80%">                
            <tr>
            <td style="text-align:center" colspan="2" >
                <b>Registration</b>
            </td>
        </tr>
        <tr>
            <td>Name</td>    
            <td>
                <asp:TextBox ID="txtName" runat="server" MaxLength="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Enter Name" ForeColor="#CC0000" ValidationGroup="vgRegister">*</asp:RequiredFieldValidator>
            </td> 
        </tr>
            <tr>
            <td>Email</td>    
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Email" ForeColor="#CC0000" ValidationGroup="vgRegister">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email Address" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgRegister">*</asp:RegularExpressionValidator>
                </td>
        </tr>
            <tr>
            <td>Password</td>    
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="16"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter Password" ForeColor="#CC0000" ValidationGroup="vgRegister">*</asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td colspan="2"  style="text-align:center;">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" ValidationGroup="vgRegister" />
            </td>
        </tr>
        <tr>    
            <td  colspan="2"  style="text-align:center;">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" ValidationGroup="vgRegister" />

            </td>

        </tr>
    </table>

</asp:Content>

