<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Favoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="grilla">
    <% foreach (var Art in ListaFavoritos)
    { %>

     <div  style="width: 18rem; border: solid 2px #f55151; padding: 10px; margin: 15px">
        <img src="<%: Art.ImagenURL%>" class="card-img-top" alt="..." width:"100%">
    <div class="card-body">
    <h5 class="card-title"><%: Art.Nombre %></h5> 
    <h5 class="card-title"><%: Art.Marca.Descripcion %></h5>  
    <h6 class="card-title"><%: Art.Categoria.Descripcion %></h6>
    <p class="card-text">Precio: <%: Art.Precio %></p>
    <p class="card-text"><%: Art.Descripcion %></p>
    <p class="card-text">Peso: <%: Art.Peso_kg %></p>
    <p class="card-text">Largo: <%: Art.Largo_cm%></p>
    <a href="Favoritos.aspx?id=<%: Art.ID %>" class="btn btn-light btn-outline-danger">Agregar Al Carrito</a>
    <%-- <asp:Button Text="Agregar Al Carrito"  ID="BtnAgregaralCarrito" OnClick="BtnAgregaralCarrito_Click"  runat="server" Cssclass="btn btn-light btn-outline-danger" type="submit" />--%>   
    </div>
    </div>
    
        
  <%  } %>
    </div>



</asp:Content>
