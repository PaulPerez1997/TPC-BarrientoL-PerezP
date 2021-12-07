<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassyAdmin.Master" AutoEventWireup="true" CodeBehind="ModificarCategoria.aspx.cs" Inherits="TPC_BarrientoL_PerezP.ModificarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="margin:100px;">
         <div class="col-1"></div>
         <div class="col-3" >
            <asp:DropDownList id="ddlCategoria" runat="server" CssClass="btn btn-outline-dark dropdown-toggle">
            </asp:DropDownList>
        </div>
        <div class="col-3" >
            
             <asp:TextBox runat="server" ID="TBNuevoNombre" Cssclass="form-control" placeholder="Nuevo Nombre"/>
         </div>
        <div class="col-2">

            <asp:Button Text="Modificar Categoria" runat="server" id="BtnModificarCategoria"  Cssclass="btn btn-outline-success" OnClick="BtnModificarCategoria_Click"/>

        </div>
    </div>



</asp:Content>
