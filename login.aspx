<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="sozlukforum_script.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
        <div>
            <asp:TextBox ID="textbox_username" runat="server"></asp:TextBox>
            <asp:TextBox ID="textbox_password" runat="server"></asp:TextBox>
            <asp:Button ID="button_signin" runat="server" OnClick="button_signin_Click" Text="button_signin" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:TextBox ID="textbox_username_signup" runat="server"></asp:TextBox>
            <asp:TextBox ID="textbox_password_signup" runat="server"></asp:TextBox>
            <asp:TextBox ID="textbox_password_signup_control" runat="server"></asp:TextBox>
            <asp:Button ID="button_signup" runat="server" OnClick="button_signup_Click" Text="Button" />
            <asp:Label ID="Label2" runat="server" Text="oooo"></asp:Label>
        </div>
    
</body>
</html>

</asp:Content>
