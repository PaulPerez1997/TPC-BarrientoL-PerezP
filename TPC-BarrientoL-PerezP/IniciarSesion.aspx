<%@ Page Title="IniciarSesion" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Cuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="margin-top:10px;"> 
    <div class="col-4"></div>
     <div class="col-3" >
        <asp:Label Text="Nombre de Usuario" ID="lblMail" runat="server" Cssclass="form-label"/>
        <asp:TextBox runat="server" ID="TBUser"  Cssclass="form-control btn-outline-danger"/>
     </div>
     </div> 
        
    <div class="row" style="margin-top 10px;"> 
    <div class="col-4"></div>
     <div class="col-3" >
         <asp:Label Text="Contraseña" ID="lblContraseña" runat="server" Cssclass="form-label"/>
         <asp:TextBox runat="server" ID="TBContraseña" type="password" Cssclass="form-control btn-outline-danger"/>
         <asp:Button style ="margin-top: 10px" Text="Ingresar" ID="BtnIngresar" runat="server" Cssclass="btn btn btn-light btn-outline-danger" OnClick="BtnIngresar_Click"/>
     </div>
     </div>

     <div class="mb-3">
        <asp:Label Text="" ID="Welcome" runat="server" Cssclass="form-label"/> 
     </div>

</asp:Content>
