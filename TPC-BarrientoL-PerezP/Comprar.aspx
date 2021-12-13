<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Comprar.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Comprar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
    <div id="grilla">
   
    
    <div class="col-2"></div>
     <div class="col-2">
     <div  style="width: 18rem; border: solid 2px #f55151; padding: 10px; margin: 15px">
     <img src="<%: ArticuloEnVenta.ImagenURL%>" class="card-img-top" alt="..." width:"100%">
     </div>
     </div>
     <div class="col-1"></div>
     <div  style="width: 18rem; border: solid 2px #f55151; padding: 10px; margin: 15px">
    <div class="card-body">
    <h5 class="card-title"><%:ArticuloEnVenta.Nombre %></h5> 
    <h5 class="card-title"><%: ArticuloEnVenta.Marca.Descripcion %></h5>  
    <h6 class="card-title"><%: ArticuloEnVenta.Categoria.Descripcion %></h6>
    <p class="card-text">Precio: <%: ArticuloEnVenta.Precio %></p>
    <p class="card-text"><%: ArticuloEnVenta.Descripcion %></p>
    <p class="card-text">Peso en Kilogramo: <%: ArticuloEnVenta.Peso_kg %></p>
    <p class="card-text">Largo en CM: <%: ArticuloEnVenta.Largo_cm%></p>
    <p class="card-text">Stock: <%: ArticuloEnVenta.Stock %></p>
    <p class="card-text">Vendedor: <%: user.nombreusuario %></p>
    <asp:Button Text="Comprar" ID="BtnComprar" OnClick="BtnComprar_Click" runat="server" Cssclass="btn btn-light btn-outline-danger" />
    <%--<a href="Favoritos.aspx?id=<%: ArticuloEnVenta.ID %>" class="btn btn-light btn-outline-danger">Agregar Al Carrito</a>--%>
    </div>
      </div>
    </div>
   
   
    </div>


</asp:Content>
