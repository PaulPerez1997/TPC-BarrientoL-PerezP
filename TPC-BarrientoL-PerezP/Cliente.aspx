<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="TPC_BarrientoL_PerezP.MiPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
        <div class="container" >

        <div class="row">
        <div class="col-6"></div>
        <h1>
        <asp:Label Text="" id="lblBienvenida" runat="server" />
        </h1>
        </div>   

        <div class="row">
        <div class="col-4"></div>    
        <h5>
        <asp:Label Text="Que Desea hacer ?" id="lblquehacemos" runat="server" />
        </h5>
        </div>
         </div>

        <div class="container" >
        <div class="row" style="margin: 30px;" >
        
        <div class="col-1">
        <asp:Button Text="Ir al Carrito" ID="BtnCarrito" OnClick="BtnCarrito_Click" runat="server" CssClass="btn btn btn-light btn-outline-danger" />
        </div>
      
          <div class="col-1"></div>
        <div class="col-1">
        <asp:Button Text="Mis Compras" ID="BtnMisCompras" OnClick="BtnMisCompras_Click" runat="server" CssClass="btn btn btn-light btn-outline-danger" />
        
        </div>

        
        <div class="col-1"></div>
        <div class="col-1">
        <asp:Button Text="Favoritos" ID="BtnFavorito" OnClick="BtnFavorito_Click" runat="server" CssClass="btn btn btn-light btn-outline-danger" />
       
        </div>


        
        <div class="col-1"></div>
        <div class="col-1">
        <asp:Button Text="Mi Perfil" id="BtnPerfil" Onclick="BtnPerfil_Click" runat="server" CssClass="btn btn btn-light btn-outline-danger"/>
        </div>

         <div class="col-1"></div>
        <div class="col-1">
        <asp:Button Text="Mis Ventas" ID="BtnMisVentas" OnClick="BtnMisVentas_Click" runat="server" CssClass="btn btn btn-light btn-outline-danger" /> 
        </div>

        <div class="col-1"></div>
        <div class="col-1">
        <asp:Button Text="Vender" ID="BtnVender" OnClick="BtnVender_Click" runat="server" CssClass="btn btn btn-light btn-outline-danger" /> 
        </div>
        
        </div>
        </div>
      

        
     


</asp:Content>
