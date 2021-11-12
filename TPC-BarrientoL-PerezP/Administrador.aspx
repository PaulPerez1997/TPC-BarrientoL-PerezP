<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label Text="" runat="server" ID="Lbladmin" />

    <asp:Button Text="Agregar" runat="server" Cssclass="btn btn-outline-success" ID="BtnAgregar" OnClick="BtnAgregar_Click" />

    <asp:Button Text="Modificar" runat="server" CssClass="btn btn-outline-success" ID="BtnModificar" OnClick="BtnModificar_Click" />
</asp:Content>
