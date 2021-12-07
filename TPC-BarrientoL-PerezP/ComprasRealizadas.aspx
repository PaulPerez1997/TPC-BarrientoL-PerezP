<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="ComprasRealizadas.aspx.cs" Inherits="TPC_BarrientoL_PerezP.ComprasRealizadas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="container" style="margin:20px">
        
        <div class="row">
         <div class="col-4"></div>
           <div class="col-5">
            <asp:Label Text="" ID="lblexito" runat="server" />
           </div>  
         </div>
        
        <asp:GridView id="GVCompras" runat="server" CssClass="table" style="margin:20px;"></asp:GridView>

        <div class="row" style="margin:20px">
        <div class="col-5"></div>
        <div class="col-1">
            <asp:Button id="Cliente" OnClick="Cliente_Click" Text="Menu Cliente" runat="server" Cssclass="btn btn-light btn-outline-danger" />
        </div> 
        </div>
     
    </div>


</asp:Content>
