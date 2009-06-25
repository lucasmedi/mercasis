<%@ Page Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="CadastrarCliente.aspx.cs" Inherits="MercaSisFE.WebForm4" Title=".::MercaSis::. Cadastro de Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style3
        {
        width: 150px;
    }
        .style4
        {
            width: 150px;
            height: 25px;
        }
        .style5
        {
            width: 258px;
            height: 25px;
        }
        .style6
        {
            height: 25px;
        }
        .style9
    {
        width: 258px;
    }
    .style10
    {
        width: 258px;
        height: 24px;
    }
    .style13
    {
        width: 150px;
        height: 35px;
    }
    .style14
    {
        width: 258px;
        height: 35px;
    }
    .style15
    {
        height: 35px;
    }
    .style16
    {
        width: 150px;
        height: 42px;
    }
    .style17
    {
        width: 258px;
        height: 42px;
    }
    .style18
    {
        height: 42px;
    }
    .style20
    {
        height: 20px;
        width: 150px;
    }
    .style21
    {
        height: 20px;
    }
    .style22
    {
        width: 258px;
        height: 20px;
    }
        .style23
        {
            height: 24px;
            width: 150px;
        }
        .style24
        {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">    
    <table style="width:100%; height: 382px;">
        <tr>
            <td align="left" class="style3">
                &nbsp;</td>
            <td align="center"><h3>
                <asp:Label ID="lblHead" runat="server" Text="Cadastro de Pessoa Fisica"></asp:Label>
                </h3></td>
        </tr>
        <tr>
            <td align="right" class="style13">
                Nome:</td>
            <td align="center" class="style14">
                <asp:TextBox ID="txtNome" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style15">
                <asp:LinkButton ID="lkbAlterarEntCad" runat="server" 
                    onclick="lkbAlterarEntCad_Click">Alterar Para Pessoa Juridica</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="right" class="style16">
                <asp:Label ID="lblCPF_CNPJ" runat="server" Text="CPF:"></asp:Label>
            </td>
            <td align="center" class="style17">
                <asp:TextBox ID="txtCPF" runat="server" Width="220px"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtCNPJ" runat="server" Enabled="False" Visible="False" 
                    Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style18">
                (apenas nnumeros, sem pontos ou tracos)</td>
        </tr>
        <tr>
            <td align="right" class="style16">
                <asp:Label ID="lblEntidade" runat="server" Enabled="False" Text="Entidade" 
                    Visible="False"></asp:Label>
            </td>
            <td align="center" class="style17">
                <asp:TextBox ID="txtEntidade" runat="server" Enabled="False" Visible="False" 
                    Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style18">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Sexo:</td>
            <td align="center" class="style9">
                <asp:RadioButtonList ID="rblSexo" runat="server">
                    <asp:ListItem Selected="True">Masculino</asp:ListItem>
                    <asp:ListItem>Feminino</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Data de Nascimento:</td>
            <td align="center" class="style9">
                <asp:TextBox ID="txtDataNasc" runat="server" MaxLength="10" Width="220px">dd/mm/aaa</asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Telefone Residencial:</td>
            <td align="center" class="style9">
                <asp:TextBox ID="txtDDDRes" runat="server" Width="35px"></asp:TextBox>
                -<asp:TextBox ID="txtTelRes" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td align="center">
                DDD-Telefone</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Telefone Celular:</td>
            <td align="center" class="style9">
                <asp:TextBox ID="txtDDDCel" runat="server" Width="35px"></asp:TextBox>
                -<asp:TextBox ID="txtTelCel" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td align="center">
                DDD-Telefone (Opcional)</td>
        </tr>
        <tr>
            <td align="right" class="style20">
                &nbsp;</td>
            <td align="center" class="style22">
                <h4>Identificação:</h4>
            </td>
            <td align="center" class="style21">
                </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Seu e-mail:</td>
            <td align="center" class="style5">
                <asp:TextBox ID="txtEmail" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Senha:</td>
            <td align="center" class="style5">
                <asp:TextBox ID="txtSenha" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Confirma Senha:</td>
            <td align="center" class="style5">
                <asp:TextBox ID="txtConfSenha" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Como gostaria de ser chamado?</td>
            <td align="center" class="style5">
                <asp:TextBox ID="txtComoChamar" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td align="center" class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                &nbsp;</td>
            <td align="center" class="style5">
                &nbsp;</td>
            <td align="center" class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style23">
            </td>
            <td align="center" class="style10">
                <h3>Endereço</h3></td>
            <td class="style24">
            </td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Endereco:</td>
            <td align="center" class="style10">
                <asp:TextBox ID="txtEndereco" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Numero:</td>
            <td align="center" class="style10">
                <asp:TextBox ID="txtNumero" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Complemento:</td>
            <td align="center" class="style10">
                <asp:TextBox ID="txtComplemento" runat="server" 
                   Width="220px"></asp:TextBox>
            </td>
            <td align="center">
                Opcional</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                CEP:</td>
            <td align="center" class="style10">
                <asp:TextBox ID="txtCEPIni" runat="server" Width="175px"></asp:TextBox>
                -<asp:TextBox ID="txtCEPFim" runat="server" Width="35px"></asp:TextBox>
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Bairro:</td>
            <td align="center" class="style10">
                <asp:TextBox ID="txtBairro" runat="server" 
                    Width="220px"></asp:TextBox>
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Cidade:</td>
            <td align="center" class="style10">
                <asp:TextBox ID="txtCidade" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                Estado:</td>
            <td align="center" class="style10">
                <asp:DropDownList ID="ddlEstado" runat="server">
                    <asp:ListItem Selected="True">Selecione</asp:ListItem>
                    <asp:ListItem Value="AC">Acre</asp:ListItem>
                    <asp:ListItem Value="AL">Alagoas</asp:ListItem>
                    <asp:ListItem Value="AM">Amazonas</asp:ListItem>
                    <asp:ListItem Value="AM">Amapá</asp:ListItem>
                    <asp:ListItem Value="BA">Bahia</asp:ListItem>
                    <asp:ListItem Value="CE">Ceará</asp:ListItem>
                    <asp:ListItem Value="DF">Distrito Federal</asp:ListItem>
                    <asp:ListItem Value="ES">Espirito Santo</asp:ListItem>
                    <asp:ListItem Value="GO">Goiás</asp:ListItem>
                    <asp:ListItem Value="MA">Maranhão</asp:ListItem>
                    <asp:ListItem Value="MG">Mato Grosso</asp:ListItem>
                    <asp:ListItem Value="MT">Mato Grosso do Sul</asp:ListItem>
                    <asp:ListItem Value="MG">Minas Gerais</asp:ListItem>
                    <asp:ListItem Value="PA">Pará</asp:ListItem>
                    <asp:ListItem Value="PB">Paraiba</asp:ListItem>
                    <asp:ListItem Value="PE">Pernambuco</asp:ListItem>
                    <asp:ListItem Value="PI">Piauí</asp:ListItem>
                    <asp:ListItem Value="PR">Paraná</asp:ListItem>
                    <asp:ListItem Value="RJ">Rio de Janeiro</asp:ListItem>
                    <asp:ListItem Value="RN">Rio Grande do Norte</asp:ListItem>
                    <asp:ListItem Value="RS">Rio Grande do Sul</asp:ListItem>
                    <asp:ListItem Value="RO">Rondônia</asp:ListItem>
                    <asp:ListItem Value="RR">Roraima</asp:ListItem>
                    <asp:ListItem Value="SC">Santa Catarina</asp:ListItem>
                    <asp:ListItem Value="SE">Sergipe</asp:ListItem>
                    <asp:ListItem Value="SP">São Paulo</asp:ListItem>
                    <asp:ListItem Value="TO">Tocantins</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style3">
                &nbsp;</td>
            <td align="center" class="style10">
                <asp:Button ID="btnProsseguir" runat="server" Text="Prosseguir" 
                    UseSubmitBehavior="False" onclick="btnProsseguir_Click" />
            </td>
            <td align="center">
                &nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>
