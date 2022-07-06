<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="entrys.aspx.cs" Inherits="sozlukforum_script.entrys" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
        <div>

            <asp:Label ID="Label1" runat="server" Text="lens"></asp:Label>
            <br />

            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <table border="1" cellpadding="1" cellspacing="1" style="width:500px">
	<tbody>
		<tr>
			<td><p><%#Eval("entry")%></p></td>
			<td>&nbsp;</td>
		</tr>
	
		<tr>
			<td>&nbsp;</td>
			<td> <text><%#Eval("date")%></text>- <text><%#Eval("author")%></text></td>
		</tr>
	</tbody>
</table>




                </ItemTemplate>
            </asp:ListView>
        </div>



</asp:Content>
