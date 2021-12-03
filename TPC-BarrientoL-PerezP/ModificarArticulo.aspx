<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="ModificarArticulo.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="margin:20px">
        <div class="col-2"></div>
        <div class="col-3">
    <asp:TextBox ID="TBBuscarArticulo" runat="server" Cssclass="form-control me-2" type="search" placeholder="Introduzca articulo"  ></asp:TextBox>                     
        </div>
        <div class="col-3">   
    <asp:Button Text="Buscar" runat="server" ID="BtnBuscarArticulo" onclick="BtnBuscarArticulo_Click" Cssclass="btn btn-outline-success" type="submit" />
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
    <a href="ModificarArticulo.aspx?id=<%:Art.ID %>" class="btn btn-primary">Modificar Articulo</a>
    

     </div>
    </div>
    
        
  <%  } %>
    </div>

    <div class="container">
    <div class="row" style="margin:30px">
    <div class="col-1"></div>
    <div class="col-3">
        <asp:Label Text="Actual" CssClass="card-title" runat="server" />
    </div>
    <div class="col-1"></div>
    <div class="col-3">
    <asp:Label Text="Modificar" runat="server" />
    </div>
    </div>
    <div class="row" style="margin:20px">
    <div class="col-1"></div>

      <div class="col-3">
        <asp:Label Text="Nombre:  " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBNombre" runat="server" Cssclass="form-control" placeholder="Nombre" />
      </div>
        <div class="col-1"></div>
        <div class="col-3">
        <asp:Label Text="Nombre:  " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBNombreModificar" runat="server" Cssclass="form-control" placeholder="Nombre" />
      </div>

    </div>

        <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-3">
        <asp:Label Text="Marca:  " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBMarca" runat="server" Cssclass="form-control" placeholder="Nombre" />
         </div>
        <div class="col-1"></div>
       <div class="col-3" style="margin:20px">
           <asp:Label Text="Marca: " runat="server" />
          <asp:DropDownList ID="ddlMarca" runat="server" CssClass="btn btn-outline-dark dropdown-toggle">  
          </asp:DropDownList>
     
      </div>
        </div>

        <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-3">
            
        <asp:Label Text="Categoria:  " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBCategoria" runat="server" Cssclass="form-control" placeholder="Nombre" />
      </div>
         <div class="col-1"></div>
        <div class="col-5" style="margin:20px">
        <asp:Label Text="Categoria: " runat="server" />
          <asp:DropDownList id="ddlCategoria" runat="server" CssClass="btn btn-outline-dark dropdown-toggle">  
          </asp:DropDownList>
      </div>
        </div>

        
        <div class="row" style="margin:20px">
        <div class="col-1"></div>
      <div class="col-3">
         <asp:Label Text="Descripcion: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBDescripcion" runat="server" Cssclass="form-control" placeholder="Descripcion" />
      </div>
        <div class="col-1"></div>
      <div class="col-3">
         <asp:Label Text="Descripcion: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBDescripcionModificar" runat="server" Cssclass="form-control" placeholder="Descripcion" />
      </div>
       </div>

         <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Precio: " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBPrecio" runat="server" Cssclass="form-control" placeholder="Precio" />
      </div>
         <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Precio: " runat="server" CssClass="form-label"/>
         <asp:TextBox id="TBPrecioModificar" runat="server" Cssclass="form-control" placeholder="Precio" />
      </div>
         </div>

         <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Peso en KG" runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBPeso_kg" runat="server" Cssclass="form-control" placeholder="Peso en KG" />
      </div>
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Peso en KG" runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBPeso_kgModificar" runat="server" Cssclass="form-control" placeholder="Peso en KG" />
      </div>
          </div>

         <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Largo en CM: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBLargo_cm" runat="server" Cssclass="form-control" placeholder="Largo en CM" />
      </div>
          <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="Largo en CM: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBLargo_cmModificar" runat="server" Cssclass="form-control" placeholder="Largo en CM" />
      </div>
        </div>

        <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="URL de Imagen: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBImagenURL" runat="server" Cssclass="form-control" placeholder="URL" />
      </div>
        <div class="col-1"></div>
        <div class="col-3">
         <asp:Label Text="URL de Imagen: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBImagenURLModificar" runat="server" Cssclass="form-control" placeholder="URL" />
      </div>
        </div>

        <div class="row" style="margin:20px">
        <div class="col-1"></div>
       <div class="col-3">
         <asp:Label Text="Stock: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBStock" runat="server" Cssclass="form-control" placeholder="Stock" />
      </div>
       <div class="col-1"></div>
       <div class="col-3">
         <asp:Label Text="Stock: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBStockModificar" runat="server" Cssclass="form-control" placeholder="Stock" />
      </div>
         </div>

     <div class="row" style="margin:20px">
        <div class="col-5"></div>
       <div class="col-3">
           <asp:Button id="BtnModificar" OnClick="BtnModificar_Click" Text="Modificar" runat="server" Cssclass="btn btn-outline-success" />
      </div>
         </div>

    </div>
    

</asp:Content>


        
