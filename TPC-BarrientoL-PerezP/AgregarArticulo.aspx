<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassyAdmin.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="margin:10px;">

        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Nombre: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBNombre" runat="server" Cssclass="form-control" placeholder="Nombre" />
            </div>
        </div>

    
        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Marca: " runat="server" CssClass="form-label"/>
                <asp:DropDownList id="ddlMarca" runat="server" CssClass="btn btn-light btn-outline-danger dropdown-toggle">
                </asp:DropDownList>

               
            
                </div>
        </div>


        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Categoria: " runat="server" CssClass="form-label"/>
                <asp:DropDownList id="ddlCategoria" runat="server" CssClass="btn btn-light btn-outline-danger  dropdown-toggle">
                   
                </asp:DropDownList>
                </div>
        </div>


        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Descripcion: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBDescripcion" runat="server" Cssclass="form-control" placeholder="Descripcion"/>
                </div>
        </div>


        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Precio: " runat="server" CssClass="form-label"/>
            <asp:TextBox id="TBPrecio" runat="server" CssClass="form-control" placeholder="Precio"/>
                </div>
        </div>


        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Peso en KG: " runat="server" CssClass="form-label"/>
            <asp:TextBox  id="TBPeso_KG" runat="server" Cssclass="form-control" placeholder="Peso"/>
                </div>
        </div>

        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Largo en Cm: " runat="server" CssClass="form-label" />
            <asp:TextBox id="TBLargo_cm" runat="server" Cssclass="form-control" placeholder="Centimetros"/>
                </div>
        </div>


        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Url de la Imagen: " runat="server" CssClass="form-label" />
            <asp:TextBox id="TBImagenURL" runat="server" Cssclass="form-control" placeholder="Url"/>
                </div>
        </div>


        <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
            <asp:Label Text="Stock" runat="server" CssClass="form-label"/>
            <asp:TextBox ID="TBStock" runat="server" Cssclass="form-control" placeholder="Stock"/>
                </div>
        </div>

         <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
                <asp:Button Text="Agregar Articulo" runat="server" id="BtnAgregarArticulo" OnClick="BtnAgregarArticulo_Click" Cssclass="btn btn btn-light btn-outline-danger" />
                </div>
        </div>

    </div>

</asp:Content>
