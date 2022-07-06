<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sozlukforum_script.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
           <a href="/entrys.aspx?p=<%#Eval("topic")%>"><%#Eval("topic")%></a> (<%#Eval("entry_count")%>)<br />
               
        </ItemTemplate>
    </asp:ListView>
    <br />
</asp:Content>
