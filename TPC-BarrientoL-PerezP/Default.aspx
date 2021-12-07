<% @ Page Title="Inicio" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_BarrientoL_PerezP.inicio" %>
 <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
 
    <div id="grilla">
    <% foreach (var Art in ListaArticulos)
    { %>

     <div  style="width: 18rem; border: solid 2px #f55151; padding: 10px; margin: 15px">
        <img src="<%: Art.ImagenURL%>" class="card-img-top" alt="..." width:"100%">
        <div class="card-body">
        <h5 class="card-title"><%: Art.Nombre %></h5>
        <p class="card-text"><%: Art.Descripcion %></p>
        <a href="Default.aspx?id=<%:Art.ID %>" class="btn btn-light btn-outline-danger">Agregar a Favoritos</a>
    </div>
    </div>     
  <%  } %>
    </div>
   

</asp:Content>

