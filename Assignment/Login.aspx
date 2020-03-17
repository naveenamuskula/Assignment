<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="border-spacing:20px;">
        <tr>
            <td>Empid</td>
            <td>
                <asp:TextBox ID="txtempid" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Cannot Be Blank" ControlToValidate="txtempid" EnableClientScript="True" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Cannot Be Blank" ControlToValidate="txtpassword" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            
            <td>
                <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/>
            </td>
            <td></td>
        </tr>
         <tr>
             <td>
                 <asp:Label ID="Label1" runat="server" Text=" "></asp:Label></td>
         </tr>
    </table>
</asp:Content>
