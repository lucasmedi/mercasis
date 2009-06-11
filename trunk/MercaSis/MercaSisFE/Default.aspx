<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MercaSisFE._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div style="width: 156px">
        <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" 
            DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#990000" StaticSubMenuIndent="10px">
            <StaticSelectedStyle BackColor="#FFCC66" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <Items>
                <asp:MenuItem Text="Menu Principal" Value="Menu Principal"></asp:MenuItem>
                <asp:MenuItem Text="Alimentos e Bebidas" Value="Alimentos e Bebidas">
                </asp:MenuItem>
                <asp:MenuItem Text="AutoMotivo" Value="AutoMotivo"></asp:MenuItem>
                <asp:MenuItem Text="Brinquedos" Value="Brinquedos"></asp:MenuItem>
                <asp:MenuItem Text="Beleza e Saude" Value="Beleza e Saude"></asp:MenuItem>
                <asp:MenuItem Text="BlockBuster" Value="BlockBuster"></asp:MenuItem>
                <asp:MenuItem Text="Bebês" Value="Bebês"></asp:MenuItem>
                <asp:MenuItem Text="Cameras e Filmadoras" Value="Cameras e Filmadoras">
                </asp:MenuItem>
                <asp:MenuItem Text="CD's + DVD's" Value="New Item"></asp:MenuItem>
                <asp:MenuItem Text="Casa e Jardin" Value="Casa e Jardin"></asp:MenuItem>
                <asp:MenuItem Text="Cama, Mesa e Banho" Value="Cama, Mesa e Banho">
                </asp:MenuItem>
                <asp:MenuItem Text="DVD's e BlueRays" Value="DVD's e BlueRays"></asp:MenuItem>
                <asp:MenuItem Text="Eletrodomésticos" Value="Eletrodomésticos"></asp:MenuItem>
                <asp:MenuItem Text="Esporte &amp; Lazer" Value="Esporte &amp; Lazer">
                </asp:MenuItem>
                <asp:MenuItem Text="Eletronicos" Value="Eletronicos"></asp:MenuItem>
                <asp:MenuItem Text="Eletroportateis" Value="Eletroportateis"></asp:MenuItem>
                <asp:MenuItem Text="Futebol" Value="Futebol"></asp:MenuItem>
                <asp:MenuItem Text="Flores" Value="Flores"></asp:MenuItem>
                <asp:MenuItem Text="Games e Softwares" Value="Games e Softwares"></asp:MenuItem>
                <asp:MenuItem Text="Informática" Value="Informática"></asp:MenuItem>
                <asp:MenuItem Text="Informática Acessorios" Value="Informática Acessorios">
                </asp:MenuItem>
                <asp:MenuItem Text="Instrumentos Musicais" Value="Instrumentos Musicais">
                </asp:MenuItem>
                <asp:MenuItem Text="Livros" Value="Livros"></asp:MenuItem>
                <asp:MenuItem Text="Ingressos" Value="Ingressos"></asp:MenuItem>
                <asp:MenuItem Text="Moda e Acessório" Value="Moda e Acessório"></asp:MenuItem>
                <asp:MenuItem Text="Malas e Acessorio" Value="Malas e Acessorio"></asp:MenuItem>
                <asp:MenuItem Text="Moveis e Decoração" Value="Moveis e Decoração">
                </asp:MenuItem>
                <asp:MenuItem Text="Música" Value="Música"></asp:MenuItem>
                <asp:MenuItem Text="Papelaria" Value="Papelaria"></asp:MenuItem>
                <asp:MenuItem Text="Relógios e Presentes" Value="Relógios e Presentes">
                </asp:MenuItem>
                <asp:MenuItem Text="Suplementos e Vitaminas" Value="Suplementos e Vitaminas">
                </asp:MenuItem>
                <asp:MenuItem Text="Telefones &amp; Celukares" 
                    Value="Telefones &amp; Celukares"></asp:MenuItem>
                <asp:MenuItem Text="Tênis" Value="Tênis"></asp:MenuItem>
                <asp:MenuItem Text="Utilidades Dométicas" Value="Utilidades Dométicas">
                </asp:MenuItem>
                <asp:MenuItem Text="Vinhos" Value="Vinhos"></asp:MenuItem>
                <asp:MenuItem Text="Viagens" Value="Viagens"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>
    </form>
</body>
</html>
