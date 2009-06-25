<%@ Page Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MercaSisFE.WebForm3" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        width: 262px;
    }
    .style2
    {
        width: 120px;
    }
    .style3
    {
        width: 123px;
    }
    .style4
    {
        width: 118px;
    }
    .style7
    {
        width: 118px;
        height: 6px;
    }
    .style8
    {
        height: 6px;
    }
        .style13
        {
            width: 176px;
        }
        .style14
        {
            width: 136px;
            height: 6px;
        }
        .style15
        {
            width: 136px;
        }
        .style16
        {
            width: 141px;
            height: 6px;
        }
        .style17
        {
            width: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="style1" colspan="2">
            <table style="width: 359%;" align="center">
                <tr>
                    <td class="style13"><br />
                        <h5>Ja sou cliente</h5></td>
                </tr>
                <tr>
                    <td class="style13" align="left">
                        Seu E-mail:</td>
                </tr>
                <tr>
                    <td class="style13" align="left">
            <asp:TextBox ID="txtEmail" runat="server" Width="175px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style13" align="left">
                        Sua Senha:</td>
                </tr>
                <tr>
                    <td class="style13" align="left">
            <asp:TextBox ID="txtSenha" runat="server" Width="175px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style13">
                        <asp:LinkButton ID="lkbProsCad" runat="server">Prossegir</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </td>
        <td colspan="2">
            <table style="width:0%; margin-top: 0px;" align="left">
                <tr>
                    <td>
            <h5>Ainda não sou cliente</h5></td>
                </tr>
                <tr>
                    <td align="left">
            Informe seu CEP:</td>
                </tr>
                <tr>
                    <td align="left">
            <asp:TextBox ID="txtCEPNovo" runat="server" Width="175px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <asp:LinkButton ID="lkbProsNovo" runat="server" onclick="lkbProsNovo_Click">Prossegir</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <br />
        </td>
    </tr>
    <tr>
        <td align="justify" class="style14">
            Esqueci minha senha</td>
        <td align="char" class="style16">
            <asp:LinkButton ID="lkbLembSenh" runat="server">Lembrar via e-mail</asp:LinkButton>
        </td>
        <td class="style7">
            Não sei meu CEP</td>
        <td align="char" class="style8">
            <asp:LinkButton ID="lkbBuscaCEP" runat="server">Procurar</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="style15">
            Meu e-mail mudou</td>
        <td align="char" class="style17">
            <asp:LinkButton ID="lkbAlterEmail" runat="server">Alterar E-mail</asp:LinkButton>
        </td>
        <td class="style4">
            Estou fora do brasil</td>
        <td align="char">
            <asp:LinkButton ID="lkbEntregIntern" runat="server">Entrega internacioal</asp:LinkButton>
        </td>
    </tr>
</table>
<br />
</asp:Content>
