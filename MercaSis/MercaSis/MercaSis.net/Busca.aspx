<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true"
    CodeBehind="Busca.aspx.cs" Inherits="MercaSisFE.Busca" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <asp:ListView ID="ListView1" runat="server">
    </asp:ListView>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        AllowSorting="True" PageSize="3">
    </asp:GridView>
    <asp:DataGrid ID="DataGrid1" runat="server">
    </asp:DataGrid>
</asp:Content>
