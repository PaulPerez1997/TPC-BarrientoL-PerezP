<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       
    <div class="container">
    <div class="row">
    <div class="col-3"></div>
    <div class="col-6" style="margin: 10px;">
    <h5>
    <asp:Label Text="" ID="lblCarrito" runat="server" />
    </h5>
    </div>
  <%--  <div class="col-5"></div>
    <div class="col-6">
    <asp:Button Text="Iniciar Sesion" ID="BtnIniciar" OnClick="BtnIniciar_Click" runat="server" Cssclass="btn btn-light btn-outline-danger" type="submit"/>
    </div>--%>
    </div>
    </div>

     <div id="grilla">
    <% foreach (var Arti in ListaCarrito)
    { %>

     <div  style="width: 18rem; border: solid 2px #f55151; padding: 10px; margin: 15px">
        <img src="<%: Arti.ImagenURL%>" class="card-img-top" alt="..." width:"100%">
    <div class="card-body">
    <h5 class="card-title"><%: Arti.Nombre %></h5> 
    <h5 class="card-title"><%: Arti.Marca.Descripcion %></h5>  
    <h6 class="card-title"><%: Arti.Categoria.Descripcion %></h6>
    <p class="card-text">Precio: <%: Arti.Precio %></p>
    <p class="card-text"><%: Arti.Descripcion %></p>
    <p class="card-text">Peso: <%: Arti.Peso_kg %></p>
    <p class="card-text">Largo: <%: Arti.Largo_cm%></p>
    <%--<asp:Button Text="Comprar"  ID="BtnComprar" OnClick="BtnComprar_Click" runat="server" Cssclass="btn btn-light btn-outline-danger" type="submit" />--%>
        <div class="row" style="margin: 3px;">
        <div style="margin: 6px;">
        <a href="Carrito.aspx?id=<%: Arti.ID %>" class="btn btn-light btn-outline-danger">Comprar</a>
        </div>
        <div style="margin: 6px;">
        <a href="Carrito.aspx?Quitarid=<%: Arti.ID %>" class="btn btn-light btn-outline-danger" >Quitar</a>
        </div>
        </div>

       
        </div>
    </div>
    
        
  <%  } %>
    </div>


</asp:Content>
