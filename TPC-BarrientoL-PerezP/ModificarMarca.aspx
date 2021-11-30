<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="ModificarMarca.aspx.cs" Inherits="TPC_BarrientoL_PerezP.ModificarMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
     <div class="row" style="margin:100px;">
         <div class="col-1"></div>
         <div class="col-2" >
            <asp:DropDownList id="ddlMarca" runat="server" CssClass="btn btn-outline-dark dropdown-toggle">
            </asp:DropDownList>
        </div>
        <div class="col-3" >
            
             <asp:TextBox runat="server" ID="TBNuevoNombre" Cssclass="form-control" placeholder="Nuevo Nombre"/>
         </div>
        <div class="col-2">

        <asp:Button Text="Modificar Marca" runat="server" id="BtnAgregarMarca" OnClick="BtnAgregarMarca_Click"  Cssclass="btn btn-outline-success" />

        </div>
            
                
               

   
   

</asp:Content>
