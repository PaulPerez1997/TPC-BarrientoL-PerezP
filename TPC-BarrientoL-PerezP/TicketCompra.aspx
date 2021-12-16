<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="TicketCompra.aspx.cs" Inherits="TPC_BarrientoL_PerezP.DetalleCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="grilla">
    <% foreach (var Art in ListaDetalles)
    { %>

     <div  style="width: 18rem; border: solid 2px #f55151; padding: 10px; margin: 15px">
        <img src="<%:Art.imagenURL %>" class="card-img-top" alt="..." width:"100%">
    <div class="card-body">
    <h6 class="card-title">Detalles Articulo:</h6>
    <h6 class="card-title">ID Articulo: <%: Art.IDArticulo%></h6> 
    <h6 class="card-title">ID de la Compra: <%: Art.IDCompraRealizada%></h6> 
    <h6 class="card-title"><%: Art.NombreArticulo %></h6> 
    <h6 class="card-title"><%: Art.PrecioTotal %></h6>

     <br />
    <h6 class="card-title">Detalles Comprador:</h6> 
    <h6 class="card-title"><%: Art.DNIComprador %></h6> 
    <h6 class="card-title"><%: Art.NombreUsuarioComprador %></h6> 
    <h6 class="card-title"><%: Art.NombreComprador %>, <%: Art.ApellidoComprador %></h6>  
    <h6 class="card-title"><%: Art.TelefonoComprador %></h6> 
    <h6 class="card-title"><%: Art.MailComprador %></h6>
    <h6 class="card-title"><%: Art.DireccionAEnviar %></h6> 
        <br />
    <h6 class="card-title">Detalles Vendedor:</h6>
    <h6 class="card-title"><%: Art.DNIVendedor %></h6> 
    <h6 class="card-title"><%: Art.NombreUsuarioVendedor %></h6> 
    <h6 class="card-title"><%: Art.NombreVendedor %>, <%: Art.ApellidoVendedor %></h6>  
    <h6 class="card-title"><%: Art.TelefonoVendedor %></h6> 
    <h6 class="card-title"><%: Art.MailVendedor %></h6>
    
    <%-- <asp:Button Text="Agregar Al Carrito"  ID="BtnAgregaralCarrito" OnClick="BtnAgregaralCarrito_Click"  runat="server" Cssclass="btn btn-light btn-outline-danger" type="submit" />--%>   
    </div>
    </div>
    
        
  <%  } %>
    </div>


</asp:Content>
