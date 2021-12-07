<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassyAdmin.Master" AutoEventWireup="true" CodeBehind="AgregarMarca.aspx.cs" Inherits="TPC_BarrientoL_PerezP.AgregarMarca" %>
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
       

         <div class="row" style="margin:10px;">
            <div class="col-4"></div>
            <div class="col-4">
                <asp:Button Text="Agregar Marca" runat="server" id="BtnAgregarMarca" onclick="BtnAgregarMarca_Click" Cssclass="btn btn-outline-success" />
            </div>
        </div>

        </div>


    </div>
    


</asp:Content>


