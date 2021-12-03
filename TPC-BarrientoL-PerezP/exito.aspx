<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="exito.aspx.cs" Inherits="TPC_BarrientoL_PerezP.exito" %>
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

        <div class="row" style="margin:20px">
        <div class="col-5"></div>
        <div class="col-1">
            <asp:Button id="BtnVolver" OnClick="BtnVolver_Click" Text="Volver" runat="server" Cssclass="btn btn-outline-success" />
        </div> 
        </div>
     
    </div>

</asp:Content>
