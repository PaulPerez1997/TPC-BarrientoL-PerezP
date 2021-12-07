<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassyAdmin.Master" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="TPC_BarrientoL_PerezP.error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <div class="container">
    <div class="row">
    <div class="col-3"></div>
    <div class="col-6" style="margin: 10px;">
    <h5>
    <asp:Label Text="" ID="lblerror" runat="server" />
    </h5>
    </div>
    <div class="col-5"></div>
    <div class="col-6">
    <asp:Button Text="Iniciar Sesion" ID="BtnIniciar" OnClick="BtnIniciar_Click" runat="server" Cssclass="btn btn-light btn-outline-danger" type="submit"/>
    </div>
    </div>
    </div>
   
   
</asp:Content>
