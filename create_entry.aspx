<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="create_entry.aspx.cs" Inherits="sozlukforum_script.create_entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_session_result" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;<asp:Label ID="lbl_topic" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="textbox_topic" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="textbox_entry" runat="server"></asp:TextBox>
    <asp:Button ID="button_send" runat="server" Text="Button" />
</asp:Content>
