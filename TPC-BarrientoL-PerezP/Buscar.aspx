<%@ Page Title="Buscar" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Buscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%--<asp:GridView ID="GVArticulos" CssClass="table" runat="server"></asp:GridView>--%>
    <div id="grilla">
    <% foreach (var Art in Busqueda)
    { %>

     <div  style="width: 18rem; border: solid 1px grey; padding: 10px; margin: 15px">
        <img src="<%: Art.ImagenURL%>" class="card-img-top" alt="..." width="100%">
    <div class="card-body">
    <h5 class="card-title"><%: Art.Nombre %></h5>
    <h5 class="card-title"><%: Art.Marca.Descripcion %></h5>  
    <h6 class="card-title"><%: Art.Categoria.Descripcion %></h6>
    <p class="card-text">Precio: <%: Art.Precio %></p>
    <p class="card-text"><%: Art.Descripcion %></p>
    <p class="card-text">Peso: <%: Art.Peso_kg %></p>
    <p class="card-text">Largo: <%: Art.Largo_cm%></p>

     </div>
    </div>
    
        
  <%  } %>
    </div>
   

    

</asp:Content>
