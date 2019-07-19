<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NumberSorter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="301px">1,2,5,4</asp:TextBox>
<asp:Button ID="Button1" runat="server" Height="22px" Text="Sort" OnClick="Button1_Click" />
<asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>

   

</asp:Content>
