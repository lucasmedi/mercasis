<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true"
    CodeBehind="Busca.aspx.cs" Inherits="MercaSisFE.Busca" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SdsProdutos" 
        EnableModelValidation="True">
        <ItemTemplate>
            <span style="">
            <img alt="" src="/bd/ImagensBD/<%# Eval("pro_imagem") %>" /><br />
            pro_nome:
            <asp:Label ID="pro_nomeLabel" runat="server" Text='<%# Eval("pro_nome") %>' />
            <br />
            pro_preco:
            <asp:Label ID="pro_precoLabel" runat="server" Text='<%# Eval("pro_preco") %>' />
            <br />
            pro_descricao:
            <asp:Label ID="pro_descricaoLabel" runat="server" 
                Text='<%# Eval("pro_descricao") %>' />
            <br />
            pro_imagem:
            <asp:Label ID="pro_imagemLabel" runat="server" 
                Text='<%# Eval("pro_imagem") %>' />
            <br />
            <br />
            </span>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <span style="">
            <img alt="" src="/bd/ImagensBD/<%# Eval("pro_imagem") %>" /><br />
            pro_nome:
            <asp:Label ID="pro_nomeLabel" runat="server" Text='<%# Eval("pro_nome") %>' />
            <br />
            pro_preco:
            <asp:Label ID="pro_precoLabel" runat="server" Text='<%# Eval("pro_preco") %>' />
            <br />
            pro_descricao:
            <asp:Label ID="pro_descricaoLabel" runat="server" 
                Text='<%# Eval("pro_descricao") %>' />
            <br />
            pro_imagem:
            <asp:Label ID="pro_imagemLabel" runat="server" 
                Text='<%# Eval("pro_imagem") %>' />
            <br />
            <br />
            </span>
        </AlternatingItemTemplate>
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <span style="">
            <img alt="" src="/bd/ImagensBD/<%# Eval("pro_imagem") %>" /><br />
            pro_nome:
            <asp:TextBox ID="pro_nomeTextBox" runat="server" 
                Text='<%# Bind("pro_nome") %>' />
            <br />
            pro_preco:
            <asp:TextBox ID="pro_precoTextBox" runat="server" 
                Text='<%# Bind("pro_preco") %>' />
            <br />
            pro_descricao:
            <asp:TextBox ID="pro_descricaoTextBox" runat="server" 
                Text='<%# Bind("pro_descricao") %>' />
            <br />
            pro_imagem:
            <asp:TextBox ID="pro_imagemTextBox" runat="server" 
                Text='<%# Bind("pro_imagem") %>' />
            <br />
            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                Text="Insert" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                Text="Clear" />
            <br />
            <br />
            </span>
        </InsertItemTemplate>
        <LayoutTemplate>
            <div ID="itemPlaceholderContainer" runat="server" style="">
                <span ID="itemPlaceholder" runat="server" />
            </div>
            <div style="">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                            ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                            ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <EditItemTemplate>
            <span style="">
            <img alt="" src="/bd/ImagensBD/<%# Eval("pro_imagem") %>" /><br />
            pro_nome:
            <asp:TextBox ID="pro_nomeTextBox" runat="server" 
                Text='<%# Bind("pro_nome") %>' />
            <br />
            pro_preco:
            <asp:TextBox ID="pro_precoTextBox" runat="server" 
                Text='<%# Bind("pro_preco") %>' />
            <br />
            pro_descricao:
            <asp:TextBox ID="pro_descricaoTextBox" runat="server" 
                Text='<%# Bind("pro_descricao") %>' />
            <br />
            pro_imagem:
            <asp:TextBox ID="pro_imagemTextBox" runat="server" 
                Text='<%# Bind("pro_imagem") %>' />
            <br />
            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                Text="Update" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                Text="Cancel" />
            <br />
            <br />
            </span>
        </EditItemTemplate>
        <SelectedItemTemplate>
            <span style="">
            <img alt="" src="/bd/ImagensBD/<%# Eval("pro_imagem") %>" /><br />
            pro_nome:
            <asp:Label ID="pro_nomeLabel" runat="server" Text='<%# Eval("pro_nome") %>' />
            <br />
            pro_preco:
            <asp:Label ID="pro_precoLabel" runat="server" Text='<%# Eval("pro_preco") %>' />
            <br />
            pro_descricao:
            <asp:Label ID="pro_descricaoLabel" runat="server" 
                Text='<%# Eval("pro_descricao") %>' />
            <br />
            pro_imagem:
            <asp:Label ID="pro_imagemLabel" runat="server" 
                Text='<%# Eval("pro_imagem") %>' />
            <br />
            <br />
            </span>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SdsProdutos" runat="server" ConnectionString="<%$ ConnectionStrings:MerceSisConnString %>"
        SelectCommand="SELECT [pro_nome], [pro_preco], [pro_descricao], [pro_imagem] FROM [Produto]">
    </asp:SqlDataSource>
</asp:Content>
