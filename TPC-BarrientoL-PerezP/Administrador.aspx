<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               
                <div class="text-center" style="margin:10px;">
                    <asp:Label Text="" runat="server" ID="lblAdmin" />
                    
                </div>
               
             <div class="container" style="margin:10px;">
               <div class="row" style="margin:10px;">
                   <div class="col-2"></div>

                 <div class="col"  >
                     <asp:Label Text="Articulo: " runat="server" />
                    <asp:Button Text="Agregar" runat="server" Cssclass="btn btn-outline-success" ID="BtnAgregar" OnClick="BtnAgregar_Click" />
                    <asp:Button Text="Modificar" runat="server" CssClass="btn btn-outline-success" ID="BtnModificar" OnClick="BtnModificar_Click" /> 
                     <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-outline-success" ID="BtnEliminar" OnClick="BtnEliminar_Click" />
                     </div>
               
               </div> 
            </div> 

               <div class="row" style="margin:20px;">
                 <div class="col-2"></div>
                 <div class="col">
                     <asp:Label Text="Marca: " runat="server" />
                    <asp:Button Text="Agregar Marca" runat="server" Cssclass="btn btn-outline-success" OnClick="BtnAgregarMarca_Click" ID="BtnAgregarMarca"  />
                    <asp:Button Text="Modificar Marca" runat="server" CssClass="btn btn-outline-success" onClick="BtnModificarMarca_Click" ID="BtnModificarMarca"  />
                 </div>         
               </div>

              <div class="row" style="margin:20px;"> 
                <div class="col-2"></div>
                    <div class="col">
                <asp:Label Text="Categoria: " runat="server" />
                <asp:Button Text="Agregar Categoria" runat="server" Cssclass="btn btn-outline-success" onclick="BtnAgregarCategoria_Click" ID="BtnAgregarCategoria"  />
                <asp:Button Text="Modificar Categoria" runat="server" CssClass="btn btn-outline-success" OnClick="BtnModificarCategoria_Click" ID="BtnModificarCategoria"  />
                    </div>
                  
              <div class="row" style="margin:20px;"> 
                <div class="col-2"></div>
                    <div class="col">
                <asp:Button Text="Registrar Administrador" runat="server" Cssclass="btn btn-outline-success" onclick="BtnAgregarAdmin_Click" ID="BtnAgregarAdmin"  />
               
                    </div>
            
              </div>

            </div>




   

   

   





</asp:Content>
