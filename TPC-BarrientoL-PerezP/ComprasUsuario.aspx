<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassyAdmin.Master" AutoEventWireup="true" CodeBehind="ComprasUsuario.aspx.cs" Inherits="TPC_BarrientoL_PerezP.ComprasUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="margin:20px">
        <asp:GridView id="GVCompras" runat="server" CssClass="table" style="margin:20px;"></asp:GridView>

      <div class="row" style="margin:20px">
        <div class="col-1"></div>
        <div class="col-2" style="margin:20px">
            <asp:TextBox id="TBDni" runat="server" Cssclass="form-control" placeholder="Dni Usuario" />
        </div>
        <div class="col-2" style="margin:2px">
            <asp:Button Text="Ver Compras" id="BtnCompras" OnClick="BtnCompras_Click" runat="server" Cssclass="btn btn-light btn-outline-danger"  style="margin:20px"/>
        </div> 
        <div class="col-2" ">
            <asp:Button id="admin" OnClick="admin_Click" Text="Menu Admin" runat="server" Cssclass="btn btn-light btn-outline-danger"  style="margin:20px"/>
        </div>
      </div>
    </div>

</asp:Content>
