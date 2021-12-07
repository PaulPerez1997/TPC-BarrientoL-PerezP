<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassyAdmin.Master" AutoEventWireup="true" CodeBehind="EliminarArticulo.aspx.cs" Inherits="TPC_BarrientoL_PerezP.EliminarArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="margin:20px">
        <div class="col-2"></div>
        <div class="col-3">
    <asp:TextBox ID="TBBuscarArticulo"  runat="server"  Cssclass="form-control me-2" type="search" placeholder="Introduzca articulo"  ></asp:TextBox>                     
        </div>
        <div class="col-3">   
    <asp:Button Text="Buscar" runat="server" ID="BtnBuscar"  Cssclass="btn btn-outline-success" onclick="BtnBuscar_Click" type="submit" />
            </div>
    </div>

        <div id="grilla">
    <% foreach (var Art in Busqueda)
    { %>

     <div  style="width: 18rem; border: solid 1px grey; padding: 10px; margin: 15px">
        <img src="<%: Art.ImagenURL%>" class="card-img-top" alt="..." style="width:100%">
    <div class="card-body">
    <h5 class="card-title"><%: Art.Nombre %></h5>
    <h5 class="card-title"><%: Art.Marca.Descripcion %></h5>  
    <h6 class="card-title"><%: Art.Categoria.Descripcion %></h6>
    <p class="card-text">Precio: <%: Art.Precio %></p>
    <a href="EliminarArticulo.aspx?id=<%:Art.ID %>" class="btn btn-primary">Eliminar Articulo</a>
    

     </div>
    </div>
    
        
  <%  } %>
    </div>

    <div class="container">
    <div class="row" style="margin:30px">
    <div class="col-2"></div>
    <div class="col-3">
        <asp:Label Text="Articulo" CssClass="card-title" runat="server" />
    </div>
    </div>

    <div class="row" style="margin:5px">
    <div class="col-1"></div>
    <div class="col-3">
    <asp:Label Text="Nombre:  " runat="server" CssClass="form-label"/>
    <asp:TextBox id="TBNombre" runat="server" Cssclass="form-control" placeholder="Nombre" />
    </div>
    </div>

        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">
        <asp:Label Text="Marca:  " runat="server" CssClass="form-label"/>
        <asp:TextBox id="TBMarca" runat="server" Cssclass="form-control" placeholder="Nombre" />
        </div>     
        </div>

        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">  
         <asp:Label Text="Categoria:  " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBCategoria" runat="server" Cssclass="form-control" placeholder="Nombre" />
        </div>
        </div>

        
        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Descripcion: " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBDescripcion" runat="server" Cssclass="form-control" placeholder="Descripcion" />
        </div>
       </div>


        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">
        <asp:Label Text="Precio: " runat="server" CssClass="form-label"/>
        <asp:TextBox id="TBPrecio" runat="server" Cssclass="form-control" placeholder="Precio" />
        </div>
        </div>

         <div class="row" style="margin:5px">
         <div class="col-1"></div>
         <div class="col-3">
         <asp:Label Text="Peso en KG" runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBPeso_kg" runat="server" Cssclass="form-control" placeholder="Peso en KG" />
         </div>
         </div>

         <div class="row" style="margin:5px">
         <div class="col-1"></div>
         <div class="col-3">
         <asp:Label Text="Largo en CM: " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBLargo_cm" runat="server" Cssclass="form-control" placeholder="Largo en CM" />
         </div>
         </div>

        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="URL de Imagen: " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBImagenURL" runat="server" Cssclass="form-control" placeholder="URL" />
         </div>
        </div>

        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Stock: " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBStock" runat="server" Cssclass="form-control" placeholder="Stock" />
        </div>
        </div>
        

        <div class="row" style="margin:5px">
        <div class="col-1"></div>
        <div class="col-3">
        <asp:Button id="BtnEliminar" OnClick="BtnEliminar_Click"  Text="Eliminar Articulo" runat="server" Cssclass="btn btn-outline-success" />
        </div>
        </div>


    </div>

</asp:Content>
